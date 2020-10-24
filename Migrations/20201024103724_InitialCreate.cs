using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SportsManagementSystem.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Competitors",
                columns: table => new
                {
                    CompetitorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Salutation = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: false),
                    Dob = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: false),
                    Gender = table.Column<string>(nullable: false),
                    ContactNo = table.Column<int>(nullable: false),
                    Website = table.Column<string>(nullable: true),
                    Photo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Competitors", x => x.CompetitorId);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    GameId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    DurationInHours = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    RulesBooklet = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.GameId);
                });

            migrationBuilder.CreateTable(
                name: "CompetitorGames",
                columns: table => new
                {
                    GameId = table.Column<int>(nullable: false),
                    CompetitorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompetitorGames", x => new { x.CompetitorId, x.GameId });
                    table.ForeignKey(
                        name: "FK_CompetitorGames_Competitors_CompetitorId",
                        column: x => x.CompetitorId,
                        principalTable: "Competitors",
                        principalColumn: "CompetitorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompetitorGames_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "GameId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    EventId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FeatureEvent = table.Column<string>(nullable: true),
                    Venue = table.Column<string>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    StartTime = table.Column<DateTime>(nullable: false),
                    EndTime = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    WorldRecord = table.Column<string>(nullable: true),
                    GameId = table.Column<string>(nullable: false),
                    GameId1 = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.EventId);
                    table.ForeignKey(
                        name: "FK_Events_Games_GameId1",
                        column: x => x.GameId1,
                        principalTable: "Games",
                        principalColumn: "GameId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EventOutcomes",
                columns: table => new
                {
                    EventId = table.Column<string>(nullable: false),
                    CompetitorId = table.Column<string>(nullable: false),
                    EventId1 = table.Column<int>(nullable: true),
                    CompetitorId1 = table.Column<int>(nullable: true),
                    Position = table.Column<int>(nullable: false),
                    Medal = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventOutcomes", x => new { x.EventId, x.CompetitorId });
                    table.ForeignKey(
                        name: "FK_EventOutcomes_Competitors_CompetitorId1",
                        column: x => x.CompetitorId1,
                        principalTable: "Competitors",
                        principalColumn: "CompetitorId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EventOutcomes_Events_EventId1",
                        column: x => x.EventId1,
                        principalTable: "Events",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EventPhotos",
                columns: table => new
                {
                    PhotoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Photo = table.Column<string>(nullable: false),
                    PhotoTags = table.Column<string>(nullable: true),
                    EventId = table.Column<string>(nullable: true),
                    EventId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventPhotos", x => x.PhotoId);
                    table.ForeignKey(
                        name: "FK_EventPhotos_Events_EventId1",
                        column: x => x.EventId1,
                        principalTable: "Events",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CompetitorGames_GameId",
                table: "CompetitorGames",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_EventOutcomes_CompetitorId1",
                table: "EventOutcomes",
                column: "CompetitorId1");

            migrationBuilder.CreateIndex(
                name: "IX_EventOutcomes_EventId1",
                table: "EventOutcomes",
                column: "EventId1");

            migrationBuilder.CreateIndex(
                name: "IX_EventPhotos_EventId1",
                table: "EventPhotos",
                column: "EventId1");

            migrationBuilder.CreateIndex(
                name: "IX_Events_GameId1",
                table: "Events",
                column: "GameId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompetitorGames");

            migrationBuilder.DropTable(
                name: "EventOutcomes");

            migrationBuilder.DropTable(
                name: "EventPhotos");

            migrationBuilder.DropTable(
                name: "Competitors");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Games");
        }
    }
}
