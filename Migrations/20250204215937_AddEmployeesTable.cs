using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeManagementAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddEmployeesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SalaryOrPay",
                table: "Workers");

            migrationBuilder.AddColumn<decimal>(
                name: "AnnualSalary",
                table: "Workers",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Workers",
                type: "nvarchar(13)",
                maxLength: 13,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Manager_AnnualSalary",
                table: "Workers",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PayPerHour",
                table: "Workers",
                type: "decimal(18,2)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AnnualSalary",
                table: "Workers");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Workers");

            migrationBuilder.DropColumn(
                name: "Manager_AnnualSalary",
                table: "Workers");

            migrationBuilder.DropColumn(
                name: "PayPerHour",
                table: "Workers");

            migrationBuilder.AddColumn<decimal>(
                name: "SalaryOrPay",
                table: "Workers",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
