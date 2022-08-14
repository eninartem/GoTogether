using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Places.Infrastructure.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GtLocations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Country = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    City = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GtLocations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GtPlaces",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Description = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    ImageUrl = table.Column<string>(type: "text", nullable: true),
                    LocationId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GtPlaces", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GtPlaces_GtLocations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "GtLocations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GtLocations_Id",
                table: "GtLocations",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GtPlaces_Id",
                table: "GtPlaces",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GtPlaces_LocationId",
                table: "GtPlaces",
                column: "LocationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GtPlaces");

            migrationBuilder.DropTable(
                name: "GtLocations");
        }
    }
}
