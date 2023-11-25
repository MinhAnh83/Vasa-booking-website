using Microsoft.EntityFrameworkCore.Migrations;

namespace VasaHotel_main.Migrations
{
    public partial class updateimgage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Room");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Room",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
