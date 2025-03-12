using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InventoryManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class addedWhConnection : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WhProductId",
                table: "TransferProductsBySuppliers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TransferProductsBySuppliers_WhProductId",
                table: "TransferProductsBySuppliers",
                column: "WhProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_TransferProductsBySuppliers_WhProductsBySuppliers_WhProductId",
                table: "TransferProductsBySuppliers",
                column: "WhProductId",
                principalTable: "WhProductsBySuppliers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TransferProductsBySuppliers_WhProductsBySuppliers_WhProductId",
                table: "TransferProductsBySuppliers");

            migrationBuilder.DropIndex(
                name: "IX_TransferProductsBySuppliers_WhProductId",
                table: "TransferProductsBySuppliers");

            migrationBuilder.DropColumn(
                name: "WhProductId",
                table: "TransferProductsBySuppliers");
        }
    }
}
