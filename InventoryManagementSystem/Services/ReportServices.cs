using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManagementSystem.context;
using InventoryManagementSystem.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace InventoryManagementSystem.Services
{
    public class ReportServices
    {
        //Generates a report for a specific warehouse, optionally filtered by a time period.
        public static void GenerateWarehouseReport(myContext context, int warehouseID, DateTime? startdate = null, DateTime? enddate = null)
        {
            try
            {
                var warehouse = context.Warehouses
                    .Include(w => w.WhProducts) // eagerly loading
                    .Include(w => w.supplyPermission)
                    .Include(w => w.releasePermission)
                    .FirstOrDefault(w => w.WarhouseId == warehouseID);

                if (warehouse == null)
                {
                    Console.WriteLine("Warehouse not found!");
                    return;
                }


                var supplyPermissions = warehouse.supplyPermission
                    .Where(sp => startdate == null || sp.supplyDate >= startdate)
                    .Where(sp => enddate == null || sp.supplyDate <= enddate)
                    .ToList();

                var releasePermissions = warehouse.releasePermission
                    .Where(rp => startdate == null || rp.ReleaseDate >= startdate)
                    .Where(rp => enddate == null || rp.ReleaseDate <= enddate)
                    .ToList();

                Console.WriteLine($"Warehouse Report for {warehouse.WarehouseName} (ID: {warehouse.WarhouseId})");
                Console.WriteLine($"Location: {warehouse.WarehouseLocation}");
                Console.WriteLine("------");

                Console.WriteLine("Supply Permissions:");
                foreach (var sp in supplyPermissions)
                {
                    Console.WriteLine($"- Permission ID: {sp.SupplyId}, Date: {sp.supplyDate}, Supplier ID: {sp.supplierId}");
                }

                Console.WriteLine("------"); 

                Console.WriteLine("Release Permissions:");
                foreach (var rp in releasePermissions)
                {
                    Console.WriteLine($"- Permission ID: {rp.ReleasePermissionId}, Date: {rp.ReleaseDate}, Customer: {rp.CustomerId}");
                }

                Console.WriteLine("------");

                Console.WriteLine("Current Stock:");
                foreach (var stock in warehouse.WhProducts)
                {
                    Console.WriteLine($"- Product ID: {stock.ProductId}, Supplier ID: {stock.SupplierId}, Current Stock: {stock.CurrentStock}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

        }



        //Generates a report for a specific item, optionally filtered by a time period and one or more warehouses.

        public static void GenerateProductReport(myContext context, int productId, DateTime? startDate = null, DateTime? endDate = null, List<int> warehouseIds = null)
        {
            try
            {

                var product = context.Products
                    .Include(p => p.WhProducts) // eagerly loading
                    .Include(p => p.supplyPermProducts)
                    .Include(p => p.releasePermProducts)
                    .FirstOrDefault(p => p.ProductsId == productId);

                if (product == null)
                {
                    Console.WriteLine("Product not found!");
                    return;
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

                Console.WriteLine($"Item Report for {product.ProductName} (ID: {product.ProductsId})");
                Console.WriteLine($"Category ID: {product.CategoryId}, Price: {product.Price}");
                Console.WriteLine();

                Console.WriteLine("Current Stock:");
                foreach (var s in stock)
                {
                    Console.WriteLine($"- Warehouse ID: {s.WarehouseId}, Supplier ID: {s.SupplierId}, Current Stock: {s.CurrentStock}");
                }

                Console.WriteLine();

                Console.WriteLine("Supply Permissions:");
                foreach (var spp in supplyPerm)
                {
                    Console.WriteLine($"- Permission ID: {spp.SupplyPermissionId}, Quantity: {spp.Quantity}, Production Date: {spp.ProductionDate}");
                }

                Console.WriteLine();

                Console.WriteLine("Release Permissions:");
                foreach (var rpp in releasePerm)
                {
                    Console.WriteLine($"- Permission ID: {rpp.releasePermissionId}, Quantity: {rpp.quantity}, Production Date: {rpp.productionDate}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }



        // Item Movement Report
        public static void GenerateProductMovementReport(myContext context, DateTime startDate, DateTime endDate, List<int> warehouseIds = null)
        {
            try
            {
                // Query supply and release permissions within the date range
                var supplyPermissions = context.SupplyPermissions
                    .Include(sp => sp.supplyPermProducts)
                    .Where(sp => sp.supplyDate >= startDate && sp.supplyDate <= endDate)
                    .Where(sp => warehouseIds == null || warehouseIds.Contains(sp.WarehouseId))
                    .ToList();

                var releasePermissions = context.ReleasePermissions
                    .Include(rp => rp.releasePermProducts)
                    .Where(rp => rp.ReleaseDate >= startDate && rp.ReleaseDate <= endDate)
                    .Where(rp => warehouseIds == null || warehouseIds.Contains(rp.warehouseId))
                    .ToList();

                // Query transfer permissions within the date range
                var transferPermissions = context.TransferPermissions
                    .Include(tp => tp.transferedItemDetails)
                    .Where(tp => tp.TransferDate >= startDate && tp.TransferDate <= endDate)
                    .Where(tp => warehouseIds == null || warehouseIds.Contains(tp.sourceWarehouseId) || warehouseIds.Contains(tp.destWarehouseId))
                    .ToList();

                // Display report
                Console.WriteLine($"Item Movement Report from {startDate.ToShortDateString()} to {endDate.ToShortDateString()}");
                Console.WriteLine();

                Console.WriteLine("Supply Movements:");
                foreach (var sp in supplyPermissions)
                {
                    Console.WriteLine($"- Permission ID: {sp.SupplyId}, Warehouse ID: {sp.WarehouseId}, Date: {sp.supplyDate}");

                    foreach (var spp in sp.supplyPermProducts)
                    {
                        Console.WriteLine($"  - Product ID: {spp.ProductId}, Quantity: {spp.Quantity}");
                    }
                }

                Console.WriteLine();

                Console.WriteLine("Release Movements:");
                foreach (var rp in releasePermissions)
                {
                    Console.WriteLine($"- Permission ID: {rp.ReleasePermissionId}, Warehouse ID: {rp.warehouseId}, Date: {rp.ReleaseDate}");
                    foreach (var rpp in rp.releasePermProducts)
                    {
                        Console.WriteLine($"  - Product ID: {rpp.productId}, Quantity: {rpp.quantity}");
                    }
                }
                Console.WriteLine();

                Console.WriteLine("Transfer Movements:");
                foreach (var tp in transferPermissions)
                {
                    Console.WriteLine($"- Transfer ID: {tp.TransferId}, Source Warehouse ID: {tp.sourceWarehouseId}, Destination Warehouse ID: {tp.destWarehouseId}, Date: {tp.TransferDate}");
                    foreach (var tps in tp.transferedItemDetails)
                    {
                        Console.WriteLine($"  - Product ID: {tps.productID}, Quantity: {tps.Quantity}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        //Expired Items Report
        public static void GenerateExpiredProductsReport(myContext context, int daysInStorage)
        {
            try
            {
                // Calculate the threshold date
                DateTime thresholdDate = DateTime.Now.AddDays(-daysInStorage);

                // Query expired items
                var expiredItems = context.WhProductsBySuppliers
                    .Where(wps => wps.ProductionDate <= thresholdDate)
                    .ToList();

                // Display report
                Console.WriteLine($"Expired Items Report (Items in storage for more than {daysInStorage} days):");
                foreach (var item in expiredItems)
                {
                    Console.WriteLine($"- Product ID: {item.ProductId}, Warehouse ID: {item.WarehouseId}, Supplier ID: {item.SupplierId}, Production Date: {item.ProductionDate}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }


        // Expiring Soon Report
        public static void GenerateExpiringSoonReport(myContext context, int remainingShelfLifeDays)
        {
            try
            {
                // Calculate the threshold date
                DateTime thresholdDate = DateTime.Now.AddDays(remainingShelfLifeDays);

                // Query expiring items
                var expiringItems = context.WhProductsBySuppliers
                    .Where(wps => wps.ExpireDate <= thresholdDate)
                    .ToList();

                // Display report
                Console.WriteLine($"Expiring Soon Report (Items expiring within {remainingShelfLifeDays} days):");
                foreach (var item in expiringItems)
                {
                    Console.WriteLine($"- Product ID: {item.ProductId}, Warehouse ID: {item.WarehouseId}, Supplier ID: {item.SupplierId}, Expire Date: {item.ExpireDate}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
