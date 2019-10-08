using Microsoft.EntityFrameworkCore.Migrations;

namespace QuickScaleAndIdentity.Migrations.QuickScaleDb
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Scales",
                columns: table => new
                {
                    ScaleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RootNote = table.Column<string>(maxLength: 10, nullable: true),
                    Mode = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scales", x => x.ScaleId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SavedFretBoards",
                columns: table => new
                {
                    SavedFretboardID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumberOfStrings = table.Column<int>(nullable: false),
                    NumberOfFrets = table.Column<int>(nullable: false),
                    FirstStringNote = table.Column<string>(nullable: true),
                    SecondStringNote = table.Column<string>(nullable: true),
                    ThirdStringNote = table.Column<string>(nullable: true),
                    FourthStringNote = table.Column<string>(nullable: true),
                    FifthStringNote = table.Column<string>(nullable: true),
                    SixthStringNote = table.Column<string>(nullable: true),
                    SeventhtringNote = table.Column<string>(nullable: true),
                    EighthStringNote = table.Column<string>(nullable: true),
                    NinthStringNote = table.Column<string>(nullable: true),
                    TenthStringNote = table.Column<string>(nullable: true),
                    UserID = table.Column<int>(nullable: true),
                    ScaleID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SavedFretBoards", x => x.SavedFretboardID);
                    table.ForeignKey(
                        name: "FK_SavedFretBoards_Scales_ScaleID",
                        column: x => x.ScaleID,
                        principalTable: "Scales",
                        principalColumn: "ScaleId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SavedFretBoards_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SavedFretBoards_ScaleID",
                table: "SavedFretBoards",
                column: "ScaleID");

            migrationBuilder.CreateIndex(
                name: "IX_SavedFretBoards_UserID",
                table: "SavedFretBoards",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SavedFretBoards");

            migrationBuilder.DropTable(
                name: "Scales");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
