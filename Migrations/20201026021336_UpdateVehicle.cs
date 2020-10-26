using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CRUD_Blazor.Migrations
{
    public partial class UpdateVehicle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ManufacturingYear",
                table: "Vehicle",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "IconURL",
                value: "https://www.flaticon.com/svg/static/icons/svg/1085/1085961.svg");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "IconURL",
                value: "https://www.flaticon.com/svg/static/icons/svg/3662/3662796.svg");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                column: "IconURL",
                value: "https://www.flaticon.com/svg/static/icons/svg/3662/3662736.svg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ManufacturingYear",
                table: "Vehicle",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "IconURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "IconURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                column: "IconURL",
                value: "");
        }
    }
}
