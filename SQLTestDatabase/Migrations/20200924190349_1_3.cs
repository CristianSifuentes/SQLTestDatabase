using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SQLTestDatabase.Migrations
{
    public partial class _1_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PedidoCte",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaCreacion = table.Column<DateTime>(nullable: false),
                    FechaModificacion = table.Column<DateTime>(nullable: true),
                    PedidoId = table.Column<long>(nullable: false),
                    PedidoId1 = table.Column<int>(nullable: true),
                    PersonaId = table.Column<long>(nullable: false),
                    PersonaId1 = table.Column<int>(nullable: true),
                    FechaPedido = table.Column<DateTime>(nullable: false),
                    Producto = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PedidoCte", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PedidoCte_Pedido_PedidoId1",
                        column: x => x.PedidoId1,
                        principalTable: "Pedido",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PedidoCte_Persona_PersonaId1",
                        column: x => x.PersonaId1,
                        principalTable: "Persona",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PedidoCte_PedidoId1",
                table: "PedidoCte",
                column: "PedidoId1");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoCte_PersonaId1",
                table: "PedidoCte",
                column: "PersonaId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PedidoCte");
        }
    }
}
