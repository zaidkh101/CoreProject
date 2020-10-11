using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreProjectRemasterd.Migrations
{
    public partial class AddMCountryToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MCountry",
                table: "Products",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MCountry",
                table: "Products");
        }
    }
}
