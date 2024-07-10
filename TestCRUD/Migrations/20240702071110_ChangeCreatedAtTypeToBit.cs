using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestCRUD.Migrations
{
    /// <inheritdoc />
    public partial class ChangeCreatedAtTypeToBit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Persons");

            migrationBuilder.AddColumn<bool>(
                name: "CreatedAt",
                table: "Persons",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Persons");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Persons",
                type: "datetime2",
                nullable: false);
        }

    }
}
