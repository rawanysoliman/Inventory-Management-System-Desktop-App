using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManagementSystem.configuration;
using InventoryManagementSystem.Entities;
using Microsoft.EntityFrameworkCore;


namespace InventoryManagementSystem.context
{
    public class myContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=RAWAN\\SQLEXPRESS01;Initial Catalog=Inventory;Integrated Security=True;trustServerCertificate= true");
        }


        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<TransferPermission> TransferPermissions { get; set; }
        public DbSet<TransferProductsBySuppliers> TransferProductsBySuppliers { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<WhProductsBySupplier> WhProductsBySuppliers { get; set; }
        public DbSet<SupplyPermission> SupplyPermissions { get; set; }
        public DbSet<SupplyPermProducts> SupplyPermProducts { get; set; }
        public DbSet<ReleasePermission> ReleasePermissions { get; set; }
        public DbSet<ReleasePermProducts> ReleasePermProducts { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<MeasuringUnit> Measures { get; set; }
        public DbSet<ProductMeasuringUnit> ProductMeasuringUnits { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new transferPerConfig());


            //Composite Key
            modelBuilder.Entity<ProductMeasuringUnit>()
                .HasKey(pm => new { pm.ProductId, pm.UnitId });




            modelBuilder.Entity<SupplyPermission>()
                        .HasOne(sp => sp.supplier)
                        .WithMany(s => s.supplyPermissions)
                        .OnDelete(DeleteBehavior.Restrict);


            // Warehouse - SupplyPermission
            modelBuilder.Entity<SupplyPermission>()
                .HasOne(sp => sp.warehouse)
                .WithMany(w => w.supplyPermission)
                .OnDelete(DeleteBehavior.Restrict);


            // Product - SupplyPermProducts
            modelBuilder.Entity<SupplyPermProducts>()
                .HasOne(spp => spp.product)
                .WithMany(p => p.supplyPermProducts)
                .HasForeignKey(spp => spp.ProductId)
                .OnDelete(DeleteBehavior.Restrict);

            // Warehouse - ReleasePermission
            modelBuilder.Entity<ReleasePermission>()
                .HasOne(rp => rp.warehouse)
                .WithMany(w => w.releasePermission)
                .HasForeignKey(rp => rp.warehouseId)
                .OnDelete(DeleteBehavior.Restrict);

            // Customer - ReleasePermission
            modelBuilder.Entity<ReleasePermission>()
                .HasOne(rp => rp.customer)
                .WithMany(c => c.releasePermissions)
                .HasForeignKey(rp => rp.CustomerId)
                .OnDelete(DeleteBehavior.Restrict);

            // Product - ReleasePermProducts
            modelBuilder.Entity<ReleasePermProducts>()
                .HasOne(rpp => rpp.product)
                .WithMany(p => p.releasePermProducts)
                .HasForeignKey(rpp => rpp.productId)
                .OnDelete(DeleteBehavior.Restrict);

            // Warehouse - WhProductsBySupplier
            modelBuilder.Entity<WhProductsBySupplier>()
                .HasOne(wps => wps.warehouse)
                .WithMany(w => w.WhProducts)
                .HasForeignKey(wps => wps.WarehouseId)
                .OnDelete(DeleteBehavior.Restrict);

            // Supplier - WhProductsBySupplier
            modelBuilder.Entity<WhProductsBySupplier>()
                .HasOne(wps => wps.supplier)
                .WithMany(s => s.productDetails)
                .HasForeignKey(wps => wps.SupplierId)
                .OnDelete(DeleteBehavior.Restrict);

            // Product - WhProductsBySupplier
            modelBuilder.Entity<WhProductsBySupplier>()
                .HasOne(wps => wps.product)
                .WithMany(p => p.WhProducts)
                .HasForeignKey(wps => wps.ProductId)
                .OnDelete(DeleteBehavior.Restrict);


            // Product - TransferProductsBySuppliers
            modelBuilder.Entity<TransferProductsBySuppliers>()
                .HasOne(tps => tps.product)
                .WithMany(p => p.transferPermProducts)
                .HasForeignKey(tps => tps.productID)
                .OnDelete(DeleteBehavior.Restrict);

            // Supplier - TransferProductsBySuppliers
            modelBuilder.Entity<TransferProductsBySuppliers>()
                .HasOne(tps => tps.supplier)
                .WithMany(s => s.transferedItemDetails)
                .HasForeignKey(tps => tps.supplierId)
                .OnDelete(DeleteBehavior.Restrict);

            // Warehouse - TransferPermission (source)
            modelBuilder.Entity<TransferPermission>()
                .HasOne(tp => tp.sourceWarehouse)
                .WithMany(w => w.transferSource)
                .HasForeignKey(tp => tp.sourceWarehouseId)
                .OnDelete(DeleteBehavior.Restrict);

            // Warehouse - TransferPermission (destination)
            modelBuilder.Entity<TransferPermission>()
                .HasOne(tp => tp.destWarehouse)
                .WithMany(w => w.transferDestination)
                .HasForeignKey(tp => tp.destWarehouseId)
                .OnDelete(DeleteBehavior.Restrict);

            // Product - ProductMeasuringUnit
            modelBuilder.Entity<ProductMeasuringUnit>()
                .HasOne(pmu => pmu.Product)
                .WithMany(p => p.ProductMeasuringUnits)
                .OnDelete(DeleteBehavior.Cascade);

            // MeasuringUnit - ProductMeasuringUnit
            modelBuilder.Entity<ProductMeasuringUnit>()
                .HasOne(pmu => pmu.MeasuringUnit)
                .WithMany(mu => mu.ProductMeasuringUnits)
                .HasForeignKey(pmu => pmu.UnitId)
                .OnDelete(DeleteBehavior.Cascade);

            // Category - Products
            modelBuilder.Entity<Products>()
                .HasOne(p => p.category)
                .WithMany(c => c.products)
                .OnDelete(DeleteBehavior.Cascade);

            // TransferPermission - TransferProductsBySuppliers
            modelBuilder.Entity<TransferProductsBySuppliers>()
                .HasOne(tps => tps.transferPermission)
                .WithMany(tp => tp.transferedItemDetails)
                .HasForeignKey(tps => tps.transferPermissionId)
                .OnDelete(DeleteBehavior.Cascade);


            // SupplyPermission - SupplyPermProducts
            modelBuilder.Entity<SupplyPermProducts>()
                .HasOne(spp => spp.supplyPermission)
                .WithMany(sp => sp.supplyPermProducts)
                .OnDelete(DeleteBehavior.Cascade);

            // ReleasePermission - ReleasePermProducts
            modelBuilder.Entity<ReleasePermProducts>()
                .HasOne(rpp => rpp.releasePermission)
                .WithMany(rp => rp.releasePermProducts)
                .OnDelete(DeleteBehavior.Cascade);




            base.OnModelCreating(modelBuilder);
        }
    }
}
