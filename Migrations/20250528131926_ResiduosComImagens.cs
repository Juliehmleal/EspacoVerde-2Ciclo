using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EspacoVerde.Migrations
{
    /// <inheritdoc />
    public partial class ResiduosComImagens : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImgUrl",
                table: "Residuos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: 1,
                column: "ImgUrl",
                value: "ferro.jpg");

            migrationBuilder.UpdateData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: 2,
                column: "ImgUrl",
                value: "cobre.jpg");

            migrationBuilder.UpdateData(
                table: "Transacoes",
                keyColumn: "ID_Transacao",
                keyValue: 1,
                column: "Data_Transacao",
                value: new DateTime(2025, 5, 28, 10, 19, 26, 246, DateTimeKind.Local).AddTicks(194));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImgUrl",
                table: "Residuos");

            migrationBuilder.UpdateData(
                table: "Transacoes",
                keyColumn: "ID_Transacao",
                keyValue: 1,
                column: "Data_Transacao",
                value: new DateTime(2025, 5, 28, 10, 8, 26, 139, DateTimeKind.Local).AddTicks(9833));
        }
    }
}
