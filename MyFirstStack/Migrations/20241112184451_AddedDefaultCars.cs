using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyFirstStack.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultCars : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Car",
                columns: new[] { "Id", "Color", "Description", "Make", "Model", "VIN", "Year" },
                values: new object[,]
                {
                    { 1, "Black", "Just a little black honda accord", "Honda", "Accord", "123456", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Black", "A Nice Luxury Car", "Accura", "Legend", "223456", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PeopleAddress_AddressId",
                table: "PeopleAddress",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_DealerAddress_AddressId",
                table: "DealerAddress",
                column: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_DealerAddress_Address_AddressId",
                table: "DealerAddress",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "AddressId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PeopleAddress_Address_AddressId",
                table: "PeopleAddress",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "AddressId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DealerAddress_Address_AddressId",
                table: "DealerAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_PeopleAddress_Address_AddressId",
                table: "PeopleAddress");

            migrationBuilder.DropIndex(
                name: "IX_PeopleAddress_AddressId",
                table: "PeopleAddress");

            migrationBuilder.DropIndex(
                name: "IX_DealerAddress_AddressId",
                table: "DealerAddress");

            migrationBuilder.DeleteData(
                table: "Car",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Car",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
