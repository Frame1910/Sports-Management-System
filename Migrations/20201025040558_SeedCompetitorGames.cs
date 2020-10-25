using Microsoft.EntityFrameworkCore.Migrations;

namespace SportsManagementSystem.Migrations
{
    public partial class SeedCompetitorGames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CompetitorGames",
                columns: new[] { "CompetitorId", "GameId" },
                values: new object[,]
                {
                    { 1, 3 },
                    { 29, 3 },
                    { 28, 1 },
                    { 27, 2 },
                    { 26, 1 },
                    { 25, 1 },
                    { 23, 3 },
                    { 22, 1 },
                    { 21, 2 },
                    { 20, 3 },
                    { 19, 1 },
                    { 18, 3 },
                    { 17, 2 },
                    { 16, 3 },
                    { 24, 1 },
                    { 14, 1 },
                    { 13, 3 },
                    { 12, 3 },
                    { 11, 1 },
                    { 10, 2 },
                    { 9, 3 },
                    { 8, 3 },
                    { 7, 3 },
                    { 15, 1 },
                    { 6, 1 },
                    { 5, 3 },
                    { 4, 2 },
                    { 3, 3 },
                    { 2, 1 }
                });

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 1,
                column: "Salutation",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 2,
                column: "Salutation",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 3,
                column: "Salutation",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 5,
                column: "Salutation",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 7,
                column: "Salutation",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 9,
                column: "Salutation",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 10,
                column: "Salutation",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 12,
                column: "Salutation",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 13,
                column: "Salutation",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 14,
                column: "Salutation",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 16,
                column: "Salutation",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 17,
                column: "Salutation",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 18,
                column: "Salutation",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 20,
                column: "Salutation",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 22,
                column: "Salutation",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 23,
                column: "Salutation",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 25,
                column: "Salutation",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 27,
                column: "Salutation",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 28,
                column: "Salutation",
                value: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CompetitorGames",
                keyColumns: new[] { "CompetitorId", "GameId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "CompetitorGames",
                keyColumns: new[] { "CompetitorId", "GameId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "CompetitorGames",
                keyColumns: new[] { "CompetitorId", "GameId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "CompetitorGames",
                keyColumns: new[] { "CompetitorId", "GameId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "CompetitorGames",
                keyColumns: new[] { "CompetitorId", "GameId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "CompetitorGames",
                keyColumns: new[] { "CompetitorId", "GameId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "CompetitorGames",
                keyColumns: new[] { "CompetitorId", "GameId" },
                keyValues: new object[] { 7, 3 });

            migrationBuilder.DeleteData(
                table: "CompetitorGames",
                keyColumns: new[] { "CompetitorId", "GameId" },
                keyValues: new object[] { 8, 3 });

            migrationBuilder.DeleteData(
                table: "CompetitorGames",
                keyColumns: new[] { "CompetitorId", "GameId" },
                keyValues: new object[] { 9, 3 });

            migrationBuilder.DeleteData(
                table: "CompetitorGames",
                keyColumns: new[] { "CompetitorId", "GameId" },
                keyValues: new object[] { 10, 2 });

            migrationBuilder.DeleteData(
                table: "CompetitorGames",
                keyColumns: new[] { "CompetitorId", "GameId" },
                keyValues: new object[] { 11, 1 });

            migrationBuilder.DeleteData(
                table: "CompetitorGames",
                keyColumns: new[] { "CompetitorId", "GameId" },
                keyValues: new object[] { 12, 3 });

            migrationBuilder.DeleteData(
                table: "CompetitorGames",
                keyColumns: new[] { "CompetitorId", "GameId" },
                keyValues: new object[] { 13, 3 });

            migrationBuilder.DeleteData(
                table: "CompetitorGames",
                keyColumns: new[] { "CompetitorId", "GameId" },
                keyValues: new object[] { 14, 1 });

            migrationBuilder.DeleteData(
                table: "CompetitorGames",
                keyColumns: new[] { "CompetitorId", "GameId" },
                keyValues: new object[] { 15, 1 });

            migrationBuilder.DeleteData(
                table: "CompetitorGames",
                keyColumns: new[] { "CompetitorId", "GameId" },
                keyValues: new object[] { 16, 3 });

            migrationBuilder.DeleteData(
                table: "CompetitorGames",
                keyColumns: new[] { "CompetitorId", "GameId" },
                keyValues: new object[] { 17, 2 });

            migrationBuilder.DeleteData(
                table: "CompetitorGames",
                keyColumns: new[] { "CompetitorId", "GameId" },
                keyValues: new object[] { 18, 3 });

            migrationBuilder.DeleteData(
                table: "CompetitorGames",
                keyColumns: new[] { "CompetitorId", "GameId" },
                keyValues: new object[] { 19, 1 });

            migrationBuilder.DeleteData(
                table: "CompetitorGames",
                keyColumns: new[] { "CompetitorId", "GameId" },
                keyValues: new object[] { 20, 3 });

            migrationBuilder.DeleteData(
                table: "CompetitorGames",
                keyColumns: new[] { "CompetitorId", "GameId" },
                keyValues: new object[] { 21, 2 });

            migrationBuilder.DeleteData(
                table: "CompetitorGames",
                keyColumns: new[] { "CompetitorId", "GameId" },
                keyValues: new object[] { 22, 1 });

            migrationBuilder.DeleteData(
                table: "CompetitorGames",
                keyColumns: new[] { "CompetitorId", "GameId" },
                keyValues: new object[] { 23, 3 });

            migrationBuilder.DeleteData(
                table: "CompetitorGames",
                keyColumns: new[] { "CompetitorId", "GameId" },
                keyValues: new object[] { 24, 1 });

            migrationBuilder.DeleteData(
                table: "CompetitorGames",
                keyColumns: new[] { "CompetitorId", "GameId" },
                keyValues: new object[] { 25, 1 });

            migrationBuilder.DeleteData(
                table: "CompetitorGames",
                keyColumns: new[] { "CompetitorId", "GameId" },
                keyValues: new object[] { 26, 1 });

            migrationBuilder.DeleteData(
                table: "CompetitorGames",
                keyColumns: new[] { "CompetitorId", "GameId" },
                keyValues: new object[] { 27, 2 });

            migrationBuilder.DeleteData(
                table: "CompetitorGames",
                keyColumns: new[] { "CompetitorId", "GameId" },
                keyValues: new object[] { 28, 1 });

            migrationBuilder.DeleteData(
                table: "CompetitorGames",
                keyColumns: new[] { "CompetitorId", "GameId" },
                keyValues: new object[] { 29, 3 });

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 1,
                column: "Salutation",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 2,
                column: "Salutation",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 3,
                column: "Salutation",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 5,
                column: "Salutation",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 7,
                column: "Salutation",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 9,
                column: "Salutation",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 10,
                column: "Salutation",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 12,
                column: "Salutation",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 13,
                column: "Salutation",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 14,
                column: "Salutation",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 16,
                column: "Salutation",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 17,
                column: "Salutation",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 18,
                column: "Salutation",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 20,
                column: "Salutation",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 22,
                column: "Salutation",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 23,
                column: "Salutation",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 25,
                column: "Salutation",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 27,
                column: "Salutation",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 28,
                column: "Salutation",
                value: 1);
        }
    }
}
