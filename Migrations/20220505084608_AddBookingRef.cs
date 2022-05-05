using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppointmentBookingService.Migrations
{
    public partial class AddBookingRef : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Reference",
                table: "Booking",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Reference",
                table: "Booking");
        }
    }
}
