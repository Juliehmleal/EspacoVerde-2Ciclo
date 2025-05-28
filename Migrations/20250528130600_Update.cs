using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EspacoVerde.Migrations
{
    /// <inheritdoc />
    public partial class Update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Residuos_Usuarios_UsuarioID_Usuario",
                table: "Residuos");

            migrationBuilder.DropIndex(
                name: "IX_Residuos_UsuarioID_Usuario",
                table: "Residuos");

            migrationBuilder.DropColumn(
                name: "UsuarioID_Usuario",
                table: "Residuos");

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "ID_Usuario", "CNPJ", "Email", "RazaoSocial", "Senha", "Status" },
                values: new object[,]
                {
                    { 1, "12.345.678/0001-99", "alfa@email.com", "Metalúrgica Alfa", "123", true },
                    { 2, "98.765.432/0001-11", "beta@email.com", "Siderúrgica Beta", "123", true }
                });

            migrationBuilder.InsertData(
                table: "Residuos",
                columns: new[] { "ID_Residuo", "ID_Usuario", "Nome", "Quantidade" },
                values: new object[,]
                {
                    { 1, 1, "Ferro", 100m },
                    { 2, 1, "Cobre", 50m }
                });

            migrationBuilder.InsertData(
                table: "Transacoes",
                columns: new[] { "ID_Transacao", "Data_Transacao", "ID_Comprador", "ID_Residuo", "Preco_Final" },
                values: new object[] { 1, new DateTime(2025, 5, 28, 10, 6, 0, 422, DateTimeKind.Local).AddTicks(8327), 2, 1, 1500m });

            migrationBuilder.CreateIndex(
                name: "IX_Residuos_ID_Usuario",
                table: "Residuos",
                column: "ID_Usuario");

            migrationBuilder.AddForeignKey(
                name: "FK_Residuos_Usuarios_ID_Usuario",
                table: "Residuos",
                column: "ID_Usuario",
                principalTable: "Usuarios",
                principalColumn: "ID_Usuario",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Residuos_Usuarios_ID_Usuario",
                table: "Residuos");

            migrationBuilder.DropIndex(
                name: "IX_Residuos_ID_Usuario",
                table: "Residuos");

            migrationBuilder.DeleteData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Transacoes",
                keyColumn: "ID_Transacao",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "ID_Usuario",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "ID_Usuario",
                keyValue: 1);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioID_Usuario",
                table: "Residuos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Residuos_UsuarioID_Usuario",
                table: "Residuos",
                column: "UsuarioID_Usuario");

            migrationBuilder.AddForeignKey(
                name: "FK_Residuos_Usuarios_UsuarioID_Usuario",
                table: "Residuos",
                column: "UsuarioID_Usuario",
                principalTable: "Usuarios",
                principalColumn: "ID_Usuario",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
