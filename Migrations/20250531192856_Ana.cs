using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EspacoVerde.Migrations
{
    /// <inheritdoc />
    public partial class Ana : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Transacoes",
                keyColumn: "ID_Transacao",
                keyValue: 1,
                column: "Data_Transacao",
                value: new DateTime(2025, 5, 31, 16, 28, 56, 15, DateTimeKind.Local).AddTicks(4399));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Transacoes",
                keyColumn: "ID_Transacao",
                keyValue: 1,
                column: "Data_Transacao",
                value: new DateTime(2025, 5, 31, 11, 38, 9, 787, DateTimeKind.Local).AddTicks(8559));
        }
    }
}
