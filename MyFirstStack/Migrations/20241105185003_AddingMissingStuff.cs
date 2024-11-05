using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyFirstStack.Migrations
{
    /// <inheritdoc />
    public partial class AddingMissingStuff : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DealerAddresses_Dealers_DealerId",
                table: "DealerAddresses");

            migrationBuilder.DropForeignKey(
                name: "FK_PeopleAddresses_People_PeopleId",
                table: "PeopleAddresses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PeopleAddresses",
                table: "PeopleAddresses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DealerAddresses",
                table: "DealerAddresses");

            migrationBuilder.RenameTable(
                name: "PeopleAddresses",
                newName: "PeopleAddress");

            migrationBuilder.RenameTable(
                name: "DealerAddresses",
                newName: "DealerAddress");

            migrationBuilder.RenameIndex(
                name: "IX_PeopleAddresses_PeopleId",
                table: "PeopleAddress",
                newName: "IX_PeopleAddress_PeopleId");

            migrationBuilder.RenameIndex(
                name: "IX_DealerAddresses_DealerId",
                table: "DealerAddress",
                newName: "IX_DealerAddress_DealerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PeopleAddress",
                table: "PeopleAddress",
                column: "PeopleAddressesId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DealerAddress",
                table: "DealerAddress",
                column: "DealerAddressesId");

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    AddressId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.AddressId);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_DealerAddress_Dealers_DealerId",
                table: "DealerAddress",
                column: "DealerId",
                principalTable: "Dealers",
                principalColumn: "DealerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PeopleAddress_People_PeopleId",
                table: "PeopleAddress",
                column: "PeopleId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DealerAddress_Dealers_DealerId",
                table: "DealerAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_PeopleAddress_People_PeopleId",
                table: "PeopleAddress");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PeopleAddress",
                table: "PeopleAddress");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DealerAddress",
                table: "DealerAddress");

            migrationBuilder.RenameTable(
                name: "PeopleAddress",
                newName: "PeopleAddresses");

            migrationBuilder.RenameTable(
                name: "DealerAddress",
                newName: "DealerAddresses");

            migrationBuilder.RenameIndex(
                name: "IX_PeopleAddress_PeopleId",
                table: "PeopleAddresses",
                newName: "IX_PeopleAddresses_PeopleId");

            migrationBuilder.RenameIndex(
                name: "IX_DealerAddress_DealerId",
                table: "DealerAddresses",
                newName: "IX_DealerAddresses_DealerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PeopleAddresses",
                table: "PeopleAddresses",
                column: "PeopleAddressesId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DealerAddresses",
                table: "DealerAddresses",
                column: "DealerAddressesId");

            migrationBuilder.AddForeignKey(
                name: "FK_DealerAddresses_Dealers_DealerId",
                table: "DealerAddresses",
                column: "DealerId",
                principalTable: "Dealers",
                principalColumn: "DealerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PeopleAddresses_People_PeopleId",
                table: "PeopleAddresses",
                column: "PeopleId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
