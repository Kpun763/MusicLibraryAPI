using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MusicLibraryAPI.Migrations
{
    /// <inheritdoc />
    public partial class MusicLibrary : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MusicLibraries",
                columns: new[] { "Id", "Album", "Artist", "Genre", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 1, "Dark Lane Demo Tapes", "Drake", "Hip-Hop", new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chicago Freestyle" },
                    { 2, "Dark Lane Demo Tapes", "Drake", "Hip-Hop", new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Time Flies" },
                    { 3, "If You're Reading This It's Too Late", "Drake", "Hip-Hop", new DateTime(2015, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Madonna" },
                    { 4, "Adjustments - Single", "Mad Keys", "Hip-Hop", new DateTime(2022, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adjustments" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MusicLibraries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MusicLibraries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MusicLibraries",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MusicLibraries",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
