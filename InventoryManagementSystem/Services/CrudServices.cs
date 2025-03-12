using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManagementSystem.context;
using InventoryManagementSystem.Entities;
using InventoryManagementSystem.Migrations;
using Microsoft.Identity.Client;
using InventoryManagementSystem.Entities;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagementSystem
{


    //add/edit warehouse
    public class CrudServices
    {
        public static void AddWarehouse(myContext context)
        {
           Console.WriteLine("Enter Warehouse Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Warehouse Location:");
            string location = Console.ReadLine();
            Console.WriteLine("Enter Warhouse Manager:");
            string manager = Console.ReadLine();

            Warehouse warehouse = new Warehouse()
            {
                WarehouseName = name,
                WarehouseLocation = location,
                WarehouseManager = manager
            };
            context.Warehouses.Add(warehouse);
            context.SaveChanges();
            Console.WriteLine("Warehouse added successfully");
        }


        public static void EditWarehouse(myContext context)
        {

            Console.WriteLine("Enter Warehouse Id:");
            int id = int.Parse(Console.ReadLine());
            Warehouse wh = context.Warehouses.Find(id);
            if (wh != null)
            {
                Console.WriteLine("Enter Warehouse Name:");
                wh.WarehouseName = Console.ReadLine();
                Console.WriteLine("Enter Warehouse Location:");
                wh.WarehouseLocation = Console.ReadLine();
                Console.WriteLine("Enter Warhouse Manager:");
                wh.WarehouseManager = Console.ReadLine();

                context.SaveChanges();
                Console.WriteLine("Warehouse updated successfully");
            }
            else
            {
                Console.WriteLine("Warehouse not found");
            }
        }



        //add/edit supplier
        public static void AddSupplier(myContext context)
            {
              Console.WriteLine("Enter Supplier Name:");
              string name = Console.ReadLine();
              Console.WriteLine("Enter Supplier Address:");
              string address = Console.ReadLine();
              Console.WriteLine("Enter Supplier Phone:");
              string phone = Console.ReadLine();
              Console.WriteLine("Enter Supplier Email:");
              string email = Console.ReadLine();
              Console.WriteLine("Enter Supplier Fax:");
              string fax = Console.ReadLine();

              Supplier supplier = new Supplier()
              {
                SupplierName = name,
                SupplierLocation = address,
                PhoneNumber = phone,
                Email = email,
                faxNumber = fax
              };
 
              context.Suppliers.Add(supplier);
              context.SaveChanges();
              Console.WriteLine("Supplier added successfully");
            }

        public static void EditSupplier(myContext context)
        {
            Console.WriteLine("Enter Supplier ID to edit:");
            int id = int.Parse(Console.ReadLine());
            Supplier supplier = context.Suppliers.Find(id);

            if (supplier != null)
            {
                Console.WriteLine("Enter new Supplier Name:");
                supplier.SupplierName = Console.ReadLine();
                Console.WriteLine("Enter new Supplier Location:");
                supplier.SupplierLocation = Console.ReadLine();
                Console.WriteLine("Enter new Phone Number:");
                supplier.PhoneNumber = Console.ReadLine();
                Console.WriteLine("Enter new Email:");
                supplier.Email = Console.ReadLine();

                context.SaveChanges();
                Console.WriteLine("Supplier updated successfully!");
            }
            else
            {
                Console.WriteLine("Supplier not found!");
            }
        }


        //add/edit product
        public static void AddProduct(myContext context)
        {
            Console.WriteLine("Enter Product Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Product Price:");
            int price = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Product Category ID");
            int catId = int.Parse(Console.ReadLine());

            Products prdct = new Products
            {
                ProductName = name,
                Price = price,
                CategoryId= catId
            };

            context.Products.Add(prdct);
            context.SaveChanges();
            Console.WriteLine("Product added successfully!");

            string hasMeasuringUnits = Console.ReadLine().ToLower();

            if (hasMeasuringUnits == "yes")
            {
                Console.WriteLine("Enter Unit ID 1-KG , 2-Piecss , 3-Liters ,4-Boxs,5-Packets:");
                int unitId=int.Parse(Console.ReadLine()); // from measures table has all possible units
     

                // Create and link measuring unit
                var productMeasuringUnit = new ProductMeasuringUnit
                {
                    ProductId = prdct.ProductsId, // Linking to the product
                    UnitId = unitId
                };
                context.ProductMeasuringUnits.Add(productMeasuringUnit);
                context.SaveChanges();
                Console.WriteLine("Measuring units added successfully!");
            }
        }

        public static void EditProduct(myContext context)
        {
            Console.WriteLine("Enter Product ID to edit:");
            int id = int.Parse(Console.ReadLine());
            var product = context.Products.Find(id);
            if (product != null)
            {
                Console.WriteLine("Enter Product Name:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Product Price:");
                int price = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Product Category ID");
                int catId = int.Parse(Console.ReadLine());

                context.SaveChanges();
                Console.WriteLine("Product updated successfully!");
            }
            else
            {
                Console.WriteLine("Product Not Found");
            }
        }



        //add/edit customer
        public static void AddCustomer(myContext context)
        {
            Console.WriteLine("Enter Customer Name:");
            string name = Console.ReadLine();

            var customer = new Customer
            {
                CustomerName = name
            };

            context.Customers.Add(customer);
            context.SaveChanges();
            Console.WriteLine("Customer added successfully!");
        }

        public static void EditCustomer(myContext context)
        {
            Console.WriteLine("Enter Customer ID to edit:");
            int id = int.Parse(Console.ReadLine());
            var customer = context.Customers.Find(id);

            if (customer != null)
            {
                Console.WriteLine("Enter new Customer Name:");
                customer.CustomerName = Console.ReadLine();

                context.SaveChanges();
                Console.WriteLine("Customer updated successfully!");
            }
            else
            {
                Console.WriteLine("Customer not found!");
            }
        }





        // Delete Warehouse
        public static void DeleteWarehouse(myContext context, int id)
        {
            var warehouse = context.Warehouses
                .Include(w => w.WhProducts)
                .Include(w => w.supplyPermission)
                .Include(w => w.releasePermission)
                .FirstOrDefault(w => w.WarhouseId == id);

            if (warehouse == null)
            {
                Console.WriteLine("Warehouse not found!");
                return;
            }
            if (warehouse.WhProducts.Any(wps => wps.CurrentStock > 0))
            {
                Console.WriteLine("Cannot delete warehouse with active stock!");
                return;
            }

            if (warehouse.supplyPermission.Any() || warehouse.releasePermission.Any())
            {
                Console.WriteLine("Cannot delete warehouse with active permissions!");
                return;
            }
            context.Warehouses.Remove(warehouse);
            context.SaveChanges();
            Console.WriteLine("Warehouse deleted successfully!");
        }


        // Delete Supplier
        public static void DeleteSupplier(myContext context, int id)
            {
                var supplier = context.Suppliers.Find(id);
                if (supplier != null)
                {
                    context.Suppliers.Remove(supplier);
                    context.SaveChanges();
                    Console.WriteLine("Supplier deleted successfully!");
                }
                else
                {
                    Console.WriteLine("Supplier not found!");
                }
            }

            // Delete Product
            public static void DeleteProduct(myContext context, int id)
            {
                var product = context.Products
                .Include(p=>p.WhProducts)
                .Include(p => p.supplyPermProducts)
                .Include(p => p.releasePermProducts)
                .FirstOrDefault(p => p.ProductsId == id);

                if (product==null)
                {
                Console.WriteLine("Product not Found");
                }

                if (product.WhProducts.Any(wh=>wh.CurrentStock >0))
                {
                Console.WriteLine("Cannot delete product with active stock!");
                return;
                }

            if (product.supplyPermProducts.Any() || product.releasePermProducts.Any())
            {
                Console.WriteLine("Cannot delete product with active permissions!");
                return;
            }


            context.Products.Remove(product);
            context.SaveChanges();
            Console.WriteLine("Product deleted successfully!");
        }

            // Delete Customer
            public static void DeleteCustomer(myContext context, int id)
            {
                var customer = context.Customers.Find(id);
                if (customer != null)
                {
                    context.Customers.Remove(customer);
                    context.SaveChanges();
                    Console.WriteLine("Customer deleted successfully!");
                }
                else
                {
                    Console.WriteLine("Customer not found!");
                }
            }
        }

    }


