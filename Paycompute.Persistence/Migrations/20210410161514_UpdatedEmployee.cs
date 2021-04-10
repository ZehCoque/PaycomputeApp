using Microsoft.EntityFrameworkCore.Migrations;

namespace Paycompute.Persistence.Migrations
{
    public partial class UpdatedEmployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Fullname",
                table: "Employees",
                newName: "FullName");

            migrationBuilder.RenameColumn(
                name: "NationalIsuranceNo",
                table: "Employees",
                newName: "NationalInsuranceNo");

            migrationBuilder.RenameColumn(
                name: "DataJoined",
                table: "Employees",
                newName: "DateJoined");

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Employees",
                newName: "Fullname");

            migrationBuilder.RenameColumn(
                name: "NationalInsuranceNo",
                table: "Employees",
                newName: "NationalIsuranceNo");

            migrationBuilder.RenameColumn(
                name: "DateJoined",
                table: "Employees",
                newName: "DataJoined");
        }
    }
}
