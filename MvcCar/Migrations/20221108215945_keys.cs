using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcCar.Migrations
{
    public partial class keys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarPurchase_Customer_CustomerId",
                table: "CarPurchase");

            migrationBuilder.DropForeignKey(
                name: "FK_CarPurchase_SalesPerson_SalesPersonId",
                table: "CarPurchase");

            migrationBuilder.AlterColumn<int>(
                name: "SalesPersonId",
                table: "CarPurchase",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "CarPurchase",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CarPurchase_Customer_CustomerId",
                table: "CarPurchase",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CarPurchase_SalesPerson_SalesPersonId",
                table: "CarPurchase",
                column: "SalesPersonId",
                principalTable: "SalesPerson",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarPurchase_Customer_CustomerId",
                table: "CarPurchase");

            migrationBuilder.DropForeignKey(
                name: "FK_CarPurchase_SalesPerson_SalesPersonId",
                table: "CarPurchase");

            migrationBuilder.AlterColumn<int>(
                name: "SalesPersonId",
                table: "CarPurchase",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "CarPurchase",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_CarPurchase_Customer_CustomerId",
                table: "CarPurchase",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CarPurchase_SalesPerson_SalesPersonId",
                table: "CarPurchase",
                column: "SalesPersonId",
                principalTable: "SalesPerson",
                principalColumn: "Id");
        }
    }
}
