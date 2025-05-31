using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EspacoVerde.Migrations
{
    /// <inheritdoc />
    public partial class UpdateREsiduo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "PrecoKg",
                table: "Residuos",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: 1,
                column: "PrecoKg",
                value: 5.50m);

            migrationBuilder.UpdateData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: 2,
                column: "PrecoKg",
                value: 1.20m);

            migrationBuilder.UpdateData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: 3,
                column: "PrecoKg",
                value: 3.80m);

            migrationBuilder.UpdateData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: 4,
                column: "PrecoKg",
                value: 8.20m);

            migrationBuilder.UpdateData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: 5,
                column: "PrecoKg",
                value: 4.50m);

            migrationBuilder.UpdateData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: 6,
                column: "PrecoKg",
                value: 2.10m);

            migrationBuilder.UpdateData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: 7,
                column: "PrecoKg",
                value: 1.80m);

            migrationBuilder.UpdateData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: 8,
                column: "PrecoKg",
                value: 9.50m);

            migrationBuilder.UpdateData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: 9,
                column: "PrecoKg",
                value: 12.00m);

            migrationBuilder.UpdateData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: 10,
                column: "PrecoKg",
                value: 25.00m);

            migrationBuilder.UpdateData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: 11,
                column: "PrecoKg",
                value: 6.80m);

            migrationBuilder.UpdateData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: 12,
                column: "PrecoKg",
                value: 0.90m);

            migrationBuilder.UpdateData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: 13,
                column: "PrecoKg",
                value: 4.20m);

            migrationBuilder.UpdateData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: 14,
                column: "PrecoKg",
                value: 7.10m);

            migrationBuilder.UpdateData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: 15,
                column: "PrecoKg",
                value: 1.50m);

            migrationBuilder.UpdateData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: 16,
                column: "PrecoKg",
                value: 30.00m);

            migrationBuilder.UpdateData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: 17,
                column: "PrecoKg",
                value: 28.00m);

            migrationBuilder.UpdateData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: 18,
                column: "PrecoKg",
                value: 15.50m);

            migrationBuilder.UpdateData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: 19,
                column: "PrecoKg",
                value: 5.70m);

            migrationBuilder.UpdateData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: 20,
                column: "PrecoKg",
                value: 4.00m);

            migrationBuilder.UpdateData(
                table: "Transacoes",
                keyColumn: "ID_Transacao",
                keyValue: 1,
                columns: new[] { "Data_Transacao", "Preco_Final" },
                values: new object[] { new DateTime(2025, 5, 29, 10, 22, 3, 861, DateTimeKind.Local).AddTicks(359), 550m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PrecoKg",
                table: "Residuos");

            migrationBuilder.UpdateData(
                table: "Transacoes",
                keyColumn: "ID_Transacao",
                keyValue: 1,
                columns: new[] { "Data_Transacao", "Preco_Final" },
                values: new object[] { new DateTime(2025, 5, 28, 20, 43, 59, 97, DateTimeKind.Local).AddTicks(6089), 1500m });
        }
    }
}
