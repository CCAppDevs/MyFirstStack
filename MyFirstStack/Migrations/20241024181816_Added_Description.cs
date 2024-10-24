using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyFirstStack.Migrations
{
    /// <inheritdoc />
    public partial class Added_Description : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Car",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "toast");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Car");
        }
    }
}
