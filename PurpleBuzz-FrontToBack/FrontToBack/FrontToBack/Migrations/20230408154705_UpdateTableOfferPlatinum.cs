using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FrontToBack.Migrations
{
    public partial class UpdateTableOfferPlatinum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Feature",
                table: "OfferStandarts",
                newName: "FeatureTheThird");

            migrationBuilder.RenameColumn(
                name: "Feature",
                table: "OfferPremiums",
                newName: "FeatureTheThird");

            migrationBuilder.RenameColumn(
                name: "Feature",
                table: "OfferPlatinums",
                newName: "FeatureTheThird");

            migrationBuilder.AddColumn<string>(
                name: "FeatureTheForuth",
                table: "OfferStandarts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FeatureTheFrist",
                table: "OfferStandarts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FeatureTheSecond",
                table: "OfferStandarts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FeatureTheForuth",
                table: "OfferPremiums",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FeatureTheFrist",
                table: "OfferPremiums",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FeatureTheSecond",
                table: "OfferPremiums",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FeatureTheFifth",
                table: "OfferPlatinums",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FeatureTheForuth",
                table: "OfferPlatinums",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FeatureTheFrist",
                table: "OfferPlatinums",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FeatureTheSecond",
                table: "OfferPlatinums",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FeatureTheForuth",
                table: "OfferStandarts");

            migrationBuilder.DropColumn(
                name: "FeatureTheFrist",
                table: "OfferStandarts");

            migrationBuilder.DropColumn(
                name: "FeatureTheSecond",
                table: "OfferStandarts");

            migrationBuilder.DropColumn(
                name: "FeatureTheForuth",
                table: "OfferPremiums");

            migrationBuilder.DropColumn(
                name: "FeatureTheFrist",
                table: "OfferPremiums");

            migrationBuilder.DropColumn(
                name: "FeatureTheSecond",
                table: "OfferPremiums");

            migrationBuilder.DropColumn(
                name: "FeatureTheFifth",
                table: "OfferPlatinums");

            migrationBuilder.DropColumn(
                name: "FeatureTheForuth",
                table: "OfferPlatinums");

            migrationBuilder.DropColumn(
                name: "FeatureTheFrist",
                table: "OfferPlatinums");

            migrationBuilder.DropColumn(
                name: "FeatureTheSecond",
                table: "OfferPlatinums");

            migrationBuilder.RenameColumn(
                name: "FeatureTheThird",
                table: "OfferStandarts",
                newName: "Feature");

            migrationBuilder.RenameColumn(
                name: "FeatureTheThird",
                table: "OfferPremiums",
                newName: "Feature");

            migrationBuilder.RenameColumn(
                name: "FeatureTheThird",
                table: "OfferPlatinums",
                newName: "Feature");
        }
    }
}
