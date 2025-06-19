using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MonApp_MVC.Migrations
{
    /// <inheritdoc />
    public partial class ModifAnnotations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FicheOfficielleId",
                table: "Joueurs");

            migrationBuilder.CreateIndex(
                name: "IX_FicheOfficielles_JoueurId",
                table: "FicheOfficielles",
                column: "JoueurId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_FicheOfficielles_Joueurs_JoueurId",
                table: "FicheOfficielles",
                column: "JoueurId",
                principalTable: "Joueurs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FicheOfficielles_Joueurs_JoueurId",
                table: "FicheOfficielles");

            migrationBuilder.DropIndex(
                name: "IX_FicheOfficielles_JoueurId",
                table: "FicheOfficielles");

            migrationBuilder.AddColumn<int>(
                name: "FicheOfficielleId",
                table: "Joueurs",
                type: "int",
                nullable: true);
        }
    }
}
