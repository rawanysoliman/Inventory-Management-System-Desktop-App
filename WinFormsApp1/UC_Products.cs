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
    public partial class UC_Products : UserControl
    {
        public UC_Products()
        {
            InitializeComponent();
            LoadProducts();
            LoadComboBoxData();

        }


        private void LoadComboBoxData()
        {
            using (myContext context = new myContext())
            {
                try
                {
                    cbCategory.DataSource = context.Categories.ToList();
                    cbCategory.DisplayMember = "CategoryName";
                    cbCategory.ValueMember = "CategoryId";


                }
                catch (Exception ex)
                { MessageBox.Show($"An error occurred: {ex.Message}"); }
            }
        }


        private void LoadProducts()
        {
            using (myContext context = new myContext())
            {
                dgvProducts.DataSource = context.Products.ToList();
                RemoveUnwantedColumns();
            }
        }

        private void RemoveUnwantedColumns()
        {
            // Remove columns by name
            dgvProducts.Columns["supplyPermProducts"].Visible = false;
            dgvProducts.Columns["releasePermProducts"].Visible = false;
            dgvProducts.Columns["transferPermProducts"].Visible = false;
            dgvProducts.Columns["WhProducts"].Visible = false;
            dgvProducts.Columns["Category"].Visible = false;
            dgvProducts.Columns["ProductMeasuringUnits"].Visible = false;




        }

        private void btnAddWh_Click(object sender, EventArgs e)
        {
            using (myContext context = new myContext())
            {
                double price;
                if (double.TryParse(txPrice.Text, out price))
                {
                    var Product = new Products
                    {
                        ProductName = txPrdctName.Text,
                        Price = price,
                        CategoryId = (int)cbCategory.SelectedValue
                    };
                    context.Products.Add(Product);
                    context.SaveChanges();
                    MessageBox.Show("New Product Added!");
                    LoadProducts();
                }
            }
        }


        private void txPrdctName_Enter(object sender, EventArgs e)
        {
            txPrdctName.RT_TB.Text = string.Empty;
        }

        private void txPrice_Enter(object sender, EventArgs e)
        {
            txPrice.RT_TB.Text = string.Empty;

        }


        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txPrdctName.Text = dgvProducts.Rows[e.RowIndex].Cells["ProductName"].Value.ToString();
                txPrice.Text = dgvProducts.Rows[e.RowIndex].Cells["Price"].Value.ToString();
                cbCategory.SelectedValue = dgvProducts.Rows[e.RowIndex].Cells["CategoryId"].Value;
            }
        }
        private void btnUpdatePrdct_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count > 0)
            {
                using (myContext context = new myContext())
                {
                    var product = context.Products.Find(dgvProducts.SelectedRows[0].Cells["ProductsId"].Value);
                    double price;
                    if (double.TryParse(txPrice.Text, out price))
                    {
                        product.ProductName = txPrdctName.Text;
                        product.Price = price;
                        product.CategoryId = (int)cbCategory.SelectedValue;
                        context.SaveChanges();
                        MessageBox.Show("Product Updated!");
                        LoadProducts();
                    }
                    else
                    {
                        MessageBox.Show("Invalid price value. Please enter a valid number.");
                    }
                }
            }
        }

        private void btnDltPrdct_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count > 0)
            {
                using (myContext context = new myContext())
                {
                    var product = context.Products.Find(dgvProducts.SelectedRows[0].Cells["ProductsId"].Value);
                    context.Products.Remove(product);
                    context.SaveChanges();
                    MessageBox.Show("Product Deleted!");
                    LoadProducts();
                }
            }
        }


    }

}
