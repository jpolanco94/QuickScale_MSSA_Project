using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QuickScale.Migrations
{
    public partial class Intial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Scales",
                columns: table => new
                {
                    ScaleID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RootNote = table.Column<string>(nullable: true),
                    Mode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scales", x => x.ScaleID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Username = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "SavedFretboards",
                columns: table => new
                {
                    SavedFretboardID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
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
                    table.PrimaryKey("PK_SavedFretboards", x => x.SavedFretboardID);
                    table.ForeignKey(
                        name: "FK_SavedFretboards_Scales_ScaleID",
                        column: x => x.ScaleID,
                        principalTable: "Scales",
                        principalColumn: "ScaleID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SavedFretboards_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SavedFretboards_ScaleID",
                table: "SavedFretboards",
                column: "ScaleID");

            migrationBuilder.CreateIndex(
                name: "IX_SavedFretboards_UserID",
                table: "SavedFretboards",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SavedFretboards");

            migrationBuilder.DropTable(
                name: "Scales");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
