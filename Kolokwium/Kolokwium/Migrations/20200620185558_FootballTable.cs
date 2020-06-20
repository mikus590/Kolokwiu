using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Kolokwium.Migrations
{
    public partial class FootballTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Championships",
                columns: table => new
                {
                    IdChampionship = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OfficialName = table.Column<string>(nullable: true),
                    Year = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Championships", x => x.IdChampionship);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    IdPlayer = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.IdPlayer);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    IdTeam = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TeamName = table.Column<string>(nullable: true),
                    MaxAge = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.IdTeam);
                });

            migrationBuilder.CreateTable(
                name: "Championship_Teams",
                columns: table => new
                {
                    IdTeam = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdChampionship = table.Column<int>(nullable: false),
                    Score = table.Column<float>(nullable: false),
                    TeamIdTeam = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Championship_Teams", x => x.IdTeam);
                    table.ForeignKey(
                        name: "FK_Championship_Teams_Championships_IdChampionship",
                        column: x => x.IdChampionship,
                        principalTable: "Championships",
                        principalColumn: "IdChampionship",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Championship_Teams_Teams_TeamIdTeam",
                        column: x => x.TeamIdTeam,
                        principalTable: "Teams",
                        principalColumn: "IdTeam",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Player_Teams",
                columns: table => new
                {
                    IdPlayer = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdTeam = table.Column<int>(nullable: false),
                    NumOnShirt = table.Column<int>(nullable: false),
                    Comment = table.Column<string>(nullable: true),
                    PlayerIdPlayer = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Player_Teams", x => x.IdPlayer);
                    table.ForeignKey(
                        name: "FK_Player_Teams_Teams_IdTeam",
                        column: x => x.IdTeam,
                        principalTable: "Teams",
                        principalColumn: "IdTeam",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Player_Teams_Players_PlayerIdPlayer",
                        column: x => x.PlayerIdPlayer,
                        principalTable: "Players",
                        principalColumn: "IdPlayer",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Championship_Teams_IdChampionship",
                table: "Championship_Teams",
                column: "IdChampionship");

            migrationBuilder.CreateIndex(
                name: "IX_Championship_Teams_TeamIdTeam",
                table: "Championship_Teams",
                column: "TeamIdTeam");

            migrationBuilder.CreateIndex(
                name: "IX_Player_Teams_IdTeam",
                table: "Player_Teams",
                column: "IdTeam");

            migrationBuilder.CreateIndex(
                name: "IX_Player_Teams_PlayerIdPlayer",
                table: "Player_Teams",
                column: "PlayerIdPlayer");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Championship_Teams");

            migrationBuilder.DropTable(
                name: "Player_Teams");

            migrationBuilder.DropTable(
                name: "Championships");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "Players");
        }
    }
}
