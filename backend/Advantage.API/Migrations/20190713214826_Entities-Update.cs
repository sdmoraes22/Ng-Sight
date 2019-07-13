using Microsoft.EntityFrameworkCore.Migrations;

namespace Advantage.API.Migrations
{
    public partial class EntitiesUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OrderTotal",
                table: "Orders",
                newName: "Total");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Total",
                table: "Orders",
                newName: "OrderTotal");
        }
    }
}
