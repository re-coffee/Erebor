using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Erebor.Migrations
{
    public partial class v11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Regedit",
                table: "Servico",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Regedit",
                table: "Servico");
        }
    }
}
