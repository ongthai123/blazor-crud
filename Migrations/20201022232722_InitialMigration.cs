using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CRUD_Blazor.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    WeightMin = table.Column<int>(nullable: false),
                    WeightMax = table.Column<int>(nullable: false),
                    IconURL = table.Column<string>(nullable: true)
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
                    ManufacturingYear = table.Column<DateTime>(nullable: false),
                    Weight = table.Column<decimal>(type: "decimal(18, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicle", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "IconURL", "Name", "WeightMax", "WeightMin" },
                values: new object[] { 1, "", "Light", 500, 0 });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "IconURL", "Name", "WeightMax", "WeightMin" },
                values: new object[] { 2, "", "Medium", 2500, 500 });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "IconURL", "Name", "WeightMax", "WeightMin" },
                values: new object[] { 3, "", "Heavy", 999999, 2500 });
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
