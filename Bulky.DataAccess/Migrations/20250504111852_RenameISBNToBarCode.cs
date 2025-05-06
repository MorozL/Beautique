using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Beautique.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class RenameISBNToBarCode : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ISBN",
                table: "Products", // Замініть "Products" на назву вашої таблиці
                newName: "BarCode");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BarCode",
                table: "Products",
                newName: "ISBN");
        }
    }
}
