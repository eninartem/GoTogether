using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Places.Infrastructure.Migrations
{
    public partial class temp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "GtLocations",
                columns: new[] { "Id", "City", "Country" },
                values: new object[,]
                {
                    { new Guid("4416b0d6-8ffe-4f29-a700-172e31081be6"), "Togliatty", "Russia" },
                    { new Guid("ad51f372-48a2-43f6-a5a8-5e6cf82d3033"), "Samara", "Russia" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GtLocations",
                keyColumn: "Id",
                keyValue: new Guid("4416b0d6-8ffe-4f29-a700-172e31081be6"));

            migrationBuilder.DeleteData(
                table: "GtLocations",
                keyColumn: "Id",
                keyValue: new Guid("ad51f372-48a2-43f6-a5a8-5e6cf82d3033"));
        }
    }
}
