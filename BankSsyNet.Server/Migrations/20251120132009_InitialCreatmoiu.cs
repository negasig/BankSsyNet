using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BankSsyNet.Server.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreatmoiu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LirstName",
                table: "Customer",
                newName: "FirstName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Customer",
                newName: "LirstName");
        }
    }
}
