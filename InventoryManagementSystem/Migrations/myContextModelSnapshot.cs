﻿// <auto-generated />
using System;
using InventoryManagementSystem.context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace InventoryManagementSystem.Migrations
{
    [DbContext(typeof(myContext))]
    partial class myContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("InventoryManagementSystem.Entities.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("CategoryDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("InventoryManagementSystem.Entities.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"));

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("InventoryManagementSystem.Entities.MeasuringUnit", b =>
                {
                    b.Property<int>("UnitId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UnitId"));

                    b.Property<string>("UnitName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("UnitId");

                    b.ToTable("Measures");
                });

            modelBuilder.Entity("InventoryManagementSystem.Entities.ProductMeasuringUnit", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("UnitId")
                        .HasColumnType("int");

                    b.HasKey("ProductId", "UnitId");

                    b.HasIndex("UnitId");

                    b.ToTable("ProductMeasuringUnits");
                });

            modelBuilder.Entity("InventoryManagementSystem.Entities.Products", b =>
                {
                    b.Property<int>("ProductsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductsId"));

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductsId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("InventoryManagementSystem.Entities.ReleasePermProducts", b =>
                {
                    b.Property<int>("releasePermProductsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("releasePermProductsId"));

                    b.Property<DateTime>("ExpireDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("productId")
                        .HasColumnType("int");

                    b.Property<DateTime>("productionDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("quantity")
                        .HasColumnType("int");

                    b.Property<int>("releasePermissionId")
                        .HasColumnType("int");

                    b.HasKey("releasePermProductsId");

                    b.HasIndex("productId");

                    b.HasIndex("releasePermissionId");

                    b.ToTable("ReleasePermProducts");
                });

            modelBuilder.Entity("InventoryManagementSystem.Entities.ReleasePermission", b =>
                {
                    b.Property<int>("ReleasePermissionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReleasePermissionId"));

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("warehouseId")
                        .HasColumnType("int");

                    b.HasKey("ReleasePermissionId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("warehouseId");

                    b.ToTable("ReleasePermissions");
                });

            modelBuilder.Entity("InventoryManagementSystem.Entities.Supplier", b =>
                {
                    b.Property<int>("SupplierId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SupplierId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SupplierLocation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SupplierName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("faxNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SupplierId");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("InventoryManagementSystem.Entities.SupplyPermProducts", b =>
                {
                    b.Property<int>("SupplyPermProductsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SupplyPermProductsId"));

                    b.Property<int>("ExpiryDuration")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ProductionDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("SupplyPermissionId")
                        .HasColumnType("int");

                    b.Property<DateTime>("supplyDate")
                        .HasColumnType("datetime2");

                    b.HasKey("SupplyPermProductsId");

                    b.HasIndex("ProductId");

                    b.HasIndex("SupplyPermissionId");

                    b.ToTable("SupplyPermProducts");
                });

            modelBuilder.Entity("InventoryManagementSystem.Entities.SupplyPermission", b =>
                {
                    b.Property<int>("SupplyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SupplyId"));

                    b.Property<int>("WarehouseId")
                        .HasColumnType("int");

                    b.Property<int>("supplierId")
                        .HasColumnType("int");

                    b.Property<DateTime>("supplyDate")
                        .HasColumnType("datetime2");

                    b.HasKey("SupplyId");

                    b.HasIndex("WarehouseId");

                    b.HasIndex("supplierId");

                    b.ToTable("SupplyPermissions");
                });

            modelBuilder.Entity("InventoryManagementSystem.Entities.TransferPermission", b =>
                {
                    b.Property<int>("TransferId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TransferId"));

                    b.Property<DateTime>("TransferDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("destWarehouseId")
                        .HasColumnType("int");

                    b.Property<int>("sourceWarehouseId")
                        .HasColumnType("int");

                    b.HasKey("TransferId");

                    b.HasIndex("destWarehouseId");

                    b.HasIndex("sourceWarehouseId");

                    b.ToTable("TransferPermissions");
                });

            modelBuilder.Entity("InventoryManagementSystem.Entities.TransferProductsBySuppliers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("ExpireDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ProductionDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("productID")
                        .HasColumnType("int");

                    b.Property<int>("supplierId")
                        .HasColumnType("int");

                    b.Property<int>("transferPermissionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("productID");

                    b.HasIndex("supplierId");

                    b.HasIndex("transferPermissionId");

                    b.ToTable("TransferProductsBySuppliers");
                });

            modelBuilder.Entity("InventoryManagementSystem.Entities.Warehouse", b =>
                {
                    b.Property<int>("WarhouseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WarhouseId"));

                    b.Property<string>("WarehouseLocation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WarehouseManager")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WarehouseName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WarhouseId");

                    b.ToTable("Warehouses");
                });

            modelBuilder.Entity("InventoryManagementSystem.Entities.WhProductsBySupplier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CurrentStock")
                        .HasColumnType("int");

                    b.Property<DateTime>("ExpireDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ProductionDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("SupplierId")
                        .HasColumnType("int");

                    b.Property<int>("WarehouseId")
                        .HasColumnType("int");

                    b.Property<DateTime>("supplyDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("SupplierId");

                    b.HasIndex("WarehouseId");

                    b.ToTable("WhProductsBySuppliers");
                });

            modelBuilder.Entity("InventoryManagementSystem.Entities.ProductMeasuringUnit", b =>
                {
                    b.HasOne("InventoryManagementSystem.Entities.Products", "Product")
                        .WithMany("ProductMeasuringUnits")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InventoryManagementSystem.Entities.MeasuringUnit", "MeasuringUnit")
                        .WithMany("ProductMeasuringUnits")
                        .HasForeignKey("UnitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MeasuringUnit");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("InventoryManagementSystem.Entities.Products", b =>
                {
                    b.HasOne("InventoryManagementSystem.Entities.Category", "category")
                        .WithMany("products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("category");
                });

            modelBuilder.Entity("InventoryManagementSystem.Entities.ReleasePermProducts", b =>
                {
                    b.HasOne("InventoryManagementSystem.Entities.Products", "product")
                        .WithMany("releasePermProducts")
                        .HasForeignKey("productId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("InventoryManagementSystem.Entities.ReleasePermission", "releasePermission")
                        .WithMany("releasePermProducts")
                        .HasForeignKey("releasePermissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("product");

                    b.Navigation("releasePermission");
                });

            modelBuilder.Entity("InventoryManagementSystem.Entities.ReleasePermission", b =>
                {
                    b.HasOne("InventoryManagementSystem.Entities.Customer", "customer")
                        .WithMany("releasePermissions")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("InventoryManagementSystem.Entities.Warehouse", "warehouse")
                        .WithMany("releasePermission")
                        .HasForeignKey("warehouseId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("customer");

                    b.Navigation("warehouse");
                });

            modelBuilder.Entity("InventoryManagementSystem.Entities.SupplyPermProducts", b =>
                {
                    b.HasOne("InventoryManagementSystem.Entities.Products", "product")
                        .WithMany("supplyPermProducts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("InventoryManagementSystem.Entities.SupplyPermission", "supplyPermission")
                        .WithMany("supplyPermProducts")
                        .HasForeignKey("SupplyPermissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("product");

                    b.Navigation("supplyPermission");
                });

            modelBuilder.Entity("InventoryManagementSystem.Entities.SupplyPermission", b =>
                {
                    b.HasOne("InventoryManagementSystem.Entities.Warehouse", "warehouse")
                        .WithMany("supplyPermission")
                        .HasForeignKey("WarehouseId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("InventoryManagementSystem.Entities.Supplier", "supplier")
                        .WithMany("supplyPermissions")
                        .HasForeignKey("supplierId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("supplier");

                    b.Navigation("warehouse");
                });

            modelBuilder.Entity("InventoryManagementSystem.Entities.TransferPermission", b =>
                {
                    b.HasOne("InventoryManagementSystem.Entities.Warehouse", "destWarehouse")
                        .WithMany("transferDestination")
                        .HasForeignKey("destWarehouseId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("InventoryManagementSystem.Entities.Warehouse", "sourceWarehouse")
                        .WithMany("transferSource")
                        .HasForeignKey("sourceWarehouseId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("destWarehouse");

                    b.Navigation("sourceWarehouse");
                });

            modelBuilder.Entity("InventoryManagementSystem.Entities.TransferProductsBySuppliers", b =>
                {
                    b.HasOne("InventoryManagementSystem.Entities.Products", "product")
                        .WithMany("transferPermProducts")
                        .HasForeignKey("productID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("InventoryManagementSystem.Entities.Supplier", "supplier")
                        .WithMany("transferedItemDetails")
                        .HasForeignKey("supplierId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("InventoryManagementSystem.Entities.TransferPermission", "transferPermission")
                        .WithMany("transferedItemDetails")
                        .HasForeignKey("transferPermissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("product");

                    b.Navigation("supplier");

                    b.Navigation("transferPermission");
                });

            modelBuilder.Entity("InventoryManagementSystem.Entities.WhProductsBySupplier", b =>
                {
                    b.HasOne("InventoryManagementSystem.Entities.Products", "product")
                        .WithMany("WhProducts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("InventoryManagementSystem.Entities.Supplier", "supplier")
                        .WithMany("productDetails")
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("InventoryManagementSystem.Entities.Warehouse", "warehouse")
                        .WithMany("WhProducts")
                        .HasForeignKey("WarehouseId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("product");

                    b.Navigation("supplier");

                    b.Navigation("warehouse");
                });

            modelBuilder.Entity("InventoryManagementSystem.Entities.Category", b =>
                {
                    b.Navigation("products");
                });

            modelBuilder.Entity("InventoryManagementSystem.Entities.Customer", b =>
                {
                    b.Navigation("releasePermissions");
                });

            modelBuilder.Entity("InventoryManagementSystem.Entities.MeasuringUnit", b =>
                {
                    b.Navigation("ProductMeasuringUnits");
                });

            modelBuilder.Entity("InventoryManagementSystem.Entities.Products", b =>
                {
                    b.Navigation("ProductMeasuringUnits");

                    b.Navigation("WhProducts");

                    b.Navigation("releasePermProducts");

                    b.Navigation("supplyPermProducts");

                    b.Navigation("transferPermProducts");
                });

            modelBuilder.Entity("InventoryManagementSystem.Entities.ReleasePermission", b =>
                {
                    b.Navigation("releasePermProducts");
                });

            modelBuilder.Entity("InventoryManagementSystem.Entities.Supplier", b =>
                {
                    b.Navigation("productDetails");

                    b.Navigation("supplyPermissions");

                    b.Navigation("transferedItemDetails");
                });

            modelBuilder.Entity("InventoryManagementSystem.Entities.SupplyPermission", b =>
                {
                    b.Navigation("supplyPermProducts");
                });

            modelBuilder.Entity("InventoryManagementSystem.Entities.TransferPermission", b =>
                {
                    b.Navigation("transferedItemDetails");
                });

            modelBuilder.Entity("InventoryManagementSystem.Entities.Warehouse", b =>
                {
                    b.Navigation("WhProducts");

                    b.Navigation("releasePermission");

                    b.Navigation("supplyPermission");

                    b.Navigation("transferDestination");

                    b.Navigation("transferSource");
                });
#pragma warning restore 612, 618
        }
    }
}
