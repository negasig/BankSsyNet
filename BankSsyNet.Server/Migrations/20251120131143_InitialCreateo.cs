using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BankSsyNet.Server.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreateo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "lastName",
                table: "Customer",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Customer",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "city",
                table: "Customer",
                newName: "City");

            migrationBuilder.RenameColumn(
                name: "balance",
                table: "Customer",
                newName: "Balance");

            migrationBuilder.RenameColumn(
                name: "firstName",
                table: "Customer",
                newName: "LirstName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Customer",
                newName: "lastName");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Customer",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "City",
                table: "Customer",
                newName: "city");

            migrationBuilder.RenameColumn(
                name: "Balance",
                table: "Customer",
                newName: "balance");

            migrationBuilder.RenameColumn(
                name: "LirstName",
                table: "Customer",
                newName: "firstName");
        }
    }
}
