using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EspacoVerde.Migrations
{
    /// <inheritdoc />
    public partial class ArrumandoRelacionamentosEInserindoDados : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Transacoes",
                keyColumn: "ID_Transacao",
                keyValue: 1,
                column: "Data_Transacao",
                value: new DateTime(2025, 5, 28, 10, 8, 26, 139, DateTimeKind.Local).AddTicks(9833));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Transacoes",
                keyColumn: "ID_Transacao",
                keyValue: 1,
                column: "Data_Transacao",
                value: new DateTime(2025, 5, 28, 10, 6, 0, 422, DateTimeKind.Local).AddTicks(8327));
        }
    }
}
