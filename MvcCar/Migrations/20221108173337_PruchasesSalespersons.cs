using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcCar.Migrations
{
    public partial class PruchasesSalespersons : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SalesPerson",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HouseNumber = table.Column<int>(type: "int", nullable: true),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Town = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZipCode = table.Column<int>(type: "int", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Salary = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesPerson", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CarPurchase",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: true),
                    CarId = table.Column<int>(type: "int", nullable: true),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PricePaid = table.Column<int>(type: "int", nullable: true),
                    SalesPersonId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarPurchase", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarPurchase_Car_CarId",
                        column: x => x.CarId,
                        principalTable: "Car",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CarPurchase_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CarPurchase_SalesPerson_SalesPersonId",
                        column: x => x.SalesPersonId,
                        principalTable: "SalesPerson",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarPurchase_CarId",
                table: "CarPurchase",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_CarPurchase_CustomerId",
                table: "CarPurchase",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_CarPurchase_SalesPersonId",
                table: "CarPurchase",
                column: "SalesPersonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarPurchase");

            migrationBuilder.DropTable(
                name: "SalesPerson");
        }
    }
}
