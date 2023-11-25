using Microsoft.EntityFrameworkCore.Migrations;

namespace VasaHotel_main.Migrations
{
    public partial class removepassword : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "password",
                table: "Customer");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "password",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
