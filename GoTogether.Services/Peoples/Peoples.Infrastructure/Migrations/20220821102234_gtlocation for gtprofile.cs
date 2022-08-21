using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Peoples.Infrastructure.Migrations
{
    public partial class gtlocationforgtprofile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GtProfiles_GtLocation_LocationId",
                table: "GtProfiles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GtLocation",
                table: "GtLocation");

            migrationBuilder.RenameTable(
                name: "GtLocation",
                newName: "GtLocations");

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "GtLocations",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "GtLocations",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GtLocations",
                table: "GtLocations",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_GtLocations_Id",
                table: "GtLocations",
                column: "Id",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_GtProfiles_GtLocations_LocationId",
                table: "GtProfiles",
                column: "LocationId",
                principalTable: "GtLocations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GtProfiles_GtLocations_LocationId",
                table: "GtProfiles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GtLocations",
                table: "GtLocations");

            migrationBuilder.DropIndex(
                name: "IX_GtLocations_Id",
                table: "GtLocations");

            migrationBuilder.RenameTable(
                name: "GtLocations",
                newName: "GtLocation");

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "GtLocation",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "GtLocation",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AddPrimaryKey(
                name: "PK_GtLocation",
                table: "GtLocation",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GtProfiles_GtLocation_LocationId",
                table: "GtProfiles",
                column: "LocationId",
                principalTable: "GtLocation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
