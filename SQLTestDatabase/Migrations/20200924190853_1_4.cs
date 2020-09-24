using Microsoft.EntityFrameworkCore.Migrations;

namespace SQLTestDatabase.Migrations
{
    public partial class _1_4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "TipoPersonaId",
                table: "Persona",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TipoPersonaId1",
                table: "Persona",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Persona_TipoPersonaId1",
                table: "Persona",
                column: "TipoPersonaId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Persona_TipoPersona_TipoPersonaId1",
                table: "Persona",
                column: "TipoPersonaId1",
                principalTable: "TipoPersona",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persona_TipoPersona_TipoPersonaId1",
                table: "Persona");

            migrationBuilder.DropIndex(
                name: "IX_Persona_TipoPersonaId1",
                table: "Persona");

            migrationBuilder.DropColumn(
                name: "TipoPersonaId",
                table: "Persona");

            migrationBuilder.DropColumn(
                name: "TipoPersonaId1",
                table: "Persona");
        }
    }
}
