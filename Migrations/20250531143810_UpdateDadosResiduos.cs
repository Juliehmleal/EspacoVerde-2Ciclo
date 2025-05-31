using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EspacoVerde.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDadosResiduos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: 16);

            migrationBuilder.UpdateData(
                table: "Transacoes",
                keyColumn: "ID_Transacao",
                keyValue: 1,
                column: "Data_Transacao",
                value: new DateTime(2025, 5, 31, 11, 38, 9, 787, DateTimeKind.Local).AddTicks(8559));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Residuos",
                columns: new[] { "ID_Residuo", "ID_Localizacao", "ID_Usuario", "ImgUrl", "Nome", "PrecoKg", "Quantidade" },
                values: new object[,]
                {
                    { 8, 4, 1, "estanho.webp", "Estanho", 9.50m, 15m },
                    { 16, 4, 1, "tungstenio.webp", "Tungstênio", 30.00m, 3m }
                });

            migrationBuilder.UpdateData(
                table: "Transacoes",
                keyColumn: "ID_Transacao",
                keyValue: 1,
                column: "Data_Transacao",
                value: new DateTime(2025, 5, 29, 10, 22, 3, 861, DateTimeKind.Local).AddTicks(359));
        }
    }
}
