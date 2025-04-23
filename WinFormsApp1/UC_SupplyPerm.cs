using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryManagementSystem.context;
using InventoryManagementSystem.Entities;
using Microsoft.EntityFrameworkCore;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class UC_SupplyPerm : UserControl
    {
        private SupplyPermission currentSupplyPermission;
        public UC_SupplyPerm()
        {
            InitializeComponent();
            LoadSupplyPermission();
            LoadComboBoxData();
        }


        private void LoadSupplyPermission()
        {
            using (myContext context = new myContext())
            {
                dgvSplyPerm.DataSource = context.SupplyPermissions.ToList();
                RemoveUnwantedColumns();
            }
        }



        private void RemoveUnwantedColumns()
        {
            // Remove columns by name
            dgvSplyPerm.Columns["warehouse"].Visible = false;
            dgvSplyPerm.Columns["supplyPermProducts"].Visible = false;
            dgvSplyPerm.Columns["supplier"].Visible = false;
        }


        private void LoadComboBoxData()
        {
            using (myContext context = new myContext())
            {

                try
                {

                    cbWhId.DataSource = context.Warehouses.ToList();
                    cbWhId.DisplayMember = "WarehouseName";// Show warehouse name
                    cbWhId.ValueMember = "WarhouseId"; //Store warehouse ID




                    cbSupplierId.DataSource = context.Suppliers.ToList();
                    cbSupplierId.DisplayMember = "SupplierName";
                    cbSupplierId.ValueMember = "SupplierId";


                    cbCategory.DataSource = context.Categories.ToList();
                    cbCategory.DisplayMember = "CategoryName";
                    cbCategory.ValueMember = "CategoryId";


                }
                catch (Exception ex)
                { MessageBox.Show($"An error occurred: {ex.Message}"); }
            }
        }



        private void LoadProductsByCategory()
        {
            using (myContext context = new myContext())
            {
                try
                {
                    if (cbCategory.SelectedValue != null && int.TryParse(cbCategory.SelectedValue.ToString(), out int selectedCategoryId))
                    {
                        var products = context.Products.Where(p => p.CategoryId == selectedCategoryId).ToList();

                        cbProductId.DataSource = products;
                        cbProductId.DisplayMember = "ProductName";
                        cbProductId.ValueMember = "ProductsId";
                    }
                    //else
                    //{
                    //    cbProductId.DataSource = context.Products.ToList();
                    //    cbProductId.DisplayMember = "ProductName";
                    //    cbProductId.ValueMember = "ProductsId";
                    //}
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadProductsByCategory();
        }



        private void btnAddSplyPerm_Click(object sender, EventArgs e)
        {
            myContext context = new myContext();
            int whId = (int)cbWhId.SelectedValue;
            int spId = (int)cbSupplierId.SelectedValue;
            DateTime splyDate = dtRlsDate.Value;

            AddSupplyPermission(context, whId, spId, splyDate, out currentSupplyPermission);
        }

        public void AddSupplyPermission(myContext context, int whId, int spId, DateTime splyDate, out SupplyPermission splyPerm)
        {
            splyPerm = null;
            try
            {
                // Validate foreign key values
                var warehouseExists = context.Warehouses.Any(w => w.WarhouseId == whId);
                var supplierExists = context.Suppliers.Any(s => s.SupplierId == spId);

                if (!warehouseExists)
                {
                    MessageBox.Show("Selected warehouse does not exist.");
                    return;
                }

                if (!supplierExists)
                {
                    MessageBox.Show("Selected supplier does not exist.");
                    return;
                }

                splyPerm = new SupplyPermission
                {
                    supplyDate = splyDate,
                    WarehouseId = whId,
                    supplierId = spId
                };
                context.SupplyPermissions.Add(splyPerm);
                context.SaveChanges();
                LoadSupplyPermission();


                MessageBox.Show("Supply Permission added successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }




        private void btnUpdateStock_Click_1(object sender, EventArgs e)
        {
            if (currentSupplyPermission == null)
            {
                MessageBox.Show("Please add a supply permission first.");
                return;
            }

            using (myContext context = new myContext())
            {
                int productId = (int)cbProductId.SelectedValue;
                int quantity = (int)numQuantity.Value;
                int expireDuration = int.Parse(txtExpDuration.Text);
                DateTime prdctDate = dtProDate.Value;

                var splyPerPrdcts = context.SupplyPermProducts
                    .FirstOrDefault(sp => sp.SupplyPermissionId == currentSupplyPermission.SupplyId && sp.ProductId == productId);

                if (splyPerPrdcts != null)
                {

                    splyPerPrdcts.ExpiryDuration = expireDuration;
                    splyPerPrdcts.ProductionDate = prdctDate;
                    splyPerPrdcts.Quantity += quantity;
                    splyPerPrdcts.supplyDate = currentSupplyPermission.supplyDate;
                }
                else
                {
                    splyPerPrdcts = new SupplyPermProducts
                    {
                        SupplyPermissionId = currentSupplyPermission.SupplyId,
                        ProductId = productId,
                        ExpiryDuration = expireDuration,
                        ProductionDate = prdctDate,
                        Quantity = quantity,
                        supplyDate = currentSupplyPermission.supplyDate,
                    };
                    context.SupplyPermProducts.Add(splyPerPrdcts);
                }

                var ProductStock = context.WhProductsBySuppliers
                    .FirstOrDefault(ps => ps.WarehouseId == currentSupplyPermission.WarehouseId
                                       && ps.ProductId == productId
                                       && ps.SupplierId == currentSupplyPermission.supplierId);

                if (ProductStock != null)
                {
                    ProductStock.CurrentStock += quantity;
                    ProductStock.ExpireDate = prdctDate.AddDays(expireDuration);
                    ProductStock.ProductionDate = prdctDate;
                    ProductStock.supplyDate = currentSupplyPermission.supplyDate;
                }
                else
                {
                    var newStock = new WhProductsBySupplier
                    {
                        WarehouseId = currentSupplyPermission.WarehouseId,
                        ProductId = productId,
                        SupplierId = currentSupplyPermission.supplierId,
                        CurrentStock = quantity,
                        ExpireDate = prdctDate.AddDays(expireDuration),
                        ProductionDate = prdctDate,
                        supplyDate = currentSupplyPermission.supplyDate
                    };
                    context.WhProductsBySuppliers.Add(newStock);
                }

                context.SaveChanges();
                MessageBox.Show("Products added to Supply Permission and stock updated successfully!");
            }
        }






        //load selected records into input boxes
        private void dgvSplyPerm_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dgvSplyPerm.SelectedRows.Count > 0)
            {
                int selectedSupplyId = (int)dgvSplyPerm.SelectedRows[0].Cells["SupplyId"].Value;

                using (myContext context = new myContext())
                {

                    currentSupplyPermission = context.SupplyPermissions
                        .Include(sp => sp.warehouse)
                        .Include(sp => sp.supplier)
                        .FirstOrDefault(sp => sp.SupplyId == selectedSupplyId);
                }

                if (currentSupplyPermission != null)
                {
                    cbWhId.SelectedValue = currentSupplyPermission.WarehouseId;
                    cbSupplierId.SelectedValue = currentSupplyPermission.supplierId;
                    dtRlsDate.Value = currentSupplyPermission.supplyDate;
                }
            }
        }


        public void EditSupplyPermission(myContext context, int supplyId, int whId, int spId, DateTime splyDate)
        {
            try
            {
                var splyPerm = context.SupplyPermissions.FirstOrDefault(sp => sp.SupplyId == supplyId);

                if (splyPerm == null)
                {
                    MessageBox.Show("Supply Permission not found.");
                    return;
                }

                splyPerm.supplyDate = splyDate;
                splyPerm.WarehouseId = whId;
                splyPerm.supplierId = spId;

                context.SaveChanges();
                LoadSupplyPermission();

                MessageBox.Show("Supply Permission updated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }



        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (currentSupplyPermission == null) //not selected
            {
                MessageBox.Show("Please select a supply permission to edit.");
                return;
            }

            using (myContext context = new myContext())
            {
                int whId = (int)cbWhId.SelectedValue;
                int spId = (int)cbSupplierId.SelectedValue;
                DateTime splyDate = dtRlsDate.Value;

                EditSupplyPermission(context, currentSupplyPermission.SupplyId, whId, spId, splyDate);
            }
        }

        private void txtExpDuration_Enter(object sender, EventArgs e)
        {
            txtExpDuration.Text = string.Empty;
        }
    }
}


