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
using InventoryManagementSystem.Migrations;
using Microsoft.EntityFrameworkCore;

namespace WinFormsApp1
{
    public partial class UC_ReleasePerm : UserControl
    {
        private ReleasePermission currentReleasePermission;

        public UC_ReleasePerm()
        {
            InitializeComponent();
            LoadReleasePermission();
            LoadComboBoxData();
        }

        private void LoadReleasePermission()
        {
            using (myContext context = new myContext())
            {
                dgvRelsPerm.DataSource = context.ReleasePermissions.ToList();
                RemoveUnwantedColumns();
            }
        }

        private void RemoveUnwantedColumns()
        {
            // Remove columns by name
            dgvRelsPerm.Columns["warehouse"].Visible = false;
            dgvRelsPerm.Columns["releasePermProducts"].Visible = false;
            dgvRelsPerm.Columns["customer"].Visible = false;
        }

        private void LoadComboBoxData()
        {
            using (myContext context = new myContext())
            {
                try
                {
                    cbWhId.DataSource = context.Warehouses.ToList();
                    cbWhId.DisplayMember = "WarehouseName";
                    cbWhId.ValueMember = "WarhouseId";

                    cbCustomerId.DataSource = context.Customers.ToList();
                    cbCustomerId.DisplayMember = "CustomerName";
                    cbCustomerId.ValueMember = "CustomerId";

                    cbCategory.DataSource = context.Categories.ToList();
                    cbCategory.DisplayMember = "CategoryName";
                    cbCategory.ValueMember = "CategoryId";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
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

        private void btnAddReleasePerm_Click(object sender, EventArgs e)
        {
            myContext context = new myContext();
            int whId = (int)cbWhId.SelectedValue;
            int custId = (int)cbCustomerId.SelectedValue;
            DateTime releaseDate = dtRlsDate.Value;

            AddReleasePermission(context, whId, custId, releaseDate, out currentReleasePermission);
        }

        public void AddReleasePermission(myContext context, int whId, int custId, DateTime releaseDate, out ReleasePermission releasePerm)
        {
            releasePerm = null;
            try
            {
                // Validate foreign key values
                var warehouseExists = context.Warehouses.Any(w => w.WarhouseId == whId);
                var customerExists = context.Customers.Any(c => c.CustomerId == custId);

                if (!warehouseExists)
                {
                    MessageBox.Show("Selected warehouse does not exist.");
                    return;
                }

                if (!customerExists)
                {
                    MessageBox.Show("Selected customer does not exist.");
                    return;
                }

                releasePerm = new ReleasePermission
                {
                    ReleaseDate = releaseDate,
                    warehouseId = whId,
                    CustomerId = custId
                };
                context.ReleasePermissions.Add(releasePerm);
                context.SaveChanges();
                LoadReleasePermission();

                MessageBox.Show("Release Permission added successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }



        private void dgvReleasePerm_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvRelsPerm.SelectedRows.Count > 0)
            {
                int selectedReleaseId = (int)dgvRelsPerm.SelectedRows[0].Cells["ReleasePermissionId"].Value;

                using (myContext context = new myContext())
                {
                    currentReleasePermission = context.ReleasePermissions
                        .Include(rp => rp.warehouse)
                        .Include(rp => rp.customer)
                        .FirstOrDefault(rp => rp.ReleasePermissionId == selectedReleaseId);
                }

                if (currentReleasePermission != null)
                {
                    cbWhId.SelectedValue = currentReleasePermission.warehouseId;
                    cbCustomerId.SelectedValue = currentReleasePermission.CustomerId;
                    dtRlsDate.Value = currentReleasePermission.ReleaseDate;
                }
            }
        }

        public void EditReleasePermission(myContext context, int releaseId, int whId, int custId, DateTime releaseDate)
        {
            try
            {
                var releasePerm = context.ReleasePermissions.FirstOrDefault(rp => rp.ReleasePermissionId == releaseId);

                if (releasePerm == null)
                {
                    MessageBox.Show("Release Permission not found.");
                    return;
                }

                releasePerm.ReleaseDate = releaseDate;
                releasePerm.warehouseId = whId;
                releasePerm.CustomerId = custId;

                context.SaveChanges();
                LoadReleasePermission();

                MessageBox.Show("Release Permission updated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }


        private void btnUpdateStock_Click_1(object sender, EventArgs e)
        {
            if (currentReleasePermission == null)
            {
                MessageBox.Show("Please add a release permission first.");
                return;
            }

            using (myContext context = new myContext())
            {
                int productId = (int)cbProductId.SelectedValue;
                int quantity = (int)numQuantity.Value;

                var releasePermProducts = context.ReleasePermProducts
                    .FirstOrDefault(rp => rp.releasePermissionId == currentReleasePermission.ReleasePermissionId && rp.productId == productId);

                if (releasePermProducts != null)
                {
                    releasePermProducts.quantity += quantity;
                }
                else
                {
                    releasePermProducts = new ReleasePermProducts
                    {
                        releasePermissionId = currentReleasePermission.ReleasePermissionId,
                        productId = productId,
                        quantity = quantity,
                        ReleaseDate = currentReleasePermission.ReleaseDate
                    };
                    context.ReleasePermProducts.Add(releasePermProducts);
                }

                var productStock = context.WhProductsBySuppliers
                    .FirstOrDefault(ps => ps.WarehouseId == currentReleasePermission.warehouseId
                                       && ps.ProductId == productId);

                if (productStock != null)
                {
                    if (productStock.CurrentStock >= quantity)
                    {
                        productStock.CurrentStock -= quantity;
                    }
                    else
                    {
                        MessageBox.Show($"Insufficient stock for Product ID {productId}. Current stock: {productStock.CurrentStock}, Requested quantity: {quantity}");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show($"Product ID {productId} not found in Warehouse ID {currentReleasePermission.warehouseId}.");
                    return;
                }

                context.SaveChanges();
                MessageBox.Show("Products added to Release Permission and stock updated successfully!");
            }
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (currentReleasePermission == null)
            {
                MessageBox.Show("Please select a release permission to edit.");
                return;
            }

            using (myContext context = new myContext())
            {
                int whId = (int)cbWhId.SelectedValue;
                int custId = (int)cbCustomerId.SelectedValue;
                DateTime releaseDate = dtRlsDate.Value;

                EditReleasePermission(context, currentReleasePermission.ReleasePermissionId, whId, custId, releaseDate);
            }

        }

    }
}

