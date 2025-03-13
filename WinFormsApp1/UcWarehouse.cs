using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using InventoryManagementSystem.context;
using InventoryManagementSystem.Entities;

namespace WinFormsApp1
{
    public partial class UcWarehouse : UserControl
    {
        public UcWarehouse()
        {
            InitializeComponent();
            LoadWarehouses();
        }
        private void LoadWarehouses()
        {
            using (myContext context = new myContext())
            {
                dgvWarehouse.DataSource = context.Warehouses.ToList();
                RemoveUnwantedColumns();


            }
        }


        private void RemoveUnwantedColumns()
        {
            // Remove columns by name
            dgvWarehouse.Columns["transferSource"].Visible = false;
            dgvWarehouse.Columns["transferDestination"].Visible = false;
            dgvWarehouse.Columns["supplyPermission"].Visible = false;
            dgvWarehouse.Columns["releasePermission"].Visible = false;
            dgvWarehouse.Columns["WhProducts"].Visible = false;
        }

        private void btnAddWh_Click(object sender, EventArgs e)
        {
            using (myContext context = new myContext())
            {
                var warehouse = new Warehouse
                {
                    WarehouseName = txtWhName.Text,
                    WarehouseLocation = txtWhLoc.Text,
                    WarehouseManager = txtManger.Text
                };
                context.Warehouses.Add(warehouse);
                context.SaveChanges();
                MessageBox.Show("New Warehouse Added!");
                LoadWarehouses();
            }
        }



        //load details in txtbox 1st
        private void dgvWarehouse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtWhName.Text = dgvWarehouse.Rows[e.RowIndex].Cells["WarehouseName"].Value.ToString();
                txtWhLoc.Text = dgvWarehouse.Rows[e.RowIndex].Cells["WarehouseLocation"].Value.ToString();
                txtManger.Text = dgvWarehouse.Rows[e.RowIndex].Cells["WarehouseManager"].Value.ToString();

            }
        }

        //update
        private void btnUpdateWh_Click(object sender, EventArgs e)
        {
            if (dgvWarehouse.SelectedRows.Count > 0)
            {
                using (myContext context = new myContext())
                {
                    var warehouse = context.Warehouses.Find(dgvWarehouse.SelectedRows[0].Cells["WarhouseId"].Value);
                    warehouse.WarehouseName = txtWhName.Text;
                    warehouse.WarehouseLocation = txtWhLoc.Text;
                    warehouse.WarehouseManager = txtManger.Text;
                    context.SaveChanges();
                    MessageBox.Show("Warehouse Updated!");
                    LoadWarehouses();
                }
            }
        }

        private void btnDltWh_Click(object sender, EventArgs e)
        {
            if (dgvWarehouse.SelectedRows.Count > 0)
            {
                using (myContext context = new myContext())
                {
                    var warehouse = context.Warehouses.Find(dgvWarehouse.SelectedRows[0].Cells["WarhouseId"].Value);
                    context.Warehouses.Remove(warehouse);
                    context.SaveChanges();
                    MessageBox.Show("Warehouse Deleted!");
                    LoadWarehouses();
                }
            }

        }

        private void UcWarehouse_Resize(object sender, EventArgs e)
        {
            this.Invalidate();

        }

        private void txtWhName_Enter(object sender, EventArgs e)
        {
            txtWhName.RT_TB.Text = string.Empty;

        }

        private void txtWhLoc_Enter(object sender, EventArgs e)
        {
            txtWhLoc.RT_TB.Text = string.Empty;
        }

        private void txtManger_Enter(object sender, EventArgs e)
        {
            txtManger.RT_TB.Text = string.Empty;
        }
    }
}
