using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InventoryManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class AddReleasePerm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReleasePermissions_Customers_CustomerId",
                table: "ReleasePermissions");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "ReleasePermissions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<DateTime>(
                name: "ReleaseDate",
                table: "ReleasePermissions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddForeignKey(
                name: "FK_ReleasePermissions_Customers_CustomerId",
                table: "ReleasePermissions",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReleasePermissions_Customers_CustomerId",
                table: "ReleasePermissions");

            migrationBuilder.DropColumn(
                name: "ReleaseDate",
                table: "ReleasePermissions");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "ReleasePermissions",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ReleasePermissions_Customers_CustomerId",
                table: "ReleasePermissions",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
