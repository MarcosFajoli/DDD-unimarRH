using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DDD.Infra.SQLServer.Migrations
{
    /// <inheritdoc />
    public partial class FuncionarioTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataNasc",
                table: "Pesquisador",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataNasc",
                table: "Aluno",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "Cargo",
                columns: table => new
                {
                    CargoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cargo", x => x.CargoId);
                });

            migrationBuilder.CreateTable(
                name: "Funcionarios",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEXT VALUE FOR [UserSequence]"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sobrenome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataNasc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    DataAdmissao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Salario = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FeriasPendentes = table.Column<bool>(type: "bit", nullable: false),
                    MinutosExtras = table.Column<int>(type: "int", nullable: false),
                    CargoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionarios", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Funcionarios_Cargo_CargoId",
                        column: x => x.CargoId,
                        principalTable: "Cargo",
                        principalColumn: "CargoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Funcionarios_CargoId",
                table: "Funcionarios",
                column: "CargoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Funcionarios");

            migrationBuilder.DropTable(
                name: "Cargo");

            migrationBuilder.DropColumn(
                name: "DataNasc",
                table: "Pesquisador");

            migrationBuilder.DropColumn(
                name: "DataNasc",
                table: "Aluno");
        }
    }
}
