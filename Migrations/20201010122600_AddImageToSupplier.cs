using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreProjectRemasterd.Migrations
{
    public partial class AddImageToSupplier : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SupplierImage",
                table: "Suppliers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SupplierImage",
                table: "Suppliers");
        }
    }
}
