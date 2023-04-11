using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FrontToBack.Migrations
{
    public partial class CreatTableSofDelete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "SoftDelete",
                table: "Works",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "SoftDelete",
                table: "WorkImages",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "SoftDelete",
                table: "Sliders",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "SoftDelete",
                table: "InfoServices",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "SoftDelete",
                table: "Categories",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SoftDelete",
                table: "Works");

            migrationBuilder.DropColumn(
                name: "SoftDelete",
                table: "WorkImages");

            migrationBuilder.DropColumn(
                name: "SoftDelete",
                table: "Sliders");

            migrationBuilder.DropColumn(
                name: "SoftDelete",
                table: "InfoServices");

            migrationBuilder.DropColumn(
                name: "SoftDelete",
                table: "Categories");
        }
    }
}
