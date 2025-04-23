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
    public partial class UC_Suppliers : UserControl
    {
        public UC_Suppliers()
        {
            InitializeComponent();
            LoadSuppliers();
        }

        private void LoadSuppliers()
        {
            using (myContext context = new myContext())
            {
                dgvSuppliers.DataSource = context.Suppliers.ToList();
                RemoveUnwantedColumns();
            }
        }
        private void RemoveUnwantedColumns()
        {
            // Remove columns by name if necessary
            dgvSuppliers.Columns["supplyPermissions"].Visible = false;
            dgvSuppliers.Columns["transferedItemDetails"].Visible = false;
            dgvSuppliers.Columns["productDetails"].Visible = false;
        }

        private void btnAddSp_Click(object sender, EventArgs e)
        {
            using (myContext context = new myContext())
            {
                var supplier = new Supplier
                {
                    SupplierName = txtSpName.Text,
                    SupplierLocation = txtSpLoc.Text,
                    PhoneNumber = txtSpPhone.Text,
                    Email = txtSpEmail.Text,
                    faxNumber = txtSpFax.Text
                };
                context.Suppliers.Add(supplier);
                context.SaveChanges();
                MessageBox.Show("New Supplier Added!");
                LoadSuppliers();
            }

        }

        private void dgvSuppliers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtSpName.Text = dgvSuppliers.Rows[e.RowIndex].Cells["SupplierName"].Value.ToString();
                txtSpLoc.Text = dgvSuppliers.Rows[e.RowIndex].Cells["SupplierLocation"].Value.ToString();
                txtSpPhone.Text = dgvSuppliers.Rows[e.RowIndex].Cells["PhoneNumber"].Value.ToString();
                txtSpEmail.Text = dgvSuppliers.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                txtSpFax.Text = dgvSuppliers.Rows[e.RowIndex].Cells["faxNumber"].Value.ToString();
            }

        }

        private void btnUpdateSp_Click(object sender, EventArgs e)
        {
            if (dgvSuppliers.SelectedRows.Count > 0)
            {
                using (myContext context = new myContext())
                {
                    var supplier = context.Suppliers.Find(dgvSuppliers.SelectedRows[0].Cells["SupplierId"].Value);
                    supplier.SupplierName = txtSpName.Text;
                    supplier.SupplierLocation = txtSpLoc.Text;
                    supplier.PhoneNumber = txtSpPhone.Text;
                    supplier.Email = txtSpEmail.Text;
                    supplier.faxNumber = txtSpFax.Text;
                    context.SaveChanges();
                    MessageBox.Show("Supplier Updated!");
                    LoadSuppliers();
                }
            }

        }

        private void btnDltSp_Click(object sender, EventArgs e)
        {
            if (dgvSuppliers.SelectedRows.Count > 0)
            {
                using (myContext context = new myContext())
                {
                    var supplier = context.Suppliers.Find(dgvSuppliers.SelectedRows[0].Cells["SupplierId"].Value);
                    context.Suppliers.Remove(supplier);
                    context.SaveChanges();
                    MessageBox.Show("Supplier Deleted!");
                    LoadSuppliers();
                }
            }
        }

        private void txtSpName_Enter(object sender, EventArgs e)
        {
            txtSpName.RT_TB.Text = string.Empty;

        }

        private void txtSpLoc_Enter(object sender, EventArgs e)
        {
            txtSpLoc.RT_TB.Text = string.Empty;

        }

        private void txtSpPhone_Enter(object sender, EventArgs e)
        {
            txtSpPhone.RT_TB.Text = string.Empty;

        }

        private void txtSpEmail_Enter(object sender, EventArgs e)
        {
            txtSpEmail.RT_TB.Text = string.Empty;

        }

        private void txtSpFax_Enter(object sender, EventArgs e)
        {
            txtSpFax.RT_TB.Text = string.Empty;

        }
    }
}
