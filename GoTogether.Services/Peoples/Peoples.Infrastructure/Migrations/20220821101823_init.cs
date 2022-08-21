using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Peoples.Infrastructure.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GtLocation",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Country = table.Column<string>(type: "text", nullable: false),
                    City = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GtLocation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GtProfiles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    AppUserId = table.Column<Guid>(type: "uuid", nullable: false),
                    NickName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    EMail = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    About = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    Age = table.Column<string>(type: "character varying(3)", maxLength: 3, nullable: true),
                    ImageUrl = table.Column<string>(type: "text", nullable: true),
                    LocationId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GtProfiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GtProfiles_GtLocation_LocationId",
                        column: x => x.LocationId,
                        principalTable: "GtLocation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GtProfiles_Id",
                table: "GtProfiles",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GtProfiles_LocationId",
                table: "GtProfiles",
                column: "LocationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GtProfiles");

            migrationBuilder.DropTable(
                name: "GtLocation");
        }
    }
}
