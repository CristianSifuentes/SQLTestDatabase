using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SQLTestDatabase.Migrations
{
    public partial class _1_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Empresa",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    RFC = table.Column<string>(nullable: true),
                    Direccion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pedido",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Numero = table.Column<string>(nullable: true),
                    CantidadProductos = table.Column<int>(nullable: false),
                    Descripcion = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedido", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoPersona",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoPersona", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoVehiculo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoVehiculo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Viaje",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Numero = table.Column<string>(nullable: true),
                    FechaInicio = table.Column<DateTime>(nullable: false),
                    FechaFin = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Viaje", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Persona",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    ApellidoPaterno = table.Column<string>(nullable: true),
                    ApellidoMaterno = table.Column<string>(nullable: true),
                    Edad = table.Column<int>(nullable: false),
                    Sexo = table.Column<string>(nullable: true),
                    RFC = table.Column<string>(nullable: true),
                    EmpresaId = table.Column<long>(nullable: true),
                    EmpresaId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persona", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Persona_Empresa_EmpresaId1",
                        column: x => x.EmpresaId1,
                        principalTable: "Empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Vehiculo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Marca = table.Column<string>(nullable: true),
                    Anio = table.Column<string>(nullable: true),
                    Placas = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true),
                    TipoVehiculoId = table.Column<long>(nullable: false),
                    TipoVehiculoId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehiculo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vehiculo_TipoVehiculo_TipoVehiculoId1",
                        column: x => x.TipoVehiculoId1,
                        principalTable: "TipoVehiculo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ViajeChofer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ViajeId = table.Column<long>(nullable: false),
                    ViajeId1 = table.Column<int>(nullable: true),
                    PersonaId = table.Column<long>(nullable: false),
                    PersonaId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ViajeChofer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ViajeChofer_Persona_PersonaId1",
                        column: x => x.PersonaId1,
                        principalTable: "Persona",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ViajeChofer_Viaje_ViajeId1",
                        column: x => x.ViajeId1,
                        principalTable: "Viaje",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Persona_EmpresaId1",
                table: "Persona",
                column: "EmpresaId1");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculo_TipoVehiculoId1",
                table: "Vehiculo",
                column: "TipoVehiculoId1");

            migrationBuilder.CreateIndex(
                name: "IX_ViajeChofer_PersonaId1",
                table: "ViajeChofer",
                column: "PersonaId1");

            migrationBuilder.CreateIndex(
                name: "IX_ViajeChofer_ViajeId1",
                table: "ViajeChofer",
                column: "ViajeId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pedido");

            migrationBuilder.DropTable(
                name: "TipoPersona");

            migrationBuilder.DropTable(
                name: "Vehiculo");

            migrationBuilder.DropTable(
                name: "ViajeChofer");

            migrationBuilder.DropTable(
                name: "TipoVehiculo");

            migrationBuilder.DropTable(
                name: "Persona");

            migrationBuilder.DropTable(
                name: "Viaje");

            migrationBuilder.DropTable(
                name: "Empresa");
        }
    }
}
