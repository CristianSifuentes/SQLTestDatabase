using Microsoft.EntityFrameworkCore.Migrations;

namespace SQLTestDatabase.Migrations
{
    public partial class _1_5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PedidoCte_Pedido_PedidoId1",
                table: "PedidoCte");

            migrationBuilder.DropForeignKey(
                name: "FK_PedidoCte_Persona_PersonaId1",
                table: "PedidoCte");

            migrationBuilder.DropForeignKey(
                name: "FK_Persona_Empresa_EmpresaId1",
                table: "Persona");

            migrationBuilder.DropForeignKey(
                name: "FK_Persona_TipoPersona_TipoPersonaId1",
                table: "Persona");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculo_TipoVehiculo_TipoVehiculoId1",
                table: "Vehiculo");

            migrationBuilder.DropForeignKey(
                name: "FK_ViajeChofer_Persona_PersonaId1",
                table: "ViajeChofer");

            migrationBuilder.DropForeignKey(
                name: "FK_ViajeChofer_Viaje_ViajeId1",
                table: "ViajeChofer");

            migrationBuilder.DropIndex(
                name: "IX_ViajeChofer_PersonaId1",
                table: "ViajeChofer");

            migrationBuilder.DropIndex(
                name: "IX_ViajeChofer_ViajeId1",
                table: "ViajeChofer");

            migrationBuilder.DropIndex(
                name: "IX_Vehiculo_TipoVehiculoId1",
                table: "Vehiculo");

            migrationBuilder.DropIndex(
                name: "IX_Persona_EmpresaId1",
                table: "Persona");

            migrationBuilder.DropIndex(
                name: "IX_Persona_TipoPersonaId1",
                table: "Persona");

            migrationBuilder.DropIndex(
                name: "IX_PedidoCte_PedidoId1",
                table: "PedidoCte");

            migrationBuilder.DropIndex(
                name: "IX_PedidoCte_PersonaId1",
                table: "PedidoCte");

            migrationBuilder.DropColumn(
                name: "PersonaId1",
                table: "ViajeChofer");

            migrationBuilder.DropColumn(
                name: "ViajeId1",
                table: "ViajeChofer");

            migrationBuilder.DropColumn(
                name: "TipoVehiculoId1",
                table: "Vehiculo");

            migrationBuilder.DropColumn(
                name: "EmpresaId1",
                table: "Persona");

            migrationBuilder.DropColumn(
                name: "TipoPersonaId1",
                table: "Persona");

            migrationBuilder.DropColumn(
                name: "PedidoId1",
                table: "PedidoCte");

            migrationBuilder.DropColumn(
                name: "PersonaId1",
                table: "PedidoCte");

            migrationBuilder.AlterColumn<int>(
                name: "ViajeId",
                table: "ViajeChofer",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "PersonaId",
                table: "ViajeChofer",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "TipoVehiculoId",
                table: "Vehiculo",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "TipoPersonaId",
                table: "Persona",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EmpresaId",
                table: "Persona",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PersonaId",
                table: "PedidoCte",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "PedidoId",
                table: "PedidoCte",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Pedido",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_ViajeChofer_PersonaId",
                table: "ViajeChofer",
                column: "PersonaId");

            migrationBuilder.CreateIndex(
                name: "IX_ViajeChofer_ViajeId",
                table: "ViajeChofer",
                column: "ViajeId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculo_TipoVehiculoId",
                table: "Vehiculo",
                column: "TipoVehiculoId");

            migrationBuilder.CreateIndex(
                name: "IX_Persona_EmpresaId",
                table: "Persona",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Persona_TipoPersonaId",
                table: "Persona",
                column: "TipoPersonaId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoCte_PedidoId",
                table: "PedidoCte",
                column: "PedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoCte_PersonaId",
                table: "PedidoCte",
                column: "PersonaId");

            migrationBuilder.AddForeignKey(
                name: "FK_PedidoCte_Pedido_PedidoId",
                table: "PedidoCte",
                column: "PedidoId",
                principalTable: "Pedido",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PedidoCte_Persona_PersonaId",
                table: "PedidoCte",
                column: "PersonaId",
                principalTable: "Persona",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Persona_Empresa_EmpresaId",
                table: "Persona",
                column: "EmpresaId",
                principalTable: "Empresa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Persona_TipoPersona_TipoPersonaId",
                table: "Persona",
                column: "TipoPersonaId",
                principalTable: "TipoPersona",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculo_TipoVehiculo_TipoVehiculoId",
                table: "Vehiculo",
                column: "TipoVehiculoId",
                principalTable: "TipoVehiculo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ViajeChofer_Persona_PersonaId",
                table: "ViajeChofer",
                column: "PersonaId",
                principalTable: "Persona",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ViajeChofer_Viaje_ViajeId",
                table: "ViajeChofer",
                column: "ViajeId",
                principalTable: "Viaje",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PedidoCte_Pedido_PedidoId",
                table: "PedidoCte");

            migrationBuilder.DropForeignKey(
                name: "FK_PedidoCte_Persona_PersonaId",
                table: "PedidoCte");

            migrationBuilder.DropForeignKey(
                name: "FK_Persona_Empresa_EmpresaId",
                table: "Persona");

            migrationBuilder.DropForeignKey(
                name: "FK_Persona_TipoPersona_TipoPersonaId",
                table: "Persona");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculo_TipoVehiculo_TipoVehiculoId",
                table: "Vehiculo");

            migrationBuilder.DropForeignKey(
                name: "FK_ViajeChofer_Persona_PersonaId",
                table: "ViajeChofer");

            migrationBuilder.DropForeignKey(
                name: "FK_ViajeChofer_Viaje_ViajeId",
                table: "ViajeChofer");

            migrationBuilder.DropIndex(
                name: "IX_ViajeChofer_PersonaId",
                table: "ViajeChofer");

            migrationBuilder.DropIndex(
                name: "IX_ViajeChofer_ViajeId",
                table: "ViajeChofer");

            migrationBuilder.DropIndex(
                name: "IX_Vehiculo_TipoVehiculoId",
                table: "Vehiculo");

            migrationBuilder.DropIndex(
                name: "IX_Persona_EmpresaId",
                table: "Persona");

            migrationBuilder.DropIndex(
                name: "IX_Persona_TipoPersonaId",
                table: "Persona");

            migrationBuilder.DropIndex(
                name: "IX_PedidoCte_PedidoId",
                table: "PedidoCte");

            migrationBuilder.DropIndex(
                name: "IX_PedidoCte_PersonaId",
                table: "PedidoCte");

            migrationBuilder.AlterColumn<long>(
                name: "ViajeId",
                table: "ViajeChofer",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<long>(
                name: "PersonaId",
                table: "ViajeChofer",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "PersonaId1",
                table: "ViajeChofer",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ViajeId1",
                table: "ViajeChofer",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "TipoVehiculoId",
                table: "Vehiculo",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "TipoVehiculoId1",
                table: "Vehiculo",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "TipoPersonaId",
                table: "Persona",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "EmpresaId",
                table: "Persona",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmpresaId1",
                table: "Persona",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TipoPersonaId1",
                table: "Persona",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "PersonaId",
                table: "PedidoCte",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<long>(
                name: "PedidoId",
                table: "PedidoCte",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "PedidoId1",
                table: "PedidoCte",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonaId1",
                table: "PedidoCte",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Descripcion",
                table: "Pedido",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ViajeChofer_PersonaId1",
                table: "ViajeChofer",
                column: "PersonaId1");

            migrationBuilder.CreateIndex(
                name: "IX_ViajeChofer_ViajeId1",
                table: "ViajeChofer",
                column: "ViajeId1");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculo_TipoVehiculoId1",
                table: "Vehiculo",
                column: "TipoVehiculoId1");

            migrationBuilder.CreateIndex(
                name: "IX_Persona_EmpresaId1",
                table: "Persona",
                column: "EmpresaId1");

            migrationBuilder.CreateIndex(
                name: "IX_Persona_TipoPersonaId1",
                table: "Persona",
                column: "TipoPersonaId1");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoCte_PedidoId1",
                table: "PedidoCte",
                column: "PedidoId1");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoCte_PersonaId1",
                table: "PedidoCte",
                column: "PersonaId1");

            migrationBuilder.AddForeignKey(
                name: "FK_PedidoCte_Pedido_PedidoId1",
                table: "PedidoCte",
                column: "PedidoId1",
                principalTable: "Pedido",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PedidoCte_Persona_PersonaId1",
                table: "PedidoCte",
                column: "PersonaId1",
                principalTable: "Persona",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Persona_Empresa_EmpresaId1",
                table: "Persona",
                column: "EmpresaId1",
                principalTable: "Empresa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Persona_TipoPersona_TipoPersonaId1",
                table: "Persona",
                column: "TipoPersonaId1",
                principalTable: "TipoPersona",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculo_TipoVehiculo_TipoVehiculoId1",
                table: "Vehiculo",
                column: "TipoVehiculoId1",
                principalTable: "TipoVehiculo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ViajeChofer_Persona_PersonaId1",
                table: "ViajeChofer",
                column: "PersonaId1",
                principalTable: "Persona",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ViajeChofer_Viaje_ViajeId1",
                table: "ViajeChofer",
                column: "ViajeId1",
                principalTable: "Viaje",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
