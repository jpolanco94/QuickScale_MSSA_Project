using Microsoft.EntityFrameworkCore.Migrations;

namespace QuickScaleAndIdentity.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SavedFretBoards",
                columns: table => new
                {
                    SavedFretboardID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstStringNote = table.Column<string>(nullable: true),
                    SecondStringNote = table.Column<string>(nullable: true),
                    ThirdStringNote = table.Column<string>(nullable: true),
                    FourthStringNote = table.Column<string>(nullable: true),
                    FifthStringNote = table.Column<string>(nullable: true),
                    SixthStringNote = table.Column<string>(nullable: true),
                    ID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SavedFretBoards", x => x.SavedFretboardID);
                    table.ForeignKey(
                        name: "FK_SavedFretBoards_AspNetUsers_ID",
                        column: x => x.ID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SavedFretBoards_ID",
                table: "SavedFretBoards",
                column: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SavedFretBoards");
        }
    }
}
