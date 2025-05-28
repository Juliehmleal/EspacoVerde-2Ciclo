using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EspacoVerde.Migrations
{
    /// <inheritdoc />
    public partial class ResiduosComImagens2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: 1,
                columns: new[] { "ImgUrl", "Nome" },
                values: new object[] { "aco_Inox.jpeg", "Aço Inox" });

            migrationBuilder.UpdateData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: 2,
                columns: new[] { "ImgUrl", "Nome" },
                values: new object[] { "Ferro_Fundido.jpeg", "Ferro Fundido" });

            migrationBuilder.UpdateData(
                table: "Transacoes",
                keyColumn: "ID_Transacao",
                keyValue: 1,
                column: "Data_Transacao",
                value: new DateTime(2025, 5, 28, 10, 23, 9, 596, DateTimeKind.Local).AddTicks(1976));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: 1,
                columns: new[] { "ImgUrl", "Nome" },
                values: new object[] { "ferro.jpg", "Ferro" });

            migrationBuilder.UpdateData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: 2,
                columns: new[] { "ImgUrl", "Nome" },
                values: new object[] { "cobre.jpg", "Cobre" });

            migrationBuilder.UpdateData(
                table: "Transacoes",
                keyColumn: "ID_Transacao",
                keyValue: 1,
                column: "Data_Transacao",
                value: new DateTime(2025, 5, 28, 10, 19, 26, 246, DateTimeKind.Local).AddTicks(194));
        }
    }
}
