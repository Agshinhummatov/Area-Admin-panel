using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFramework_Slider.Migrations
{
    public partial class createTableAboutAndAdvance : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aboutes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoftDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aboutes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Advances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutId = table.Column<int>(type: "int", nullable: false),
                    SoftDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Advances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Advances_Aboutes_AboutId",
                        column: x => x.AboutId,
                        principalTable: "Aboutes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Advances_AboutId",
                table: "Advances",
                column: "AboutId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Advances");

            migrationBuilder.DropTable(
                name: "Aboutes");
        }
    }
}
