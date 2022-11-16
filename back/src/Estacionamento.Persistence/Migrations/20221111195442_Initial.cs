using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Estacionamento.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mensalistas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    placa = table.Column<string>(type: "TEXT", nullable: false),
                    Veiculo = table.Column<int>(type: "INTEGER", nullable: false),
                    celular = table.Column<int>(type: "INTEGER", nullable: false),
                    NomeVeiculo = table.Column<string>(type: "TEXT", nullable: false),
                    Cor = table.Column<string>(type: "TEXT", nullable: false),
                    Turno = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mensalistas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Veiculos",
                columns: table => new
                {
                    VeiculoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TipoVeiculo = table.Column<int>(type: "INTEGER", nullable: false),
                    PlacaDoVeiculo = table.Column<string>(type: "TEXT", nullable: false),
                    HoraEntrada = table.Column<DateTime>(type: "TEXT", nullable: true),
                    DataEntrada = table.Column<DateTime>(type: "TEXT", nullable: true),
                    HoraSaida = table.Column<DateTime>(type: "TEXT", nullable: true),
                    DataSaida = table.Column<DateTime>(type: "TEXT", nullable: true),
                    valorAPagar = table.Column<decimal>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veiculos", x => x.VeiculoId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mensalistas");

            migrationBuilder.DropTable(
                name: "Veiculos");
        }
    }
}
