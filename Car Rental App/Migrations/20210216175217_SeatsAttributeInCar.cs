using Microsoft.EntityFrameworkCore.Migrations;

namespace Car_Rental_App.Migrations
{
    public partial class SeatsAttributeInCar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Seats",
                table: "cars",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Seats",
                table: "cars");
        }
    }
}
