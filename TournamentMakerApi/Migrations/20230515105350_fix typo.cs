using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TournamentMakerApi.Migrations
{
    public partial class fixtypo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tournaments_SportCategories_SportsCategoryId",
                table: "Tournaments");

            migrationBuilder.RenameColumn(
                name: "SportsCategoryId",
                table: "Tournaments",
                newName: "SportCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Tournaments_SportsCategoryId",
                table: "Tournaments",
                newName: "IX_Tournaments_SportCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tournaments_SportCategories_SportCategoryId",
                table: "Tournaments",
                column: "SportCategoryId",
                principalTable: "SportCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tournaments_SportCategories_SportCategoryId",
                table: "Tournaments");

            migrationBuilder.RenameColumn(
                name: "SportCategoryId",
                table: "Tournaments",
                newName: "SportsCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Tournaments_SportCategoryId",
                table: "Tournaments",
                newName: "IX_Tournaments_SportsCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tournaments_SportCategories_SportsCategoryId",
                table: "Tournaments",
                column: "SportsCategoryId",
                principalTable: "SportCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
