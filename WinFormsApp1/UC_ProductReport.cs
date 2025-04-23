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
using Microsoft.EntityFrameworkCore;

namespace WinFormsApp1
{
    public partial class UC_ProductReport : UserControl
    {
        myContext context = new myContext();
        public UC_ProductReport()
        {
            InitializeComponent();
            cbPid.DataSource = context.Products.ToList();
            cbPid.DisplayMember = "ProductName";
            cbPid.ValueMember = "ProductsId";
        }

        private void btngenerateWh_Click(object sender, EventArgs e)
        {

        }












        public List<string> GenerateProductReport(myContext context, int productId, DateTime? startDate = null, DateTime? endDate = null, List<int> warehouseIds = null)
        {
            var reportLines = new List<string>();

            try
            {
                var product = context.Products
                    .Include(p => p.WhProducts) // eagerly loading
                    .Include(p => p.supplyPermProducts)
                    .Include(p => p.releasePermProducts)
                    .FirstOrDefault(p => p.ProductsId == productId);

                if (product == null)
                {
                    reportLines.Add("Product not found!");
                    return reportLines;
                }

                // Filter stock by warehouse (if provided)
                var stock = product.WhProducts
                    .Where(wps => warehouseIds == null || warehouseIds.Contains(wps.WarehouseId))
                    .ToList();

                // Filter supply and release permissions by date range (if provided)
                var supplyPerm = product.supplyPermProducts
                    .Where(spp => startDate == null || spp.supplyDate >= startDate)
                    .Where(spp => endDate == null || spp.supplyDate <= endDate)
                    .ToList();

                var releasePerm = product.releasePermProducts
                    .Where(rpp => startDate == null || rpp.ReleaseDate >= startDate)
                    .Where(rpp => endDate == null || rpp.ReleaseDate <= endDate)
                    .ToList();

                reportLines.Add($"Item Report for {product.ProductName} (ID: {product.ProductsId})");
                reportLines.Add($"Category ID: {product.CategoryId}, Price: {product.Price}");
                reportLines.Add("");

                reportLines.Add("Current Stock:");
                foreach (var s in stock)
                {
                    reportLines.Add($"- Warehouse ID: {s.WarehouseId}, Supplier ID: {s.SupplierId}, Current Stock: {s.CurrentStock}");
                }

                reportLines.Add("");
                reportLines.Add("Supply Permissions:");
                foreach (var spp in supplyPerm)
                {
                    reportLines.Add($"- Permission ID: {spp.SupplyPermissionId}, Quantity: {spp.Quantity}, Production Date: {spp.ProductionDate}");
                }

                reportLines.Add("");
                reportLines.Add("Release Permissions:");
                foreach (var rpp in releasePerm)
                {
                    reportLines.Add($"- Permission ID: {rpp.releasePermissionId}, Quantity: {rpp.quantity}, Production Date: {rpp.productionDate}");
                }
            }
            catch (Exception ex)
            {
                reportLines.Add($"An error occurred: {ex.Message}");
            }

            return reportLines;
        }





        private void btngeneratePR_Click(object sender, EventArgs e)
        {

            if (cbPid.SelectedValue == null || !int.TryParse(cbPid.SelectedValue.ToString(), out int productId))
            {
                MessageBox.Show("Please enter a valid Product ID.");
                return;
            }

            DateTime? startDate = dtStartDate.Value;
            DateTime? endDate = dtEndDate.Value;
            List<int> warehouseIds = null; //default

            var reportLines = GenerateProductReport(context, productId, startDate, endDate, warehouseIds);

            if (reportLines.Count == 0 || reportLines[0] == "Product not found!")
            {
                MessageBox.Show("Product not found!");
                return;
            }

            listBoxReport.Items.Clear();
            foreach (var line in reportLines)
            {
                listBoxReport.Items.Add(line);
            }

        }
    }
}
