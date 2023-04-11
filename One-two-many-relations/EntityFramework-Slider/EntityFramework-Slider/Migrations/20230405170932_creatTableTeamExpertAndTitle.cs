using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFramework_Slider.Migrations
{
    public partial class creatTableTeamExpertAndTitle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TitleId",
                table: "Advances",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Titles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripton = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoftDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Titles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TeamExperts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TitleId = table.Column<int>(type: "int", nullable: false),
                    SoftDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamExperts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeamExperts_Titles_TitleId",
                        column: x => x.TitleId,
                        principalTable: "Titles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Advances_TitleId",
                table: "Advances",
                column: "TitleId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamExperts_TitleId",
                table: "TeamExperts",
                column: "TitleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Advances_Titles_TitleId",
                table: "Advances",
                column: "TitleId",
                principalTable: "Titles",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Advances_Titles_TitleId",
                table: "Advances");

            migrationBuilder.DropTable(
                name: "TeamExperts");

            migrationBuilder.DropTable(
                name: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Advances_TitleId",
                table: "Advances");

            migrationBuilder.DropColumn(
                name: "TitleId",
                table: "Advances");
        }
    }
}
