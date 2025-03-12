using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InventoryManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class myinitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "Measures",
                columns: table => new
                {
                    UnitId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnitName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Measures", x => x.UnitId);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    SupplierId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplierName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SupplierLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    faxNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.SupplierId);
                });

            migrationBuilder.CreateTable(
                name: "Warehouses",
                columns: table => new
                {
                    WarhouseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WarehouseName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WarehouseLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WarehouseManager = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warehouses", x => x.WarhouseId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductsId);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReleasePermissions",
                columns: table => new
                {
                    ReleasePermissionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    warehouseId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReleasePermissions", x => x.ReleasePermissionId);
                    table.ForeignKey(
                        name: "FK_ReleasePermissions_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReleasePermissions_Warehouses_warehouseId",
                        column: x => x.warehouseId,
                        principalTable: "Warehouses",
                        principalColumn: "WarhouseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SupplyPermissions",
                columns: table => new
                {
                    SupplyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    supplyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WarehouseId = table.Column<int>(type: "int", nullable: false),
                    supplierId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplyPermissions", x => x.SupplyId);
                    table.ForeignKey(
                        name: "FK_SupplyPermissions_Suppliers_supplierId",
                        column: x => x.supplierId,
                        principalTable: "Suppliers",
                        principalColumn: "SupplierId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplyPermissions_Warehouses_WarehouseId",
                        column: x => x.WarehouseId,
                        principalTable: "Warehouses",
                        principalColumn: "WarhouseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TransferPermissions",
                columns: table => new
                {
                    TransferId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransferDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    sourceWarehouseId = table.Column<int>(type: "int", nullable: false),
                    destWarehouseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransferPermissions", x => x.TransferId);
                    table.ForeignKey(
                        name: "FK_TransferPermissions_Warehouses_destWarehouseId",
                        column: x => x.destWarehouseId,
                        principalTable: "Warehouses",
                        principalColumn: "WarhouseId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TransferPermissions_Warehouses_sourceWarehouseId",
                        column: x => x.sourceWarehouseId,
                        principalTable: "Warehouses",
                        principalColumn: "WarhouseId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductMeasuringUnits",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    UnitId = table.Column<int>(type: "int", nullable: false),
                    MeasuringUnitUnitId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductMeasuringUnits", x => new { x.ProductId, x.UnitId });
                    table.ForeignKey(
                        name: "FK_ProductMeasuringUnits_Measures_MeasuringUnitUnitId",
                        column: x => x.MeasuringUnitUnitId,
                        principalTable: "Measures",
                        principalColumn: "UnitId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductMeasuringUnits_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductsId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WhProductsBySuppliers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WarehouseId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    SupplierId = table.Column<int>(type: "int", nullable: false),
                    CurrentStock = table.Column<int>(type: "int", nullable: false),
                    ExpireDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProductionDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WhProductsBySuppliers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WhProductsBySuppliers_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductsId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WhProductsBySuppliers_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "SupplierId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WhProductsBySuppliers_Warehouses_WarehouseId",
                        column: x => x.WarehouseId,
                        principalTable: "Warehouses",
                        principalColumn: "WarhouseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReleasePermProducts",
                columns: table => new
                {
                    releasePermProductsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    releasePermissionId = table.Column<int>(type: "int", nullable: false),
                    productId = table.Column<int>(type: "int", nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: false),
                    expireDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    productionDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReleasePermProducts", x => x.releasePermProductsId);
                    table.ForeignKey(
                        name: "FK_ReleasePermProducts_Products_productId",
                        column: x => x.productId,
                        principalTable: "Products",
                        principalColumn: "ProductsId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReleasePermProducts_ReleasePermissions_releasePermissionId",
                        column: x => x.releasePermissionId,
                        principalTable: "ReleasePermissions",
                        principalColumn: "ReleasePermissionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SupplyPermProducts",
                columns: table => new
                {
                    SupplyPermProductsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplyPermissionId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    ExpireDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProductionDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplyPermProducts", x => x.SupplyPermProductsId);
                    table.ForeignKey(
                        name: "FK_SupplyPermProducts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductsId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplyPermProducts_SupplyPermissions_SupplyPermissionId",
                        column: x => x.SupplyPermissionId,
                        principalTable: "SupplyPermissions",
                        principalColumn: "SupplyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TransferProductsBySuppliers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    productID = table.Column<int>(type: "int", nullable: false),
                    supplierId = table.Column<int>(type: "int", nullable: false),
                    transferPermissionId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    ExpireDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProductionDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransferProductsBySuppliers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TransferProductsBySuppliers_Products_productID",
                        column: x => x.productID,
                        principalTable: "Products",
                        principalColumn: "ProductsId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TransferProductsBySuppliers_Suppliers_supplierId",
                        column: x => x.supplierId,
                        principalTable: "Suppliers",
                        principalColumn: "SupplierId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TransferProductsBySuppliers_TransferPermissions_transferPermissionId",
                        column: x => x.transferPermissionId,
                        principalTable: "TransferPermissions",
                        principalColumn: "TransferId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductMeasuringUnits_MeasuringUnitUnitId",
                table: "ProductMeasuringUnits",
                column: "MeasuringUnitUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ReleasePermissions_CustomerId",
                table: "ReleasePermissions",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_ReleasePermissions_warehouseId",
                table: "ReleasePermissions",
                column: "warehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_ReleasePermProducts_productId",
                table: "ReleasePermProducts",
                column: "productId");

            migrationBuilder.CreateIndex(
                name: "IX_ReleasePermProducts_releasePermissionId",
                table: "ReleasePermProducts",
                column: "releasePermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplyPermissions_supplierId",
                table: "SupplyPermissions",
                column: "supplierId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplyPermissions_WarehouseId",
                table: "SupplyPermissions",
                column: "WarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplyPermProducts_ProductId",
                table: "SupplyPermProducts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplyPermProducts_SupplyPermissionId",
                table: "SupplyPermProducts",
                column: "SupplyPermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_TransferPermissions_destWarehouseId",
                table: "TransferPermissions",
                column: "destWarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_TransferPermissions_sourceWarehouseId",
                table: "TransferPermissions",
                column: "sourceWarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_TransferProductsBySuppliers_productID",
                table: "TransferProductsBySuppliers",
                column: "productID");

            migrationBuilder.CreateIndex(
                name: "IX_TransferProductsBySuppliers_supplierId",
                table: "TransferProductsBySuppliers",
                column: "supplierId");

            migrationBuilder.CreateIndex(
                name: "IX_TransferProductsBySuppliers_transferPermissionId",
                table: "TransferProductsBySuppliers",
                column: "transferPermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_WhProductsBySuppliers_ProductId",
                table: "WhProductsBySuppliers",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_WhProductsBySuppliers_SupplierId",
                table: "WhProductsBySuppliers",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_WhProductsBySuppliers_WarehouseId",
                table: "WhProductsBySuppliers",
                column: "WarehouseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductMeasuringUnits");

            migrationBuilder.DropTable(
                name: "ReleasePermProducts");

            migrationBuilder.DropTable(
                name: "SupplyPermProducts");

            migrationBuilder.DropTable(
                name: "TransferProductsBySuppliers");

            migrationBuilder.DropTable(
                name: "WhProductsBySuppliers");

            migrationBuilder.DropTable(
                name: "Measures");

            migrationBuilder.DropTable(
                name: "ReleasePermissions");

            migrationBuilder.DropTable(
                name: "SupplyPermissions");

            migrationBuilder.DropTable(
                name: "TransferPermissions");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropTable(
                name: "Warehouses");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
