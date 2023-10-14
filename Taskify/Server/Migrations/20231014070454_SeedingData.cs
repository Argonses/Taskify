using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Taskify.Server.Migrations
{
    /// <inheritdoc />
    public partial class SeedingData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "AddedTime", "Category", "Description", "Status", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 14, 9, 4, 54, 647, DateTimeKind.Local).AddTicks(7323), 0, "Prepare slides and rehearse for the project presentation.", 0, "Complete Project Presentation" },
                    { 2, new DateTime(2023, 10, 13, 9, 4, 54, 647, DateTimeKind.Local).AddTicks(7326), 3, "Enjoy a 30-minute jog in the park.", 1, "Go for a Run" },
                    { 3, new DateTime(2023, 10, 12, 9, 4, 54, 647, DateTimeKind.Local).AddTicks(7335), 2, "Study and take notes on chapter 3 of the machine learning book.", 2, "Read Chapter 3 of 'Machine Learning Fundamentals'" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
