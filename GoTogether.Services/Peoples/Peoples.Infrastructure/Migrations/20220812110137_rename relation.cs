using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Peoples.Infrastructure.Migrations
{
    public partial class renamerelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Profiles",
                table: "Profiles");

            migrationBuilder.RenameTable(
                name: "Profiles",
                newName: "GtProfiles");

            migrationBuilder.RenameIndex(
                name: "IX_Profiles_Id",
                table: "GtProfiles",
                newName: "IX_GtProfiles_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GtProfiles",
                table: "GtProfiles",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_GtProfiles",
                table: "GtProfiles");

            migrationBuilder.RenameTable(
                name: "GtProfiles",
                newName: "Profiles");

            migrationBuilder.RenameIndex(
                name: "IX_GtProfiles_Id",
                table: "Profiles",
                newName: "IX_Profiles_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Profiles",
                table: "Profiles",
                column: "Id");
        }
    }
}
