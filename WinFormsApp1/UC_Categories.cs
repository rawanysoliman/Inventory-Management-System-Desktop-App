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
    public partial class UC_Categories : UserControl
    {
        public UC_Categories()
        {
            InitializeComponent();
            LoadCategories();
        }
        private void LoadCategories()
        {
            using (myContext context = new myContext())
            {
                dgvCategories.DataSource = context.Categories.ToList();
                RemoveUnwantedColumns();
            }
        }
        private void RemoveUnwantedColumns()
        {
            dgvCategories.Columns["products"].Visible = false;

        }


        private void btnAddWh_Click(object sender, EventArgs e)
        {
            using (myContext context = new myContext())
            {
                var category = new Category
                {
                    CategoryName = txtCatName.Text,
                    CategoryDescription = txtDescrp.Text
                };
                context.Categories.Add(category);
                context.SaveChanges();
                MessageBox.Show("New Category Added!");
                LoadCategories();
            }
        }

        private void dgvCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtCatName.Text = dgvCategories.Rows[e.RowIndex].Cells["CategoryName"].Value.ToString();
                txtDescrp.Text = dgvCategories.Rows[e.RowIndex].Cells["CategoryDescription"].Value.ToString();
            }
        }
        private void btnUpdateWh_Click(object sender, EventArgs e)
        {
            if (dgvCategories.SelectedRows.Count > 0)
            {
                using (myContext context = new myContext())
                {
                    var category = context.Categories.Find(dgvCategories.SelectedRows[0].Cells["CategoryId"].Value);
                    category.CategoryName = txtCatName.Text;
                    category.CategoryDescription = txtDescrp.Text;
                    context.SaveChanges();
                    MessageBox.Show("Category Updated!");
                    LoadCategories();
                }
            }
        }

        private void btnDltWh_Click(object sender, EventArgs e)
        {
            if (dgvCategories.SelectedRows.Count > 0)
            {
                using (myContext context = new myContext())
                {
                    var category = context.Categories.Find(dgvCategories.SelectedRows[0].Cells["CategoryId"].Value);
                    context.Categories.Remove(category);
                    context.SaveChanges();
                    MessageBox.Show("Category Deleted!");
                    LoadCategories();
                }
            }
        }
    }

 }

