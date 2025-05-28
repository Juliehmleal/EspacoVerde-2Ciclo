using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EspacoVerde.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    ID_Usuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RazaoSocial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CNPJ = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.ID_Usuario);
                });

            migrationBuilder.CreateTable(
                name: "Residuos",
                columns: table => new
                {
                    ID_Residuo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_Usuario = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantidade = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UsuarioID_Usuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Residuos", x => x.ID_Residuo);
                    table.ForeignKey(
                        name: "FK_Residuos_Usuarios_UsuarioID_Usuario",
                        column: x => x.UsuarioID_Usuario,
                        principalTable: "Usuarios",
                        principalColumn: "ID_Usuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Transacoes",
                columns: table => new
                {
                    ID_Transacao = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_Residuo = table.Column<int>(type: "int", nullable: false),
                    ID_Comprador = table.Column<int>(type: "int", nullable: false),
                    Data_Transacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Preco_Final = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transacoes", x => x.ID_Transacao);
                    table.ForeignKey(
                        name: "FK_Transacoes_Residuos_ID_Residuo",
                        column: x => x.ID_Residuo,
                        principalTable: "Residuos",
                        principalColumn: "ID_Residuo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transacoes_Usuarios_ID_Comprador",
                        column: x => x.ID_Comprador,
                        principalTable: "Usuarios",
                        principalColumn: "ID_Usuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Residuos_UsuarioID_Usuario",
                table: "Residuos",
                column: "UsuarioID_Usuario");

            migrationBuilder.CreateIndex(
                name: "IX_Transacoes_ID_Comprador",
                table: "Transacoes",
                column: "ID_Comprador");

            migrationBuilder.CreateIndex(
                name: "IX_Transacoes_ID_Residuo",
                table: "Transacoes",
                column: "ID_Residuo",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transacoes");

            migrationBuilder.DropTable(
                name: "Residuos");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
