using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TournamentMakerApi.Migrations
{
    public partial class changesportsCategorycolumnname : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tournaments_SportCategories_CategoryId",
                table: "Tournaments");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Tournaments",
                newName: "SportsCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Tournaments_CategoryId",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tournaments_SportCategories_SportsCategoryId",
                table: "Tournaments");

            migrationBuilder.RenameColumn(
                name: "SportsCategoryId",
                table: "Tournaments",
                newName: "CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Tournaments_SportsCategoryId",
                table: "Tournaments",
                newName: "IX_Tournaments_CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tournaments_SportCategories_CategoryId",
                table: "Tournaments",
                column: "CategoryId",
                principalTable: "SportCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
