using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SportsManagementSystem.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Competitors",
                columns: new[] { "CompetitorId", "ContactNo", "Country", "Description", "Dob", "Email", "Gender", "Name", "Photo", "Salutation", "Website" },
                values: new object[,]
                {
                    { 1, null, "Cambodia", null, new DateTime(1980, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "skajan@att.net", "Male", "Jani Hosea", null, "Mr", null },
                    { 28, null, "Olympics", null, new DateTime(1983, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "airship@gmail.com", "Female", "Georgetta Pelham", null, "Mrs", null },
                    { 27, null, "Olympics", null, new DateTime(1983, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "mcnihil@aol.com", "Male", "Kristel Ringer", null, "Miss", null },
                    { 26, null, "Olympics", null, new DateTime(1982, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "staffelb@comcast.net", "Female", "Marta Belle", null, "Mrs", null },
                    { 25, null, "French Southern Territories", null, new DateTime(1997, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "crandall@sbcglobal.net", "Female", "Helen Kerry", null, "Miss", null },
                    { 24, null, "Russia", null, new DateTime(1996, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "drewf@yahoo.ca", "Male", "Carroll Pogue", null, "Mrs", null },
                    { 23, null, "Norway", null, new DateTime(1994, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "juliano@icloud.com", "Male", "Janett Wenger", null, "Mrs", null },
                    { 22, null, "Saint Martin", null, new DateTime(1994, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "wildfire@yahoo.com", "Female", "Sasha Shufelt", null, "Mr", null },
                    { 21, null, "Bouvet Island", null, new DateTime(1994, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "tezbo@live.com", "Male", "Julie Wimbish", null, "Mrs", null },
                    { 20, null, "Greenland", null, new DateTime(1993, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "mgemmons@att.net", "Male", "Arvilla Tedrow", null, "Mrs", null },
                    { 19, null, "France", null, new DateTime(1992, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "retoh@gmail.com", "Female", "Susy Mullett", null, "Mr", null },
                    { 18, null, "Liechtenstein", null, new DateTime(1990, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "odlyzko@comcast.net", "Male", "Craig Kimpel", null, "Miss", null },
                    { 17, null, "Equatorial Guinea", null, new DateTime(1990, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "wojciech@optonline.net", "Male", "Mattie Tally", null, "Mrs", null },
                    { 16, null, "Kiribati", null, new DateTime(1989, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "petersen@mac.com", "Female", "Carita Schlegel", null, "Miss", null },
                    { 15, null, "Wallis and Futuna", null, new DateTime(1989, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "dkasak@outlook.com", "Male", "Kristine Guidry", null, "Mr", null },
                    { 14, null, "Christmas Island", null, new DateTime(1989, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "cliffordj@mac.com", "Male", "Dottie Hitchens", null, "Mrs", null },
                    { 13, null, "South Korea", null, new DateTime(1988, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "irving@optonline.net", "Female", "Lewis Hohl", null, "Mr", null },
                    { 12, null, "Australia", null, new DateTime(1986, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "bogjobber@yahoo.com", "Female", "Palmira Halbert", null, "Mrs", null },
                    { 11, null, "Sweden", null, new DateTime(1985, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "tromey@gmail.com", "Female", "Brandon Musgrove", null, "Mr", null },
                    { 10, null, "Solomon Islands", null, new DateTime(1984, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "hermanab@msn.com", "Male", "Shizue Theiss", null, "Mrs", null },
                    { 9, null, "Azerbaijan", null, new DateTime(1984, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "oracle@verizon.net", "Male", "Isela Spiegel", null, "Mr", null },
                    { 8, null, "Indonesia", null, new DateTime(1984, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "ninenine@msn.com", "Female", "Mike Pautz", null, "Mrs", null },
                    { 7, null, "Northern Mariana Islands", null, new DateTime(1983, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "hmbrand@att.net", "Male", "Chasity Wesolowski", null, "Mrs", null },
                    { 6, null, "Iceland", null, new DateTime(1982, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "juliano@yahoo.com", "Male", "Bernice Moorman", null, "Mrs", null },
                    { 5, null, "Western Sahara", null, new DateTime(1982, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "bflong@comcast.net", "Female", "Latisha Skerrett", null, "Mrs", null },
                    { 4, null, "Sri Lanka", null, new DateTime(1980, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "galbra@optonline.net", "Female", "Ashton Tackett", null, "Mr", null },
                    { 3, null, "Ukraine", null, new DateTime(1980, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "majordick@live.com", "Male", "Antione Yearta", null, "Miss", null },
                    { 2, null, "Guinea", null, new DateTime(1980, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "lukka@msn.com", "Female", "Petrina Bassi", null, "Mrs", null },
                    { 29, null, "Olympics", null, new DateTime(1996, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "shaffei@icloud.com", "Male", "Rosalinda Gorrell", null, "Miss", null },
                    { 30, null, "Olympics", null, new DateTime(1997, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "oechslin@gmail.com", "Male", "Tomasa Vendetti", null, "Miss", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 30);
        }
    }
}
