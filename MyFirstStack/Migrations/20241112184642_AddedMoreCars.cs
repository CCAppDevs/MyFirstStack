using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyFirstStack.Migrations
{
    /// <inheritdoc />
    public partial class AddedMoreCars : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Car",
                columns: new[] { "Id", "Color", "Description", "Make", "Model", "VIN", "Year" },
                values: new object[] { 3, "Red", "A Pickup", "Ford", "F150", "999555444", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Car",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
