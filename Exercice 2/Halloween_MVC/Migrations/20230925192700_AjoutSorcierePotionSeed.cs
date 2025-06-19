using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Halloween.Migrations
{
    public partial class AjoutSorcierePotionSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Sorcieres",
                columns: new[] { "Id", "Nom", "Origine" },
                values: new object[,]
                {
                    { 1, "Maléfique", "Belle au bois dormant" },
                    { 2, "Belagile", "Basque" },
                    { 3, "Morgane", "Roi Arthur" },
                    { 4, "Médée", "Grèce" },
                    { 5, "Taoueille", "Acadie" },
                    { 6, "Andor", "Acadie" },
                    { 7, "Merlin", "Roi Arthur" },
                    { 8, "Mariecomo", "Acadie" }
                });

            migrationBuilder.InsertData(
                table: "Potions",
                columns: new[] { "Id", "DateCreation", "Nom", "Sorciere_Id" },
                values: new object[,]
                {
                    { 1, new DateTime(1811, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Elixir cérébral de Barrufio", 1 },
                    { 2, new DateTime(1815, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Philtre d'apathie", 1 },
                    { 3, new DateTime(1817, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Potion de perception", 3 },
                    { 4, new DateTime(1634, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Potion Exstimulo", 4 },
                    { 5, new DateTime(1642, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Potion Exstimulo renforcée", 4 },
                    { 6, new DateTime(1732, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Potion Exstimulo puissante", 5 },
                    { 7, new DateTime(1721, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Potion de Soin", 6 },
                    { 8, new DateTime(1787, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Potion scintillante", 2 },
                    { 9, new DateTime(1634, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Potion d'Aiguise-Méninges", 7 },
                    { 10, new DateTime(1819, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Breuvage abondant", 3 },
                    { 11, new DateTime(1651, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Potion de Mémoire", 8 },
                    { 12, new DateTime(1842, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Potion revigorante forte", 2 },
                    { 13, new DateTime(1652, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Potion de l'Œil Vif", 8 },
                    { 14, new DateTime(1789, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Potion d'invisibilité", 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Potions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Potions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Potions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Potions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Potions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Potions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Potions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Potions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Potions",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Potions",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Potions",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Potions",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Potions",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Potions",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Sorcieres",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sorcieres",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sorcieres",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Sorcieres",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Sorcieres",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Sorcieres",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Sorcieres",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Sorcieres",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}
