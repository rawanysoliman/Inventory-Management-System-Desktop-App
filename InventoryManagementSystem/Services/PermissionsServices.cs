using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManagementSystem.context;
using InventoryManagementSystem.Entities;
using InventoryManagementSystem.Migrations;
using Microsoft.Identity.Client;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagementSystem
{
    public class PermissionsServices
    {
        //add supply permission

        public static void AddSupplyPermission(myContext context)
        {
            try
            {

                // add to supply perm.
                Console.WriteLine("Enter Warehouse ID:");
                int whId = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Supplier ID:");
                int spId = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Supply Date (yyyy-mm-dd):");
                DateTime splyDate = DateTime.Parse(Console.ReadLine());

                var splyPerm = new SupplyPermission
                {
                    supplyDate = splyDate,
                    WarehouseId = whId,
                    supplierId = spId
                };
                context.SupplyPermissions.Add(splyPerm);
                context.SaveChanges();

                Console.WriteLine("Supply Permission added successfully!");


                // add to supply-perm-products table (Q, exp prod dates)

                Console.WriteLine("Enter How Many Products Types");
                int productsCount = int.Parse(Console.ReadLine());

                for (int i = 0; i < productsCount; i++)
                {
                    Console.WriteLine("Enter Product ID:");
                    int productId = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Enter Quantity of Product{i}");
                    int quantity = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Expiry Duration:");
                    int expireDuration = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Production Date:");
                    DateTime prdctDate = DateTime.Parse(Console.ReadLine());

                    var splyPerPrdcts = new SupplyPermProducts
                    {
                        SupplyPermissionId = splyPerm.SupplyId,
                        ProductId = productId,
                        ExpiryDuration = expireDuration,
                        ProductionDate = prdctDate,
                        Quantity = quantity,
                        supplyDate = splyDate,
                    };

                    context.SupplyPermProducts.Add(splyPerPrdcts);


                    // update warehouse products table & stock
                    var ProductStock = context.WhProductsBySuppliers
                    .FirstOrDefault(ps => ps.WarehouseId == whId && ps.ProductId == productId && ps.SupplierId == spId);

                    if (ProductStock != null)//existing stock so just increment
                    {
                        ProductStock.CurrentStock += quantity;
                        ProductStock.ExpireDate = ProductStock.ProductionDate.AddDays(splyPerPrdcts.ExpiryDuration); // update expiry date
                        ProductStock.ProductionDate = splyPerPrdcts.ProductionDate;
                        ProductStock.supplyDate = splyPerPrdcts.supplyDate;
                    }
                    else
                    {
                        // add new stock record
                        var newStock = new WhProductsBySupplier
                        {
                            WarehouseId = whId,
                            ProductId = productId,
                            SupplierId = spId,
                            CurrentStock = quantity,
                            ExpireDate = prdctDate.AddDays(expireDuration),
                            ProductionDate = prdctDate
                        };
                        context.WhProductsBySuppliers.Add(newStock);

                    }


                    context.SaveChanges();
                    Console.WriteLine("Products added to Supply Permission and stock updated successfully!");

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }






        //edit supply permission
        public static void UpdateSupplyPermission(myContext context)
        {
            try
            {
                Console.WriteLine("Enter Supply Permission ID to edit:");
                int spId = int.Parse(Console.ReadLine());

                var supplyPerm = context.SupplyPermissions
                    .Include(sp => sp.supplyPermProducts) // Include junction table to access products
                    .FirstOrDefault(sp => sp.SupplyId == spId); // Match ID

                if (supplyPerm == null)
                {
                    Console.WriteLine("Supply Permission not found!");
                    return;
                }

                // Update General Information
                Console.WriteLine("Enter new Warehouse ID (or press Enter to keep current value):");
                string newWhIdInput = Console.ReadLine();
                if (!string.IsNullOrEmpty(newWhIdInput))
                {
                    int newWHId = int.Parse(newWhIdInput);
                    var warehouse = context.Warehouses.Find(newWHId);
                    if (warehouse == null)
                    {
                        Console.WriteLine("Invalid Warehouse ID. Warehouse not found.");
                        return;
                    }
                    supplyPerm.WarehouseId = newWHId;
                }

                Console.WriteLine("Enter new Supplier ID (or press Enter to keep current value):");
                string supplierIdInput = Console.ReadLine();
                if (!string.IsNullOrEmpty(supplierIdInput))
                {
                    int newSupplierId = int.Parse(supplierIdInput);
                    var supplier = context.Suppliers.Find(newSupplierId);
                    if (supplier == null)
                    {
                        Console.WriteLine("Invalid Supplier ID. Supplier not found.");
                        return;
                    }
                    supplyPerm.supplierId = newSupplierId;
                }

                Console.WriteLine("Enter new Supply Date (yyyy-mm-dd) (or press Enter to keep current value):");
                string supplyDateInput = Console.ReadLine();
                if (!string.IsNullOrEmpty(supplyDateInput))
                {
                    supplyPerm.supplyDate = DateTime.Parse(supplyDateInput);
                }

                // Update Products
                Console.WriteLine("Do you want to update products? (yes/no)");
                string updateProducts = Console.ReadLine().ToLower();

                if (updateProducts == "yes")
                {
                    foreach (var product in supplyPerm.supplyPermProducts.ToList())
                    {
                        Console.WriteLine($"Product ID: {product.ProductId}, Current Quantity: {product.Quantity}");
                        Console.WriteLine("Enter new Product ID (or press Enter to keep current value):");
                        string productIdInput = Console.ReadLine();
                        if (!string.IsNullOrEmpty(productIdInput))
                        {
                            int newProductId = int.Parse(productIdInput);
                            var newProduct = context.Products.Find(newProductId);
                            if (newProduct == null)
                            {
                                Console.WriteLine("Invalid Product ID. Product not found.");
                                continue; // Skip this product
                            }
                            product.ProductId = newProductId;
                        }

                        Console.WriteLine("Enter new Quantity (or press Enter to keep current value):");
                        string quantityInput = Console.ReadLine();
                        if (!string.IsNullOrEmpty(quantityInput))
                        {
                            int newQuantity = int.Parse(quantityInput);
                            int oldQuantity = product.Quantity;

                            // Adjust stock based on the difference
                            var productStock = context.WhProductsBySuppliers
                                .FirstOrDefault(ps => ps.WarehouseId == supplyPerm.WarehouseId && ps.ProductId == product.ProductId);

                            if (productStock != null)
                            {
                                if (newQuantity > oldQuantity)
                                {
                                    // Increment stock
                                    int difference = newQuantity - oldQuantity;
                                    productStock.CurrentStock += difference;
                                }
                                else if (newQuantity < oldQuantity)
                                {
                                    // Decrement stock
                                    int difference = oldQuantity - newQuantity;
                                    if (productStock.CurrentStock >= difference)
                                    {
                                        productStock.CurrentStock -= difference;
                                    }
                                    else
                                    {
                                        Console.WriteLine($"Insufficient stock for Product ID {product.ProductId}. Current stock: {productStock.CurrentStock}, Requested reduction: {difference}");
                                        continue; // Skip this product
                                    }
                                }

                                // Update the product quantity
                                product.Quantity = newQuantity;
                            }
                            else
                            {
                                Console.WriteLine($"Product ID {product.ProductId} not found in Warehouse ID {supplyPerm.WarehouseId}.");
                                continue; // Skip this product
                            }
                        }

                        Console.WriteLine("Enter new Expiry Duration (or press Enter to keep current value):");
                        string expiryDurationInput = Console.ReadLine();
                        if (!string.IsNullOrEmpty(expiryDurationInput))
                        {
                            product.ExpiryDuration = int.Parse(expiryDurationInput);
                        }

                        Console.WriteLine("Enter new Production Date (yyyy-mm-dd) (or press Enter to keep current value):");
                        string productionDateInput = Console.ReadLine();
                        if (!string.IsNullOrEmpty(productionDateInput))
                        {
                            product.ProductionDate = DateTime.Parse(productionDateInput);
                        }
                    }
                }

                context.SaveChanges();
                Console.WriteLine("Supply Permission updated successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }




        //add release permission
        public static void AddReleasePermission(myContext context)
        {
            try
            {
                Console.WriteLine("Enter Warehouse ID FRom Where Product Is Released:");
                int whId = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Customer ID If Found or 1 If None:");
                int custId = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Release Date (yyyy-mm-dd):");
                DateTime releaseDate = DateTime.Parse(Console.ReadLine());

                var releasePermission = new ReleasePermission
                {
                    warehouseId = whId,
                    CustomerId = custId,
                    ReleaseDate = releaseDate
                };

                context.ReleasePermissions.Add(releasePermission);
                context.SaveChanges();

                Console.WriteLine("Release Permission added successfully!");

                // add  to ReleasePermProducts
                Console.WriteLine("How many products are being released?");
                int productCount = int.Parse(Console.ReadLine());

                for (int i = 0; i < productCount; i++)
                {
                    Console.WriteLine($"Enter Product ID no{i + 1}:");
                    int productId = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Enter Quantity of product {i + 1}:");
                    int quantity = int.Parse(Console.ReadLine());



                    // Update Current Stock

                    var productStock = context.WhProductsBySuppliers
                                     .FirstOrDefault(ps => ps.WarehouseId == whId && ps.ProductId == productId);

                    if (productStock != null)
                    {
                        if (productStock.CurrentStock >= quantity)
                        {

                            var rlsPerm = new ReleasePermProducts
                            {
                                releasePermissionId = releasePermission.ReleasePermissionId,
                                productId = productId,
                                quantity = quantity,
                                ReleaseDate = releaseDate,
                                ExpireDate = productStock.ExpireDate,
                                productionDate = productStock.ProductionDate
                            };

                            context.ReleasePermProducts.Add(rlsPerm);

                            productStock.CurrentStock -= quantity;
                        }
                        else
                        {
                            Console.WriteLine($"Insufficient stock for Product ID {productId}. Current stock: {productStock.CurrentStock}, Requested quantity: {quantity}");
                            continue; // Skip this product
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Product ID {productId} not found in Warehouse ID {whId}.");
                        continue; // Skip this product
                    }
                }

                context.SaveChanges();
                Console.WriteLine("Products added to Release Permission and stock updated successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }



        //edit release permission
        public static void EditReleasePermission(myContext context)
        {
            try
            {
                Console.WriteLine("Enter Release Permission ID to edit:");
                int rpId = int.Parse(Console.ReadLine());

                var releasePerm = context.ReleasePermissions
                    .Include(rp => rp.releasePermProducts) // Include junction table to access products
                    .FirstOrDefault(rp => rp.ReleasePermissionId == rpId); // Match ID

                if (releasePerm == null)
                {
                    Console.WriteLine("Release Permission not found!");
                    return;
                }

                // Update General Information
                Console.WriteLine("Enter new Warehouse ID (or press Enter to keep current value):");
                string newWhIdInput = Console.ReadLine();
                if (!string.IsNullOrEmpty(newWhIdInput))
                {
                    int newWHId = int.Parse(newWhIdInput);
                    var warehouse = context.Warehouses.Find(newWHId);
                    if (warehouse == null)
                    {
                        Console.WriteLine("Invalid Warehouse ID. Warehouse not found.");
                        return;
                    }
                    releasePerm.warehouseId = newWHId;
                }

                Console.WriteLine("Enter new Customer ID (or press Enter to keep current value):");
                string customerIdInput = Console.ReadLine();
                if (!string.IsNullOrEmpty(customerIdInput))
                {
                    int newCustomerId = int.Parse(customerIdInput);
                    var customer = context.Customers.Find(newCustomerId);
                    if (customer == null)
                    {
                        Console.WriteLine("Invalid Customer ID. Customer not found.");
                        return;
                    }
                    releasePerm.CustomerId = newCustomerId;
                }

                Console.WriteLine("Enter new Release Date (yyyy-mm-dd) (or press Enter to keep current value):");
                string releaseDateInput = Console.ReadLine();
                if (!string.IsNullOrEmpty(releaseDateInput))
                {
                    releasePerm.ReleaseDate = DateTime.Parse(releaseDateInput);
                }

                // Update Products
                Console.WriteLine("Do you want to update products? (yes/no)");
                string updateProducts = Console.ReadLine().ToLower();

                if (updateProducts == "yes")
                {
                    foreach (var product in releasePerm.releasePermProducts.ToList())
                    {
                        Console.WriteLine($"Product ID: {product.productId}, Current Quantity: {product.quantity}");
                        Console.WriteLine("Enter new Product ID (or press Enter to keep current value):");
                        string productIdInput = Console.ReadLine();
                        if (!string.IsNullOrEmpty(productIdInput))
                        {
                            int newProductId = int.Parse(productIdInput);
                            var newProduct = context.Products.Find(newProductId);
                            if (newProduct == null)
                            {
                                Console.WriteLine("Invalid Product ID. Product not found.");
                                continue; // Skip this product
                            }
                            product.productId = newProductId;
                        }

                        Console.WriteLine("Enter new Quantity (or press Enter to keep current value):");
                        string quantityInput = Console.ReadLine();
                        if (!string.IsNullOrEmpty(quantityInput))
                        {
                            int newQuantity = int.Parse(quantityInput);
                            int oldQuantity = product.quantity;

                            // Adjust stock based on the difference
                            var productStock = context.WhProductsBySuppliers
                                .FirstOrDefault(ps => ps.WarehouseId == releasePerm.warehouseId && ps.ProductId == product.productId);

                            if (productStock != null)
                            {
                                if (newQuantity > oldQuantity)
                                {
                                    // Decrement stock further
                                    int difference = newQuantity - oldQuantity;
                                    if (productStock.CurrentStock >= difference)
                                    {
                                        productStock.CurrentStock -= difference;
                                    }
                                    else
                                    {
                                        Console.WriteLine($"Insufficient stock for Product ID {product.productId}. Current stock: {productStock.CurrentStock}, Requested additional quantity: {difference}");
                                        continue; // Skip this product
                                    }
                                }
                                else if (newQuantity < oldQuantity)
                                {
                                    // Increment stock back
                                    int difference = oldQuantity - newQuantity;
                                    productStock.CurrentStock += difference;
                                }

                                // Update the product quantity
                                product.quantity = newQuantity;
                            }
                            else
                            {
                                Console.WriteLine($"Product ID {product.productId} not found in Warehouse ID {releasePerm.warehouseId}.");
                                continue; // Skip this product
                            }
                        }
                    }
                }

                context.SaveChanges();
                Console.WriteLine("Release Permission updated successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }



        //transfer product

        public static void AddTransferPermission(myContext context)
        {
            try
            {
                Console.WriteLine("Enter Source Warehouse ID:");
                int sourceWhId = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Destination Warehouse ID");
                int destWhId = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Transfer Date (yyyy-mm-dd):");
                DateTime transferDate = DateTime.Parse(Console.ReadLine());

                var transferPerm = new TransferPermission
                {
                    sourceWarehouseId = sourceWhId,
                    destWarehouseId = destWhId,
                    TransferDate = transferDate
                };
                context.TransferPermissions.Add(transferPerm);
                context.SaveChanges();
                Console.WriteLine("Transfer Permission added successfully!");

                Console.WriteLine("How many products are being transferred?");
                int numOfProducts = int.Parse(Console.ReadLine());

                for (int i = 0; i < numOfProducts; i++)
                {
                    Console.WriteLine($"Enter details for Product {i + 1}:");
                    Console.WriteLine("Enter Product ID:");
                    int productId = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Supplier ID:");
                    int supplierId = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Quantity:");
                    int Quantity = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Production Date (yyyy-mm-dd):");
                    DateTime productionDate = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Expiry Date (yyyy-mm-dd):");
                    DateTime expiryDate = DateTime.Parse(Console.ReadLine());

                    var transferPermProducts = new TransferProductsBySuppliers
                    {
                        transferPermissionId = transferPerm.TransferId,
                        productID = productId,
                        supplierId = supplierId,
                        Quantity = Quantity,
                        ProductionDate = productionDate,
                        ExpireDate = expiryDate
                    };
                    context.TransferProductsBySuppliers.Add(transferPermProducts);

                    //update source whproductsbysuppliers 
                    var sourceProductStock = context.WhProductsBySuppliers
                        .FirstOrDefault(ps => ps.WarehouseId == sourceWhId && ps.ProductId == productId && ps.SupplierId == supplierId);

                    if (sourceProductStock != null)
                    {
                        if (sourceProductStock.CurrentStock >= Quantity)
                        {
                            // Decrement stock in the source warehouse
                            sourceProductStock.CurrentStock -= Quantity;
                        }
                        else
                        {
                            Console.WriteLine($"Insufficient stock in Source Warehouse for Product ID {productId}. Current stock: {sourceProductStock.CurrentStock}, Requested quantity: {Quantity}");
                            continue;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Product ID {productId} not found in Source Warehouse ID {sourceWhId}.");
                        continue;
                    }



                    //update dest wh in whproductsbysuppliers
                    var destProductStock = context.WhProductsBySuppliers
                        .FirstOrDefault(ps => ps.WarehouseId == destWhId && ps.ProductId == productId && ps.SupplierId == supplierId);

                    if (destProductStock != null)
                    {
                        // Increment 
                        destProductStock.CurrentStock += Quantity;
                        destProductStock.ProductionDate = productionDate;
                        destProductStock.ExpireDate = expiryDate;
                    }
                    else
                    {
                        // Add new recordd
                        var newStock = new WhProductsBySupplier
                        {
                            WarehouseId = destWhId,
                            ProductId = productId,
                            SupplierId = supplierId,
                            CurrentStock = numOfProducts,
                            ExpireDate = expiryDate,
                            ProductionDate = productionDate
                        };


                        context.WhProductsBySuppliers.Add(newStock);
                    }
                }
                context.SaveChanges();
                Console.WriteLine("Products added to Transfer Permission and stock updated successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }


        }
    }
}


