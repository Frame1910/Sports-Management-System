using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SportsManagementSystem.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Competitors",
                columns: table => new
                {
                    CompetitorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Salutation = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: false),
                    Dob = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: false),
                    Gender = table.Column<string>(nullable: false),
                    ContactNo = table.Column<string>(nullable: true),
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
                    CompetitorId = table.Column<int>(nullable: false),
                    GameId = table.Column<int>(nullable: false)
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
                    GameId = table.Column<int>(nullable: false),
                    FeatureEvent = table.Column<string>(nullable: true),
                    Venue = table.Column<string>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    StartTime = table.Column<DateTime>(nullable: false),
                    EndTime = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    WorldRecord = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.EventId);
                    table.ForeignKey(
                        name: "FK_Events_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "GameId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EventOutcomes",
                columns: table => new
                {
                    EventId = table.Column<int>(nullable: false),
                    CompetitorId = table.Column<int>(nullable: false),
                    Position = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventOutcomes", x => new { x.EventId, x.CompetitorId });
                    table.ForeignKey(
                        name: "FK_EventOutcomes_Competitors_CompetitorId",
                        column: x => x.CompetitorId,
                        principalTable: "Competitors",
                        principalColumn: "CompetitorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventOutcomes_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EventPhotos",
                columns: table => new
                {
                    PhotoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Photo = table.Column<string>(nullable: false),
                    PhotoTags = table.Column<string>(nullable: true),
                    EventId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventPhotos", x => x.PhotoId);
                    table.ForeignKey(
                        name: "FK_EventPhotos_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Competitors",
                columns: new[] { "CompetitorId", "ContactNo", "Country", "Description", "Dob", "Email", "Gender", "Name", "Photo", "Salutation", "Website" },
                values: new object[,]
                {
                    { 1, null, "Cambodia", null, new DateTime(1980, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "skajan@att.net", "Male", "Jani Hosea", null, 0, null },
                    { 30, null, "Olympics", null, new DateTime(1997, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "oechslin@gmail.com", "Male", "Tomasa Vendetti", null, 1, null },
                    { 29, null, "Olympics", null, new DateTime(1996, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "shaffei@icloud.com", "Male", "Rosalinda Gorrell", null, 2, null },
                    { 28, null, "Olympics", null, new DateTime(1983, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "airship@gmail.com", "Female", "Georgetta Pelham", null, 1, null },
                    { 27, null, "Olympics", null, new DateTime(1983, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "mcnihil@aol.com", "Male", "Kristel Ringer", null, 1, null },
                    { 26, null, "Olympics", null, new DateTime(1982, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "staffelb@comcast.net", "Female", "Marta Belle", null, 1, null },
                    { 25, null, "French Southern Territories", null, new DateTime(1997, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "crandall@sbcglobal.net", "Female", "Helen Kerry", null, 1, null },
                    { 24, null, "Russia", null, new DateTime(1996, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "drewf@yahoo.ca", "Male", "Carroll Pogue", null, 2, null },
                    { 23, null, "Norway", null, new DateTime(1994, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "juliano@icloud.com", "Male", "Janett Wenger", null, 2, null },
                    { 22, null, "Saint Martin", null, new DateTime(1994, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "wildfire@yahoo.com", "Female", "Sasha Shufelt", null, 2, null },
                    { 21, null, "Bouvet Island", null, new DateTime(1994, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "tezbo@live.com", "Male", "Julie Wimbish", null, 2, null },
                    { 20, null, "Greenland", null, new DateTime(1993, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "mgemmons@att.net", "Male", "Arvilla Tedrow", null, 1, null },
                    { 19, null, "France", null, new DateTime(1992, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "retoh@gmail.com", "Female", "Susy Mullett", null, 2, null },
                    { 18, null, "Liechtenstein", null, new DateTime(1990, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "odlyzko@comcast.net", "Male", "Craig Kimpel", null, 1, null },
                    { 16, null, "Kiribati", null, new DateTime(1989, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "petersen@mac.com", "Female", "Carita Schlegel", null, 1, null },
                    { 17, null, "Equatorial Guinea", null, new DateTime(1990, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "wojciech@optonline.net", "Male", "Mattie Tally", null, 1, null },
                    { 7, null, "Northern Mariana Islands", null, new DateTime(1983, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "hmbrand@att.net", "Male", "Chasity Wesolowski", null, 0, null },
                    { 14, null, "Christmas Island", null, new DateTime(1989, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "cliffordj@mac.com", "Male", "Dottie Hitchens", null, 1, null },
                    { 13, null, "South Korea", null, new DateTime(1988, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "irving@optonline.net", "Female", "Lewis Hohl", null, 0, null },
                    { 12, null, "Australia", null, new DateTime(1986, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "bogjobber@yahoo.com", "Female", "Palmira Halbert", null, 1, null },
                    { 11, null, "Sweden", null, new DateTime(1985, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "tromey@gmail.com", "Female", "Brandon Musgrove", null, 0, null },
                    { 10, null, "Solomon Islands", null, new DateTime(1984, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "hermanab@msn.com", "Male", "Shizue Theiss", null, 2, null },
                    { 9, null, "Azerbaijan", null, new DateTime(1984, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "oracle@verizon.net", "Male", "Isela Spiegel", null, 2, null },
                    { 8, null, "Indonesia", null, new DateTime(1984, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "ninenine@msn.com", "Female", "Mike Pautz", null, 1, null },
                    { 15, null, "Wallis and Futuna", null, new DateTime(1989, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "dkasak@outlook.com", "Male", "Kristine Guidry", null, 1, null },
                    { 6, null, "Iceland", null, new DateTime(1982, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "juliano@yahoo.com", "Male", "Bernice Moorman", null, 0, null },
                    { 5, null, "Western Sahara", null, new DateTime(1982, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "bflong@comcast.net", "Female", "Latisha Skerrett", null, 2, null },
                    { 4, null, "Sri Lanka", null, new DateTime(1980, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "galbra@optonline.net", "Female", "Ashton Tackett", null, 0, null },
                    { 3, null, "Ukraine", null, new DateTime(1980, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "majordick@live.com", "Male", "Antione Yearta", null, 1, null },
                    { 2, null, "Guinea", null, new DateTime(1980, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "lukka@msn.com", "Female", "Petrina Bassi", null, 1, null }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameId", "Code", "Description", "DurationInHours", "Name", "RulesBooklet" },
                values: new object[,]
                {
                    { 2, "CYC1234", "Competitors Cycle around a track", 2, "Cycling", "/Rules/CYC1234.pdf" },
                    { 1, "RUN1234", "Competitors run around a track ", 4, "Running", "/Rules/RUN1234.pdf" },
                    { 3, "SWI1234", "Competitors do laps in a pool", 1, "Swimming", "/Rules/SWI1234.pdf" }
                });

            migrationBuilder.InsertData(
                table: "CompetitorGames",
                columns: new[] { "CompetitorId", "GameId" },
                values: new object[,]
                {
                    { 9, 1 },
                    { 22, 3 },
                    { 21, 3 },
                    { 17, 3 },
                    { 11, 3 },
                    { 8, 3 },
                    { 7, 3 },
                    { 6, 3 },
                    { 5, 3 },
                    { 3, 3 },
                    { 2, 3 },
                    { 28, 2 },
                    { 27, 2 },
                    { 25, 3 },
                    { 23, 2 },
                    { 19, 2 },
                    { 12, 2 },
                    { 4, 2 },
                    { 1, 2 },
                    { 26, 1 },
                    { 24, 1 },
                    { 18, 1 },
                    { 16, 1 },
                    { 15, 1 },
                    { 14, 1 },
                    { 13, 1 },
                    { 10, 1 },
                    { 20, 2 },
                    { 29, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CompetitorGames_GameId",
                table: "CompetitorGames",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_EventOutcomes_CompetitorId",
                table: "EventOutcomes",
                column: "CompetitorId");

            migrationBuilder.CreateIndex(
                name: "IX_EventPhotos_EventId",
                table: "EventPhotos",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_GameId",
                table: "Events",
                column: "GameId");
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
