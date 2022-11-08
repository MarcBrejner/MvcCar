using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcCar.Migrations
{
    public partial class pleasego : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Extras",
                table: "Car");

            migrationBuilder.CreateTable(
                name: "Extra",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExtraItem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Extra", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Extra_Car_CarId",
                        column: x => x.CarId,
                        principalTable: "Car",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Extra_CarId",
                table: "Extra",
                column: "CarId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Extra");

            migrationBuilder.AddColumn<string>(
                name: "Extras",
                table: "Car",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
