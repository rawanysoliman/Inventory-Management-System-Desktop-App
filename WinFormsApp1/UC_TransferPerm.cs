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

namespace WinFormsApp1
{
    public partial class UC_TransferPerm : UserControl
    {
        private TransferPermission currentTrPermission;


        public UC_TransferPerm()
        {
            InitializeComponent();
            UC_TransferPerm_Load();
            LoadComboBoxData();
            RemoveUnwantedColumns();
        }


        private void UC_TransferPerm_Load()
        {
            using (myContext context= new myContext())
            {
                dgvTransferPerm.DataSource = context.TransferPermissions.ToList();
            }
        }

        private void RemoveUnwantedColumns()
        {
            // Remove columns by name
            dgvTransferPerm.Columns["sourceWarehouse"].Visible = false;
            dgvTransferPerm.Columns["destWarehouse"].Visible = false;
            dgvTransferPerm.Columns["transferedItemDetails"].Visible = false;
        }





        private void LoadComboBoxData()
        {
            using (myContext context = new myContext())
            {

                try
                {

                    cbFromWhId.DataSource = context.Warehouses.ToList();
                    cbFromWhId.DisplayMember = "WarehouseName";// Show warehouse name
                    cbFromWhId.ValueMember = "WarhouseId"; //Store warehouse ID

                    cbToWhId.DataSource = context.Warehouses.ToList();
                    cbToWhId.DisplayMember = "WarehouseName";// Show warehouse name
                    cbToWhId.ValueMember = "WarhouseId"; //Store warehouse ID



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





        public void AddTransferPerm(myContext context, int fromwhId, int toWhId, int spId, DateTime trnsfrDate, out TransferPermission trnsfrPerm)
        {

                trnsfrPerm = null;
                try
                {
                    // Validate foreign key values
                    var warehouse1Exists = context.Warehouses.Any(w => w.WarhouseId == fromwhId);
                    var warehouse2Exists = context.Warehouses.Any(w => w.WarhouseId == toWhId);

                    var supplierExists = context.Suppliers.Any(s => s.SupplierId == spId);

                    if (!warehouse1Exists || !warehouse2Exists)
                    {
                        MessageBox.Show("Selected warehouse does not exist.");
                        return;
                    }

                    if (!supplierExists)
                    {
                        MessageBox.Show("Selected supplier does not exist.");
                        return;
                    }

                    trnsfrPerm = new TransferPermission
                    {
                        TransferDate = trnsfrDate,
                        sourceWarehouseId = fromwhId,
                        destWarehouseId = toWhId
                    };

                    context.TransferPermissions.Add(trnsfrPerm);
                    context.SaveChanges();
                    UC_TransferPerm_Load();

                    MessageBox.Show("Transfer Permission added successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }

        



        private void btnAddTransferPerm_Click(object sender, EventArgs e)
        {
            myContext context = new myContext();
            int fromWhID = (int)cbFromWhId.SelectedValue;
            int toWhID = (int)cbToWhId.SelectedValue;
            int supplierID = (int)cbSupplierId.SelectedValue;
            DateTime trnsfrDate = dtTransferDate.Value;
            AddTransferPerm(context, fromWhID, toWhID, supplierID, trnsfrDate, out TransferPermission trnsfrPerm);
            currentTrPermission = trnsfrPerm;
        }

        private void btnUpdateStock_Click(object sender, EventArgs e)
        {
            using (myContext context = new myContext())
            {
                if (currentTrPermission == null)
                {
                    MessageBox.Show("Please add a transfer permission first.");
                    return;
                }

                int productId = (int)cbProductId.SelectedValue;
                int quantity = (int)numQuantity.Value;
                DateTime expireDate = dbExpDate.Value;
                DateTime prdctDate = dtProdDate.Value;
                int expireDuration = (expireDate - prdctDate).Days;

                var transferProduct = context.TransferProductsBySuppliers
                    .FirstOrDefault(tp => tp.transferPermissionId == currentTrPermission.TransferId && tp.productID == productId);

                if (transferProduct != null)
                {
                    transferProduct.Quantity += quantity;
                    transferProduct.ExpireDate = expireDate;
                    transferProduct.ProductionDate = prdctDate;
                }
                else
                {
                    transferProduct = new TransferProductsBySuppliers
                    {
                        transferPermissionId = currentTrPermission.TransferId,
                        productID = productId,
                        supplierId = (int)cbSupplierId.SelectedValue,
                        Quantity = quantity,
                        ExpireDate = expireDate,
                        ProductionDate = prdctDate
                    };
                    context.TransferProductsBySuppliers.Add(transferProduct);
                }

                // Decrement stock in the source warehouse
                var sourceProductStock = context.WhProductsBySuppliers
                    .FirstOrDefault(ps => ps.WarehouseId == currentTrPermission.sourceWarehouseId
                                       && ps.ProductId == productId
                                       && ps.SupplierId == (int)cbSupplierId.SelectedValue);

                if (sourceProductStock != null)
                {
                    if (sourceProductStock.CurrentStock >= quantity)
                    {
                        sourceProductStock.CurrentStock -= quantity;
                    }
                    else
                    {
                        MessageBox.Show($"Insufficient stock in Source Warehouse for Product ID {productId}. Current stock: {sourceProductStock.CurrentStock}, Requested quantity: {quantity}");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show($"Product ID {productId} not found in Source Warehouse ID {currentTrPermission.sourceWarehouseId}.");
                    return;
                }

                // Increment stock in the destination warehouse
                var destProductStock = context.WhProductsBySuppliers
                    .FirstOrDefault(ps => ps.WarehouseId == currentTrPermission.destWarehouseId
                                       && ps.ProductId == productId
                                       && ps.SupplierId == (int)cbSupplierId.SelectedValue);

                if (destProductStock != null)
                {
                    destProductStock.CurrentStock += quantity;
                    destProductStock.ExpireDate = expireDate;
                    destProductStock.ProductionDate = prdctDate;
                    destProductStock.supplyDate = currentTrPermission.TransferDate;
                }
                else
                {
                    var newStock = new WhProductsBySupplier
                    {
                        WarehouseId = currentTrPermission.destWarehouseId,
                        ProductId = productId,
                        SupplierId = (int)cbSupplierId.SelectedValue,
                        CurrentStock = quantity,
                        ExpireDate = expireDate,
                        ProductionDate = prdctDate,
                        supplyDate = currentTrPermission.TransferDate
                    };
                    context.WhProductsBySuppliers.Add(newStock);
                }


                context.SaveChanges();
                MessageBox.Show("Products added to Transfer Permission and stock updated successfully");
            }
        }



    }
    
}

