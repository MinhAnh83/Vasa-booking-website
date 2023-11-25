using Microsoft.EntityFrameworkCore.Migrations;

namespace VasaHotel_main.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OwnerID",
                table: "Room");

            migrationBuilder.DropColumn(
                name: "StatusUser",
                table: "Room");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OwnerID",
                table: "Room",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "StatusUser",
                table: "Room",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
