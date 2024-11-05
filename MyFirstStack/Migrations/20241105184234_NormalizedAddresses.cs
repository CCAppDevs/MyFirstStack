using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyFirstStack.Migrations
{
    /// <inheritdoc />
    public partial class NormalizedAddresses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "People",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "Dealers",
                columns: table => new
                {
                    DealerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dealers", x => x.DealerId);
                });

            migrationBuilder.CreateTable(
                name: "PeopleAddresses",
                columns: table => new
                {
                    PeopleAddressesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PeopleId = table.Column<int>(type: "int", nullable: false),
                    AddressId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PeopleAddresses", x => x.PeopleAddressesId);
                    table.ForeignKey(
                        name: "FK_PeopleAddresses_People_PeopleId",
                        column: x => x.PeopleId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DealerAddresses",
                columns: table => new
                {
                    DealerAddressesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DealerId = table.Column<int>(type: "int", nullable: false),
                    AddressId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DealerAddresses", x => x.DealerAddressesId);
                    table.ForeignKey(
                        name: "FK_DealerAddresses_Dealers_DealerId",
                        column: x => x.DealerId,
                        principalTable: "Dealers",
                        principalColumn: "DealerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DealerAddresses_DealerId",
                table: "DealerAddresses",
                column: "DealerId");

            migrationBuilder.CreateIndex(
                name: "IX_PeopleAddresses_PeopleId",
                table: "PeopleAddresses",
                column: "PeopleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DealerAddresses");

            migrationBuilder.DropTable(
                name: "PeopleAddresses");

            migrationBuilder.DropTable(
                name: "Dealers");

            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "People");
        }
    }
}
