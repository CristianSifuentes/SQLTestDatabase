using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SQLTestDatabase.Migrations
{
    public partial class _1_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "FechaCreacion",
                table: "ViajeChofer",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaModificacion",
                table: "ViajeChofer",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaCreacion",
                table: "Viaje",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaModificacion",
                table: "Viaje",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaCreacion",
                table: "Vehiculo",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaModificacion",
                table: "Vehiculo",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaCreacion",
                table: "TipoVehiculo",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaModificacion",
                table: "TipoVehiculo",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaCreacion",
                table: "TipoPersona",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaModificacion",
                table: "TipoPersona",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaCreacion",
                table: "Persona",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaModificacion",
                table: "Persona",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaCreacion",
                table: "Pedido",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaModificacion",
                table: "Pedido",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaCreacion",
                table: "Empresa",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaModificacion",
                table: "Empresa",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "ViajeChofer");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "ViajeChofer");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "Viaje");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "Viaje");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "Vehiculo");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "Vehiculo");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "TipoVehiculo");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "TipoVehiculo");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "TipoPersona");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "TipoPersona");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "Persona");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "Persona");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "Pedido");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "Pedido");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "Empresa");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "Empresa");
        }
    }
}
