using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcCar.Migrations
{
    public partial class Customernew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Customer",
                newName: "Town");

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Customer",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HouseNumber",
                table: "Customer",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Street",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ZipCode",
                table: "Customer",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "HouseNumber",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Street",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "ZipCode",
                table: "Customer");

            migrationBuilder.RenameColumn(
                name: "Town",
                table: "Customer",
                newName: "Address");
        }
    }
}
