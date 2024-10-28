using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyFirstStack.Migrations
{
    /// <inheritdoc />
    public partial class AddedPhoneNumberToPeople : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "People",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "People");
        }
    }
}
