using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreTest.Migrations
{
    /// <inheritdoc />
    public partial class Employee_ParentChild_Relation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Employees_ReportsToNavigationId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_ReportsToNavigationId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "ReportsToNavigationId",
                table: "Employees");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_ReportsTo",
                table: "Employees",
                column: "ReportsTo");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Employees_ReportsTo",
                table: "Employees",
                column: "ReportsTo",
                principalTable: "Employees",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Employees_ReportsTo",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_ReportsTo",
                table: "Employees");

            migrationBuilder.AddColumn<int>(
                name: "ReportsToNavigationId",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_ReportsToNavigationId",
                table: "Employees",
                column: "ReportsToNavigationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Employees_ReportsToNavigationId",
                table: "Employees",
                column: "ReportsToNavigationId",
                principalTable: "Employees",
                principalColumn: "Id");
        }
    }
}
