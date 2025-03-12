using InventoryManagementSystem.context;
using InventoryManagementSystem.Entities;
using InventoryManagementSystem.Services;


namespace InventoryManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (myContext context = new myContext())
            {

                //Services.AddWarehouse(context);
                //Services.EditWarehouse(context);
                //CrudServices.AddSupplier(context);

                //var Supplier = context.Suppliers.ToList();
                //Console.WriteLine("  All Warehouses --> ");
                //foreach (var wh in Supplier)
                //{
                //    Console.WriteLine($"id: {wh.SupplierId}, name: {wh.SupplierName}");
                //}



                //PermissionsServices.AddSupplyPermission(context);
                //Console.WriteLine("***********");
                //var supplyPermissions = context.SupplyPermissions.ToList();
                //Console.WriteLine("All Supply Permissions --> ");
                //foreach (var sp in supplyPermissions)
                //{
                //    Console.WriteLine($"Supply ID: {sp.SupplyId}, Supply Date: {sp.supplyDate}, Warehouse ID: {sp.WarehouseId}, Supplier ID: {sp.supplierId}");
                //}
                //Console.WriteLine("***********");

                //var supplyPermProducts = context.SupplyPermProducts.ToList();
                //Console.WriteLine("All Supply Permission Products --> ");
                //foreach (var spp in supplyPermProducts)
                //{
                //    Console.WriteLine($"Supply Permission ID: {spp.SupplyPermissionId}, Product ID: {spp.ProductId}, Quantity: {spp.Quantity}, Expiry Duration: {spp.ExpiryDuration}, Production Date: {spp.ProductionDate}, supplyDate:{spp.supplyDate}");
                //}



                //PermissionsServices.AddReleasePermission(context);
                //Console.WriteLine("***********");
                //var ReleasePermission = context.ReleasePermissions.ToList();
                //Console.WriteLine("All Release Permissions --> ");
                //foreach (var sp in ReleasePermission)
                //{
                //    Console.WriteLine($"Release ID: {sp.ReleasePermissionId}, Release Date: {sp.ReleaseDate}, Warehouse ID: {sp.warehouseId}, Customer ID: {sp.CustomerId}");
                //}
                //Console.WriteLine("***********");

                //var ReleaesePermProducts = context.ReleasePermProducts.ToList();
                //Console.WriteLine("All Release Permission Products --> ");
                //foreach (var spp in ReleaesePermProducts)
                //{
                //    Console.WriteLine($"Supply Permission ID: {spp.releasePermissionId}, Product ID: {spp.productId}, Quantity: {spp.quantity}, Expiry date: {spp.ExpireDate}, Production Date: {spp.productionDate}, ReleaseDate:{spp.ReleaseDate}");
                //}






                while (true)
                {
                    Console.WriteLine("Choose an option:");

                    Console.WriteLine("1. Add Warehouse");
                    Console.WriteLine("2. Edit Warehouse");
                    Console.WriteLine("3. Delete Warehouse");

                    Console.WriteLine("4. Add Supplier");
                    Console.WriteLine("5. Edit Supplier");
                    Console.WriteLine("6. Delete Supplier");

                    Console.WriteLine("7. Add Product");
                    Console.WriteLine("8. Edit Product");
                    Console.WriteLine("9. Delete Product");

                    Console.WriteLine("10. Add Customer");
                    Console.WriteLine("11. Edit Customer");
                    Console.WriteLine("12. Delete Customer");

                    Console.WriteLine("13. Add Supply Permission");
                    Console.WriteLine("14. Edit Supply Permission");

                    Console.WriteLine("15. Add Release Permission");
                    Console.WriteLine("16. Edit Release Permission");

                    Console.WriteLine("17. Add Transfer Permission");

                    Console.WriteLine("18. Generate Warehouse Report");
                    Console.WriteLine("19. Generate Product Report");
                    Console.WriteLine("20. Generate Product Movement Report");
                    Console.WriteLine("21. Generate Expired Products Report");
                    Console.WriteLine("22. Generate Expiring Soon Report");

                    Console.WriteLine("0. Exit");
                    Console.Write("Enter your choice: ");
                    var choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            CrudServices.AddWarehouse(context);
                            break;
                        case "2":
                            CrudServices.EditWarehouse(context);
                            break;
                        case "3":
                            Console.Write("Enter Warehouse ID to delete: ");
                            int warehouseId = int.Parse(Console.ReadLine());
                            CrudServices.DeleteWarehouse(context, warehouseId);
                            break;
                        case "4":
                            CrudServices.AddSupplier(context);
                            break;
                        case "5":
                            CrudServices.EditSupplier(context);
                            break;
                        case "6":
                            Console.Write("Enter Supplier ID to delete: ");
                            int supplierId = int.Parse(Console.ReadLine());
                            CrudServices.DeleteSupplier(context, supplierId);
                            break;
                        case "7":
                            CrudServices.AddProduct(context);
                            break;
                        case "8":
                            CrudServices.EditProduct(context);
                            break;
                        case "9":
                            Console.Write("Enter Product ID to delete: ");
                            int productId = int.Parse(Console.ReadLine());
                            CrudServices.DeleteProduct(context, productId);
                            break;
                        case "10":
                            CrudServices.AddCustomer(context);
                            break;
                        case "11":
                            CrudServices.EditCustomer(context);
                            break;
                        case "12":
                            Console.Write("Enter Customer ID to delete: ");
                            int customerId = int.Parse(Console.ReadLine());
                            CrudServices.DeleteCustomer(context, customerId);
                            break;
                        case "13":
                            PermissionsServices.AddSupplyPermission(context);
                            break;
                        case "14":
                            PermissionsServices.UpdateSupplyPermission(context);
                            break;
                        case "15":
                            PermissionsServices.AddReleasePermission(context);
                            break;
                        case "16":
                            PermissionsServices.EditReleasePermission(context);
                            break;
                        case "17":
                            PermissionsServices.AddTransferPermission(context);
                            break;

                        case "18":
                            Console.Write("Enter Warehouse ID for report: ");
                            int reportWarehouseId = int.Parse(Console.ReadLine());

                            Console.Write("Enter start date (yyyy-mm-dd) or press Enter to skip: ");
                            string startDateInput = Console.ReadLine();
                            DateTime? startDate = string.IsNullOrEmpty(startDateInput) ? (DateTime?)null : DateTime.Parse(startDateInput);

                            Console.Write("Enter end date (yyyy-mm-dd) or press Enter to skip: ");
                            string endDateInput = Console.ReadLine();
                            DateTime? endDate = string.IsNullOrEmpty(endDateInput) ? (DateTime?)null : DateTime.Parse(endDateInput);

                            ReportServices.GenerateWarehouseReport(context, reportWarehouseId, startDate, endDate);
                            break;

                        case "19":
                            Console.Write("Enter Product ID for report: ");
                            int reportProductId = int.Parse(Console.ReadLine());

                            Console.Write("Enter start date (yyyy-mm-dd) or press Enter to skip: ");
                            startDateInput = Console.ReadLine();
                            startDate = string.IsNullOrEmpty(startDateInput) ? (DateTime?)null : DateTime.Parse(startDateInput);

                            Console.Write("Enter end date (yyyy-mm-dd) or press Enter to skip: ");
                            endDateInput = Console.ReadLine();
                            endDate = string.IsNullOrEmpty(endDateInput) ? (DateTime?)null : DateTime.Parse(endDateInput);

                            Console.Write("Enter Warehouse IDs (comma-separated) or press Enter to skip: ");
                            string warehouseIdsInput = Console.ReadLine();
                            List<int> warehouseIds = string.IsNullOrEmpty(warehouseIdsInput) ? null : warehouseIdsInput.Split(',').Select(int.Parse).ToList();

                            ReportServices.GenerateProductReport(context, reportProductId, startDate, endDate, warehouseIds);
                            break;

                        case "20":
                            Console.Write("Enter start date (yyyy-mm-dd): ");
                            DateTime startDateinput = DateTime.Parse(Console.ReadLine());
                            Console.Write("Enter end date (yyyy-mm-dd): ");
                            DateTime endDateinput = DateTime.Parse(Console.ReadLine());
                            Console.Write("Enter Warehouse IDs (comma-separated) or press Enter to skip: ");
                            warehouseIdsInput = Console.ReadLine();
                            warehouseIds = string.IsNullOrEmpty(warehouseIdsInput) ? null : warehouseIdsInput.Split(',').Select(int.Parse).ToList();
                            ReportServices.GenerateProductMovementReport(context, startDateinput, endDateinput, warehouseIds);
                            break;
                        case "21":
                            Console.Write("Enter number of days in storage to consider as expired: ");
                            int daysInStorage = int.Parse(Console.ReadLine());
                            ReportServices.GenerateExpiredProductsReport(context, daysInStorage);
                            break;
                        case "22":
                            Console.Write("Enter number of days remaining shelf life to consider as expiring soon: ");
                            int remainingShelfLifeDays = int.Parse(Console.ReadLine());
                            ReportServices.GenerateExpiringSoonReport(context, remainingShelfLifeDays);
                            break;

                        case "0":
                            return;

                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }

            }
        }
    }
}
