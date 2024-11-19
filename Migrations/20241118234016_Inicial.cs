using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AlmaMaria_AP1_P2.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Articulos",
                columns: table => new
                {
                    ArticuloId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Monto = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articulos", x => x.ArticuloId);
                });

            migrationBuilder.CreateTable(
                name: "Combos",
                columns: table => new
                {
                    CombosId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Precio = table.Column<double>(type: "float", nullable: false),
                    Vendido = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Combos", x => x.CombosId);
                });

            migrationBuilder.CreateTable(
                name: "CombosDetalles",
                columns: table => new
                {
                    DetalleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    Costo = table.Column<double>(type: "float", nullable: false),
                    ArticuloId = table.Column<int>(type: "int", nullable: false),
                    CombosId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CombosDetalles", x => x.DetalleId);
                    table.ForeignKey(
                        name: "FK_CombosDetalles_Articulos_ArticuloId",
                        column: x => x.ArticuloId,
                        principalTable: "Articulos",
                        principalColumn: "ArticuloId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CombosDetalles_Combos_CombosId",
                        column: x => x.CombosId,
                        principalTable: "Combos",
                        principalColumn: "CombosId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Articulos",
                columns: new[] { "ArticuloId", "Descripcion", "Monto" },
                values: new object[,]
                {
                    { 1, "Procesador", 15000.0 },
                    { 2, "Tarjeta Gráfica", 24000.0 },
                    { 3, "Ram", 7000.0 },
                    { 4, "SSD", 8000.0 },
                    { 5, "Refrigeración", 12000.0 },
                    { 6, "Placa Madre", 13000.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CombosDetalles_ArticuloId",
                table: "CombosDetalles",
                column: "ArticuloId");

            migrationBuilder.CreateIndex(
                name: "IX_CombosDetalles_CombosId",
                table: "CombosDetalles",
                column: "CombosId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CombosDetalles");

            migrationBuilder.DropTable(
                name: "Articulos");

            migrationBuilder.DropTable(
                name: "Combos");
        }
    }
}
