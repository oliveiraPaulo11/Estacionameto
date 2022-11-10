using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Estacionamento.api.Data.migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Veiculos",
                columns: table => new
                {
                    VeiculoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TipoVeiculo = table.Column<int>(type: "INTEGER", nullable: false),
                    PlacaDoVeiculo = table.Column<string>(type: "TEXT", nullable: false),
                    HoraEntrada = table.Column<string>(type: "TEXT", nullable: false),
                    DataEntrada = table.Column<string>(type: "TEXT", nullable: false),
                    HoraSaida = table.Column<string>(type: "TEXT", nullable: false),
                    DataSaida = table.Column<string>(type: "TEXT", nullable: false),
                    valorAPagar = table.Column<double>(type: "REAL", nullable: false)
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
                name: "Veiculos");
        }
    }
}
