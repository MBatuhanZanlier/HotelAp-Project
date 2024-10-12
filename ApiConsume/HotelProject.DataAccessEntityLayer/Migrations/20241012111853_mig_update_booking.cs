using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelProject.DataAccessEntityLayer.Migrations
{
    public partial class mig_update_booking : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SpecialRequest",
                table: "Bookings",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SpecialRequest",
                table: "Bookings");
        }
    }
}
