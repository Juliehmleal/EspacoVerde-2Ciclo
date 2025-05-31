using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EspacoVerde.Migrations
{
    /// <inheritdoc />
    public partial class PopulandoMateriais : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ID_Localizacao",
                table: "Residuos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Localizacoes",
                columns: table => new
                {
                    ID_Localizacao = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Localizacoes", x => x.ID_Localizacao);
                });

            migrationBuilder.InsertData(
                table: "Localizacoes",
                columns: new[] { "ID_Localizacao", "Cidade", "Estado" },
                values: new object[,]
                {
                    { 1, "Araraquara", "SP" },
                    { 2, "Matão", "SP" },
                    { 3, "São Carlos", "SP" },
                    { 4, "Ribeirão Preto", "SP" }
                });

            migrationBuilder.UpdateData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: 1,
                columns: new[] { "ID_Localizacao", "ImgUrl" },
                values: new object[] { 1, "aco_inox.webp" });

            migrationBuilder.UpdateData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: 2,
                columns: new[] { "ID_Localizacao", "ImgUrl" },
                values: new object[] { 2, "ferro_fundido.webp" });

            migrationBuilder.UpdateData(
                table: "Transacoes",
                keyColumn: "ID_Transacao",
                keyValue: 1,
                column: "Data_Transacao",
                value: new DateTime(2025, 5, 28, 20, 43, 59, 97, DateTimeKind.Local).AddTicks(6089));

            migrationBuilder.InsertData(
                table: "Residuos",
                columns: new[] { "ID_Residuo", "ID_Localizacao", "ID_Usuario", "ImgUrl", "Nome", "Quantidade" },
                values: new object[,]
                {
                    { 3, 3, 1, "aluminio.webp", "Alumínio", 75m },
                    { 4, 4, 1, "cobre.webp", "Cobre", 30m },
                    { 5, 1, 1, "latao.webp", "Latão", 60m },
                    { 6, 2, 1, "zinco.webp", "Zinco", 40m },
                    { 7, 3, 1, "chumbo.webp", "Chumbo", 25m },
                    { 8, 4, 1, "estanho.webp", "Estanho", 15m },
                    { 9, 1, 1, "niquel.webp", "Níquel", 10m },
                    { 10, 2, 1, "titanio.webp", "Titânio", 5m },
                    { 11, 3, 1, "bronze.webp", "Bronze", 12m },
                    { 12, 4, 1, "aco_carbono.webp", "Aço Carbono", 22m },
                    { 13, 1, 1, "magnesio.webp", "Magnésio", 18m },
                    { 14, 2, 1, "cromo.webp", "Cromo", 16m },
                    { 15, 3, 1, "manganes.webp", "Manganês", 20m },
                    { 16, 4, 1, "tungstenio.webp", "Tungstênio", 3m },
                    { 17, 1, 1, "molibdenio.webp", "Molibdênio", 2m },
                    { 18, 2, 1, "vanadio.webp", "Vanádio", 7m },
                    { 19, 3, 1, "aco_inox.webp", "Aço Inox", 15m },
                    { 20, 4, 1, "aluminio.webp", "Alumínio", 50m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Residuos_ID_Localizacao",
                table: "Residuos",
                column: "ID_Localizacao");

            migrationBuilder.AddForeignKey(
                name: "FK_Residuos_Localizacoes_ID_Localizacao",
                table: "Residuos",
                column: "ID_Localizacao",
                principalTable: "Localizacoes",
                principalColumn: "ID_Localizacao",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Residuos_Localizacoes_ID_Localizacao",
                table: "Residuos");

            migrationBuilder.DropTable(
                name: "Localizacoes");

            migrationBuilder.DropIndex(
                name: "IX_Residuos_ID_Localizacao",
                table: "Residuos");

            migrationBuilder.DeleteData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: 20);

            migrationBuilder.DropColumn(
                name: "ID_Localizacao",
                table: "Residuos");

            migrationBuilder.UpdateData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: 1,
                column: "ImgUrl",
                value: "aco_Inox.jpeg");

            migrationBuilder.UpdateData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: 2,
                column: "ImgUrl",
                value: "Ferro_Fundido.jpeg");

            migrationBuilder.UpdateData(
                table: "Transacoes",
                keyColumn: "ID_Transacao",
                keyValue: 1,
                column: "Data_Transacao",
                value: new DateTime(2025, 5, 28, 10, 23, 9, 596, DateTimeKind.Local).AddTicks(1976));
        }
    }
}
