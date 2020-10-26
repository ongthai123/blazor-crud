using Microsoft.EntityFrameworkCore.Migrations;

namespace CRUD_Blazor.Migrations
{
    public partial class NewMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    MinWeight = table.Column<int>(nullable: false),
                    MaxWeight = table.Column<int>(nullable: false),
                    IconURL = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vehicle",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Owner = table.Column<string>(nullable: false),
                    Manufacturer = table.Column<int>(nullable: false),
                    ManufacturingYear = table.Column<string>(nullable: false),
                    Weight = table.Column<decimal>(type: "decimal(18, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicle", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "IconURL", "MaxWeight", "MinWeight", "Name" },
                values: new object[] { 1, "https://www.flaticon.com/svg/static/icons/svg/1085/1085961.svg", 500, 0, "Light" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "IconURL", "MaxWeight", "MinWeight", "Name" },
                values: new object[] { 2, "https://www.flaticon.com/svg/static/icons/svg/3662/3662796.svg", 2500, 500, "Medium" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "IconURL", "MaxWeight", "MinWeight", "Name" },
                values: new object[] { 3, "https://www.flaticon.com/svg/static/icons/svg/3662/3662736.svg", 999999, 2500, "Heavy" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Vehicle");
        }
    }
}
