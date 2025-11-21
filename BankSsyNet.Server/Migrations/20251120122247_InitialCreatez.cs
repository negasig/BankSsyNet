using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BankSsyNet.Server.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreatez : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Customers",
                table: "Customers");

            migrationBuilder.RenameTable(
                name: "Customers",
                newName: "Customern");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customern",
                table: "Customern",
                column: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Customern",
                table: "Customern");

            migrationBuilder.RenameTable(
                name: "Customern",
                newName: "Customers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customers",
                table: "Customers",
                column: "id");
        }
    }
}
