using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InventoryManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class AddDeleteRestrictions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductMeasuringUnits_Measures_MeasuringUnitUnitId",
                table: "ProductMeasuringUnits");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_ReleasePermissions_Customers_CustomerId",
                table: "ReleasePermissions");

            migrationBuilder.DropForeignKey(
                name: "FK_ReleasePermissions_Warehouses_warehouseId",
                table: "ReleasePermissions");

            migrationBuilder.DropForeignKey(
                name: "FK_ReleasePermProducts_Products_productId",
                table: "ReleasePermProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_SupplyPermissions_Suppliers_supplierId",
                table: "SupplyPermissions");

            migrationBuilder.DropForeignKey(
                name: "FK_SupplyPermissions_Warehouses_WarehouseId",
                table: "SupplyPermissions");

            migrationBuilder.DropForeignKey(
                name: "FK_SupplyPermProducts_Products_ProductId",
                table: "SupplyPermProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_TransferProductsBySuppliers_Products_productID",
                table: "TransferProductsBySuppliers");

            migrationBuilder.DropForeignKey(
                name: "FK_TransferProductsBySuppliers_Suppliers_supplierId",
                table: "TransferProductsBySuppliers");

            migrationBuilder.DropForeignKey(
                name: "FK_WhProductsBySuppliers_Products_ProductId",
                table: "WhProductsBySuppliers");

            migrationBuilder.DropForeignKey(
                name: "FK_WhProductsBySuppliers_Suppliers_SupplierId",
                table: "WhProductsBySuppliers");

            migrationBuilder.DropForeignKey(
                name: "FK_WhProductsBySuppliers_Warehouses_WarehouseId",
                table: "WhProductsBySuppliers");

            migrationBuilder.DropIndex(
                name: "IX_ProductMeasuringUnits_MeasuringUnitUnitId",
                table: "ProductMeasuringUnits");

            migrationBuilder.DropColumn(
                name: "MeasuringUnitUnitId",
                table: "ProductMeasuringUnits");

            migrationBuilder.CreateIndex(
                name: "IX_ProductMeasuringUnits_UnitId",
                table: "ProductMeasuringUnits",
                column: "UnitId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductMeasuringUnits_Measures_UnitId",
                table: "ProductMeasuringUnits",
                column: "UnitId",
                principalTable: "Measures",
                principalColumn: "UnitId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ReleasePermissions_Customers_CustomerId",
                table: "ReleasePermissions",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ReleasePermissions_Warehouses_warehouseId",
                table: "ReleasePermissions",
                column: "warehouseId",
                principalTable: "Warehouses",
                principalColumn: "WarhouseId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ReleasePermProducts_Products_productId",
                table: "ReleasePermProducts",
                column: "productId",
                principalTable: "Products",
                principalColumn: "ProductsId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SupplyPermissions_Suppliers_supplierId",
                table: "SupplyPermissions",
                column: "supplierId",
                principalTable: "Suppliers",
                principalColumn: "SupplierId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SupplyPermissions_Warehouses_WarehouseId",
                table: "SupplyPermissions",
                column: "WarehouseId",
                principalTable: "Warehouses",
                principalColumn: "WarhouseId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SupplyPermProducts_Products_ProductId",
                table: "SupplyPermProducts",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductsId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TransferProductsBySuppliers_Products_productID",
                table: "TransferProductsBySuppliers",
                column: "productID",
                principalTable: "Products",
                principalColumn: "ProductsId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TransferProductsBySuppliers_Suppliers_supplierId",
                table: "TransferProductsBySuppliers",
                column: "supplierId",
                principalTable: "Suppliers",
                principalColumn: "SupplierId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WhProductsBySuppliers_Products_ProductId",
                table: "WhProductsBySuppliers",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductsId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WhProductsBySuppliers_Suppliers_SupplierId",
                table: "WhProductsBySuppliers",
                column: "SupplierId",
                principalTable: "Suppliers",
                principalColumn: "SupplierId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WhProductsBySuppliers_Warehouses_WarehouseId",
                table: "WhProductsBySuppliers",
                column: "WarehouseId",
                principalTable: "Warehouses",
                principalColumn: "WarhouseId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductMeasuringUnits_Measures_UnitId",
                table: "ProductMeasuringUnits");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_ReleasePermissions_Customers_CustomerId",
                table: "ReleasePermissions");

            migrationBuilder.DropForeignKey(
                name: "FK_ReleasePermissions_Warehouses_warehouseId",
                table: "ReleasePermissions");

            migrationBuilder.DropForeignKey(
                name: "FK_ReleasePermProducts_Products_productId",
                table: "ReleasePermProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_SupplyPermissions_Suppliers_supplierId",
                table: "SupplyPermissions");

            migrationBuilder.DropForeignKey(
                name: "FK_SupplyPermissions_Warehouses_WarehouseId",
                table: "SupplyPermissions");

            migrationBuilder.DropForeignKey(
                name: "FK_SupplyPermProducts_Products_ProductId",
                table: "SupplyPermProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_TransferProductsBySuppliers_Products_productID",
                table: "TransferProductsBySuppliers");

            migrationBuilder.DropForeignKey(
                name: "FK_TransferProductsBySuppliers_Suppliers_supplierId",
                table: "TransferProductsBySuppliers");

            migrationBuilder.DropForeignKey(
                name: "FK_WhProductsBySuppliers_Products_ProductId",
                table: "WhProductsBySuppliers");

            migrationBuilder.DropForeignKey(
                name: "FK_WhProductsBySuppliers_Suppliers_SupplierId",
                table: "WhProductsBySuppliers");

            migrationBuilder.DropForeignKey(
                name: "FK_WhProductsBySuppliers_Warehouses_WarehouseId",
                table: "WhProductsBySuppliers");

            migrationBuilder.DropIndex(
                name: "IX_ProductMeasuringUnits_UnitId",
                table: "ProductMeasuringUnits");

            migrationBuilder.AddColumn<int>(
                name: "MeasuringUnitUnitId",
                table: "ProductMeasuringUnits",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ProductMeasuringUnits_MeasuringUnitUnitId",
                table: "ProductMeasuringUnits",
                column: "MeasuringUnitUnitId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductMeasuringUnits_Measures_MeasuringUnitUnitId",
                table: "ProductMeasuringUnits",
                column: "MeasuringUnitUnitId",
                principalTable: "Measures",
                principalColumn: "UnitId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_ReleasePermissions_Customers_CustomerId",
                table: "ReleasePermissions",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_ReleasePermissions_Warehouses_warehouseId",
                table: "ReleasePermissions",
                column: "warehouseId",
                principalTable: "Warehouses",
                principalColumn: "WarhouseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ReleasePermProducts_Products_productId",
                table: "ReleasePermProducts",
                column: "productId",
                principalTable: "Products",
                principalColumn: "ProductsId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SupplyPermissions_Suppliers_supplierId",
                table: "SupplyPermissions",
                column: "supplierId",
                principalTable: "Suppliers",
                principalColumn: "SupplierId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SupplyPermissions_Warehouses_WarehouseId",
                table: "SupplyPermissions",
                column: "WarehouseId",
                principalTable: "Warehouses",
                principalColumn: "WarhouseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SupplyPermProducts_Products_ProductId",
                table: "SupplyPermProducts",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductsId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TransferProductsBySuppliers_Products_productID",
                table: "TransferProductsBySuppliers",
                column: "productID",
                principalTable: "Products",
                principalColumn: "ProductsId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TransferProductsBySuppliers_Suppliers_supplierId",
                table: "TransferProductsBySuppliers",
                column: "supplierId",
                principalTable: "Suppliers",
                principalColumn: "SupplierId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WhProductsBySuppliers_Products_ProductId",
                table: "WhProductsBySuppliers",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductsId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WhProductsBySuppliers_Suppliers_SupplierId",
                table: "WhProductsBySuppliers",
                column: "SupplierId",
                principalTable: "Suppliers",
                principalColumn: "SupplierId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WhProductsBySuppliers_Warehouses_WarehouseId",
                table: "WhProductsBySuppliers",
                column: "WarehouseId",
                principalTable: "Warehouses",
                principalColumn: "WarhouseId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
