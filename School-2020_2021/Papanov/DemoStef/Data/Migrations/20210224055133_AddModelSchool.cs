using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoStef.Data.Migrations
{
    public partial class AddModelSchool : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "School",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "School",
                table: "AspNetUsers");
        }
    }
}
