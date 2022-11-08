using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcCar.Migrations
{
    public partial class Virtual : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarPurchase_Car_CarId",
                table: "CarPurchase");

            migrationBuilder.AlterColumn<int>(
                name: "CarId",
                table: "CarPurchase",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CarPurchase_Car_CarId",
                table: "CarPurchase",
                column: "CarId",
                principalTable: "Car",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarPurchase_Car_CarId",
                table: "CarPurchase");

            migrationBuilder.AlterColumn<int>(
                name: "CarId",
                table: "CarPurchase",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_CarPurchase_Car_CarId",
                table: "CarPurchase",
                column: "CarId",
                principalTable: "Car",
                principalColumn: "Id");
        }
    }
}
