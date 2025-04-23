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
using InventoryManagementSystem.Services;
using Microsoft.EntityFrameworkCore;

namespace WinFormsApp1
{
    public partial class WarehouseReportControl : UserControl
    {
        myContext context = new myContext();

        public WarehouseReportControl()
        {

                
            
            InitializeComponent();
            cbWhId.DataSource = context.Warehouses.ToList();
            cbWhId.DisplayMember = "WarehouseName";// Show warehouse name
            cbWhId.ValueMember = "WarhouseId"; //Store warehouse ID
        }




        public List<string> GenerateWarehouseReport(myContext context, int warehouseID, DateTime? startdate = null, DateTime? enddate = null)
        {
            var reportLines = new List<string>();

            try
            {
                var warehouse = context.Warehouses
                    .Include(w => w.WhProducts) // eagerly loading
                    .Include(w => w.supplyPermission)
                    .Include(w => w.releasePermission)
                    .FirstOrDefault(w => w.WarhouseId == warehouseID);

                if (warehouse == null)
                {
                    reportLines.Add("Warehouse not found!");
                    return reportLines;
                }

                var supplyPermissions = warehouse.supplyPermission
                    .Where(sp => startdate == null || sp.supplyDate >= startdate)
                    .Where(sp => enddate == null || sp.supplyDate <= enddate)
                    .ToList();

                var releasePermissions = warehouse.releasePermission
                    .Where(rp => startdate == null || rp.ReleaseDate >= startdate)
                    .Where(rp => enddate == null || rp.ReleaseDate <= enddate)
                    .ToList();

                reportLines.Add($"Warehouse Report for {warehouse.WarehouseName} (ID: {warehouse.WarhouseId})");
                reportLines.Add($"Location: {warehouse.WarehouseLocation}");
                reportLines.Add("------");

                reportLines.Add("Supply Permissions:");
                foreach (var sp in supplyPermissions)
                {
                    reportLines.Add($"- Permission ID: {sp.SupplyId}, Date: {sp.supplyDate}, Supplier ID: {sp.supplierId}");
                }

                reportLines.Add("------");

                reportLines.Add("Release Permissions:");
                foreach (var rp in releasePermissions)
                {
                    reportLines.Add($"- Permission ID: {rp.ReleasePermissionId}, Date: {rp.ReleaseDate}, Customer: {rp.CustomerId}");
                }

                reportLines.Add("------");

                reportLines.Add("Current Stock:");
                foreach (var stock in warehouse.WhProducts)
                {
                    reportLines.Add($"- Product ID: {stock.ProductId}, Supplier ID: {stock.SupplierId}, Current Stock: {stock.CurrentStock}");
                }
            }
            catch (Exception ex)
            {
                reportLines.Add($"An error occurred: {ex.Message}");
            }

            return reportLines;
        }

        private void btngenerateWh_Click(object sender, EventArgs e)
        {
            if (cbWhId.SelectedValue == null || !int.TryParse(cbWhId.SelectedValue.ToString(), out int warehouseID))
            {
                MessageBox.Show("Please enter a valid Warehouse ID.");
                return;
            }

            DateTime? startDate = dtStartDate.Value;
            DateTime? endDate = dtEndDate.Value;

            // Fetch report data
            var reportLines = GenerateWarehouseReport(context, warehouseID, startDate, endDate);

            if (reportLines.Count == 0 || reportLines[0] == "Warehouse not found!")
            {
                MessageBox.Show("Warehouse not found!");
                return;
            }

            // Display data in a ListBox
            listBoxReport.Items.Clear();
            foreach (var line in reportLines)
            {
                listBoxReport.Items.Add(line);
            }

        }


    }
}
