using Microsoft.EntityFrameworkCore.Migrations;

namespace SportsManagementSystem.Migrations
{
    public partial class CascadeDeleteForCompetitorGames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CompetitorGames",
                keyColumns: new[] { "CompetitorId", "GameId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "CompetitorGames",
                keyColumns: new[] { "CompetitorId", "GameId" },
                keyValues: new object[] { 7, 3 });

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
                keyValues: new object[] { 15, 1 });

            migrationBuilder.DeleteData(
                table: "CompetitorGames",
                keyColumns: new[] { "CompetitorId", "GameId" },
                keyValues: new object[] { 16, 3 });

            migrationBuilder.DeleteData(
                table: "CompetitorGames",
                keyColumns: new[] { "CompetitorId", "GameId" },
                keyValues: new object[] { 18, 3 });

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
                keyValues: new object[] { 23, 3 });

            migrationBuilder.DeleteData(
                table: "CompetitorGames",
                keyColumns: new[] { "CompetitorId", "GameId" },
                keyValues: new object[] { 24, 1 });

            migrationBuilder.DeleteData(
                table: "CompetitorGames",
                keyColumns: new[] { "CompetitorId", "GameId" },
                keyValues: new object[] { 26, 1 });

            migrationBuilder.DeleteData(
                table: "CompetitorGames",
                keyColumns: new[] { "CompetitorId", "GameId" },
                keyValues: new object[] { 29, 3 });

            migrationBuilder.InsertData(
                table: "CompetitorGames",
                columns: new[] { "CompetitorId", "GameId" },
                values: new object[,]
                {
                    { 4, 1 },
                    { 7, 1 },
                    { 12, 1 },
                    { 13, 1 },
                    { 15, 2 },
                    { 16, 1 },
                    { 18, 2 },
                    { 20, 2 },
                    { 21, 1 },
                    { 23, 1 },
                    { 24, 3 },
                    { 26, 2 },
                    { 29, 1 }
                });

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 1,
                column: "Salutation",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 3,
                column: "Salutation",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 4,
                column: "Salutation",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 5,
                column: "Salutation",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 6,
                column: "Salutation",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 7,
                column: "Salutation",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 8,
                column: "Salutation",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 9,
                column: "Salutation",
                value: 2);

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
                keyValue: 17,
                column: "Salutation",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 18,
                column: "Salutation",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 19,
                column: "Salutation",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 20,
                column: "Salutation",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 25,
                column: "Salutation",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 29,
                column: "Salutation",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 30,
                column: "Salutation",
                value: 2);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CompetitorGames",
                keyColumns: new[] { "CompetitorId", "GameId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "CompetitorGames",
                keyColumns: new[] { "CompetitorId", "GameId" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                table: "CompetitorGames",
                keyColumns: new[] { "CompetitorId", "GameId" },
                keyValues: new object[] { 12, 1 });

            migrationBuilder.DeleteData(
                table: "CompetitorGames",
                keyColumns: new[] { "CompetitorId", "GameId" },
                keyValues: new object[] { 13, 1 });

            migrationBuilder.DeleteData(
                table: "CompetitorGames",
                keyColumns: new[] { "CompetitorId", "GameId" },
                keyValues: new object[] { 15, 2 });

            migrationBuilder.DeleteData(
                table: "CompetitorGames",
                keyColumns: new[] { "CompetitorId", "GameId" },
                keyValues: new object[] { 16, 1 });

            migrationBuilder.DeleteData(
                table: "CompetitorGames",
                keyColumns: new[] { "CompetitorId", "GameId" },
                keyValues: new object[] { 18, 2 });

            migrationBuilder.DeleteData(
                table: "CompetitorGames",
                keyColumns: new[] { "CompetitorId", "GameId" },
                keyValues: new object[] { 20, 2 });

            migrationBuilder.DeleteData(
                table: "CompetitorGames",
                keyColumns: new[] { "CompetitorId", "GameId" },
                keyValues: new object[] { 21, 1 });

            migrationBuilder.DeleteData(
                table: "CompetitorGames",
                keyColumns: new[] { "CompetitorId", "GameId" },
                keyValues: new object[] { 23, 1 });

            migrationBuilder.DeleteData(
                table: "CompetitorGames",
                keyColumns: new[] { "CompetitorId", "GameId" },
                keyValues: new object[] { 24, 3 });

            migrationBuilder.DeleteData(
                table: "CompetitorGames",
                keyColumns: new[] { "CompetitorId", "GameId" },
                keyValues: new object[] { 26, 2 });

            migrationBuilder.DeleteData(
                table: "CompetitorGames",
                keyColumns: new[] { "CompetitorId", "GameId" },
                keyValues: new object[] { 29, 1 });

            migrationBuilder.InsertData(
                table: "CompetitorGames",
                columns: new[] { "CompetitorId", "GameId" },
                values: new object[,]
                {
                    { 4, 2 },
                    { 7, 3 },
                    { 12, 3 },
                    { 13, 3 },
                    { 15, 1 },
                    { 16, 3 },
                    { 18, 3 },
                    { 20, 3 },
                    { 21, 2 },
                    { 23, 3 },
                    { 24, 1 },
                    { 26, 1 },
                    { 29, 3 }
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
                keyValue: 3,
                column: "Salutation",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 4,
                column: "Salutation",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 5,
                column: "Salutation",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 6,
                column: "Salutation",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 7,
                column: "Salutation",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 8,
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
                keyValue: 19,
                column: "Salutation",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 20,
                column: "Salutation",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 25,
                column: "Salutation",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 29,
                column: "Salutation",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 30,
                column: "Salutation",
                value: 1);
        }
    }
}
