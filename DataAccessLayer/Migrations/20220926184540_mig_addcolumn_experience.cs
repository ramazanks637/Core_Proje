using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_addcolumn_experience : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Experiences",
                newName: "WorkPlaceName");

            migrationBuilder.AddColumn<string>(
                name: "ExperienceName",
                table: "Experiences",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExperienceName",
                table: "Experiences");

            migrationBuilder.RenameColumn(
                name: "WorkPlaceName",
                table: "Experiences",
                newName: "Name");
        }
    }
}
