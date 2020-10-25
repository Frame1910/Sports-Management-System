using Microsoft.EntityFrameworkCore.Migrations;

namespace SportsManagementSystem.Migrations
{
    public partial class EventModelChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CompetitorGames",
                keyColumns: new[] { "CompetitorId", "GameId" },
                keyValues: new object[] { 2, 3 });

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
                keyValues: new object[] { 7, 3 });

            migrationBuilder.DeleteData(
                table: "CompetitorGames",
                keyColumns: new[] { "CompetitorId", "GameId" },
                keyValues: new object[] { 8, 3 });

            migrationBuilder.DeleteData(
                table: "CompetitorGames",
                keyColumns: new[] { "CompetitorId", "GameId" },
                keyValues: new object[] { 10, 1 });

            migrationBuilder.DeleteData(
                table: "CompetitorGames",
                keyColumns: new[] { "CompetitorId", "GameId" },
                keyValues: new object[] { 12, 2 });

            migrationBuilder.DeleteData(
                table: "CompetitorGames",
                keyColumns: new[] { "CompetitorId", "GameId" },
                keyValues: new object[] { 13, 1 });

            migrationBuilder.DeleteData(
                table: "CompetitorGames",
                keyColumns: new[] { "CompetitorId", "GameId" },
                keyValues: new object[] { 14, 1 });

            migrationBuilder.DeleteData(
                table: "CompetitorGames",
                keyColumns: new[] { "CompetitorId", "GameId" },
                keyValues: new object[] { 17, 3 });

            migrationBuilder.DeleteData(
                table: "CompetitorGames",
                keyColumns: new[] { "CompetitorId", "GameId" },
                keyValues: new object[] { 18, 1 });

            migrationBuilder.DeleteData(
                table: "CompetitorGames",
                keyColumns: new[] { "CompetitorId", "GameId" },
                keyValues: new object[] { 19, 2 });

            migrationBuilder.DeleteData(
                table: "CompetitorGames",
                keyColumns: new[] { "CompetitorId", "GameId" },
                keyValues: new object[] { 20, 2 });

            migrationBuilder.DeleteData(
                table: "CompetitorGames",
                keyColumns: new[] { "CompetitorId", "GameId" },
                keyValues: new object[] { 21, 3 });

            migrationBuilder.DeleteData(
                table: "CompetitorGames",
                keyColumns: new[] { "CompetitorId", "GameId" },
                keyValues: new object[] { 23, 2 });

            migrationBuilder.DeleteData(
                table: "CompetitorGames",
                keyColumns: new[] { "CompetitorId", "GameId" },
                keyValues: new object[] { 25, 3 });

            migrationBuilder.DeleteData(
                table: "CompetitorGames",
                keyColumns: new[] { "CompetitorId", "GameId" },
                keyValues: new object[] { 27, 2 });

            migrationBuilder.DeleteData(
                table: "CompetitorGames",
                keyColumns: new[] { "CompetitorId", "GameId" },
                keyValues: new object[] { 28, 2 });

            migrationBuilder.DeleteData(
                table: "CompetitorGames",
                keyColumns: new[] { "CompetitorId", "GameId" },
                keyValues: new object[] { 29, 3 });

            migrationBuilder.InsertData(
                table: "CompetitorGames",
                columns: new[] { "CompetitorId", "GameId" },
                values: new object[,]
                {
                    { 2, 1 },
                    { 28, 1 },
                    { 27, 3 },
                    { 25, 2 },
                    { 23, 1 },
                    { 21, 2 },
                    { 20, 1 },
                    { 19, 1 },
                    { 18, 2 },
                    { 29, 2 },
                    { 14, 2 },
                    { 13, 2 },
                    { 12, 3 },
                    { 10, 3 },
                    { 8, 1 },
                    { 7, 1 },
                    { 4, 1 },
                    { 3, 2 },
                    { 17, 1 }
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
                keyValue: 2,
                column: "Salutation",
                value: 2);

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
                value: 2);

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
                value: 0);

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 11,
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
                keyValue: 14,
                column: "Salutation",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 15,
                column: "Salutation",
                value: 0);

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
                value: 0);

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 19,
                column: "Salutation",
                value: 1);

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
                value: 0);

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 28,
                column: "Salutation",
                value: 0);

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
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "CompetitorGames",
                keyColumns: new[] { "CompetitorId", "GameId" },
                keyValues: new object[] { 3, 2 });

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
                keyValues: new object[] { 8, 1 });

            migrationBuilder.DeleteData(
                table: "CompetitorGames",
                keyColumns: new[] { "CompetitorId", "GameId" },
                keyValues: new object[] { 10, 3 });

            migrationBuilder.DeleteData(
                table: "CompetitorGames",
                keyColumns: new[] { "CompetitorId", "GameId" },
                keyValues: new object[] { 12, 3 });

            migrationBuilder.DeleteData(
                table: "CompetitorGames",
                keyColumns: new[] { "CompetitorId", "GameId" },
                keyValues: new object[] { 13, 2 });

            migrationBuilder.DeleteData(
                table: "CompetitorGames",
                keyColumns: new[] { "CompetitorId", "GameId" },
                keyValues: new object[] { 14, 2 });

            migrationBuilder.DeleteData(
                table: "CompetitorGames",
                keyColumns: new[] { "CompetitorId", "GameId" },
                keyValues: new object[] { 17, 1 });

            migrationBuilder.DeleteData(
                table: "CompetitorGames",
                keyColumns: new[] { "CompetitorId", "GameId" },
                keyValues: new object[] { 18, 2 });

            migrationBuilder.DeleteData(
                table: "CompetitorGames",
                keyColumns: new[] { "CompetitorId", "GameId" },
                keyValues: new object[] { 19, 1 });

            migrationBuilder.DeleteData(
                table: "CompetitorGames",
                keyColumns: new[] { "CompetitorId", "GameId" },
                keyValues: new object[] { 20, 1 });

            migrationBuilder.DeleteData(
                table: "CompetitorGames",
                keyColumns: new[] { "CompetitorId", "GameId" },
                keyValues: new object[] { 21, 2 });

            migrationBuilder.DeleteData(
                table: "CompetitorGames",
                keyColumns: new[] { "CompetitorId", "GameId" },
                keyValues: new object[] { 23, 1 });

            migrationBuilder.DeleteData(
                table: "CompetitorGames",
                keyColumns: new[] { "CompetitorId", "GameId" },
                keyValues: new object[] { 25, 2 });

            migrationBuilder.DeleteData(
                table: "CompetitorGames",
                keyColumns: new[] { "CompetitorId", "GameId" },
                keyValues: new object[] { 27, 3 });

            migrationBuilder.DeleteData(
                table: "CompetitorGames",
                keyColumns: new[] { "CompetitorId", "GameId" },
                keyValues: new object[] { 28, 1 });

            migrationBuilder.DeleteData(
                table: "CompetitorGames",
                keyColumns: new[] { "CompetitorId", "GameId" },
                keyValues: new object[] { 29, 2 });

            migrationBuilder.InsertData(
                table: "CompetitorGames",
                columns: new[] { "CompetitorId", "GameId" },
                values: new object[,]
                {
                    { 2, 3 },
                    { 28, 2 },
                    { 27, 2 },
                    { 25, 3 },
                    { 23, 2 },
                    { 21, 3 },
                    { 20, 2 },
                    { 19, 2 },
                    { 18, 1 },
                    { 29, 3 },
                    { 14, 1 },
                    { 13, 1 },
                    { 12, 2 },
                    { 10, 1 },
                    { 8, 3 },
                    { 7, 3 },
                    { 4, 2 },
                    { 3, 3 },
                    { 17, 3 }
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
                value: 1);

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 4,
                column: "Salutation",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 9,
                column: "Salutation",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 10,
                column: "Salutation",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 11,
                column: "Salutation",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 12,
                column: "Salutation",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 14,
                column: "Salutation",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 15,
                column: "Salutation",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 16,
                column: "Salutation",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 17,
                column: "Salutation",
                value: 1);

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
                keyValue: 22,
                column: "Salutation",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 23,
                column: "Salutation",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 28,
                column: "Salutation",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 29,
                column: "Salutation",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 30,
                column: "Salutation",
                value: 1);
        }
    }
}
