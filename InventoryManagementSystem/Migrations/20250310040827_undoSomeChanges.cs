using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InventoryManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class undoSomeChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TransferProductsBySuppliers_Warehouses_DestinationWarehouseId",
                table: "TransferProductsBySuppliers");

            migrationBuilder.DropForeignKey(
                name: "FK_TransferProductsBySuppliers_Warehouses_SourceWarehouseId",
                table: "TransferProductsBySuppliers");

            migrationBuilder.DropIndex(
                name: "IX_TransferProductsBySuppliers_DestinationWarehouseId",
                table: "TransferProductsBySuppliers");

            migrationBuilder.DropIndex(
                name: "IX_TransferProductsBySuppliers_SourceWarehouseId",
                table: "TransferProductsBySuppliers");

            migrationBuilder.DropColumn(
                name: "DestinationWarehouseId",
                table: "TransferProductsBySuppliers");

            migrationBuilder.DropColumn(
                name: "SourceWarehouseId",
                table: "TransferProductsBySuppliers");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DestinationWarehouseId",
                table: "TransferProductsBySuppliers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SourceWarehouseId",
                table: "TransferProductsBySuppliers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TransferProductsBySuppliers_DestinationWarehouseId",
                table: "TransferProductsBySuppliers",
                column: "DestinationWarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_TransferProductsBySuppliers_SourceWarehouseId",
                table: "TransferProductsBySuppliers",
                column: "SourceWarehouseId");

            migrationBuilder.AddForeignKey(
                name: "FK_TransferProductsBySuppliers_Warehouses_DestinationWarehouseId",
                table: "TransferProductsBySuppliers",
                column: "DestinationWarehouseId",
                principalTable: "Warehouses",
                principalColumn: "WarhouseId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TransferProductsBySuppliers_Warehouses_SourceWarehouseId",
                table: "TransferProductsBySuppliers",
                column: "SourceWarehouseId",
                principalTable: "Warehouses",
                principalColumn: "WarhouseId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
