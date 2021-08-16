using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Turnos.Migrations
{
    public partial class MigracionTurno : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MedicoEspecialidad_Especialidad_idEspecialidad",
                table: "MedicoEspecialidad");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicoEspecialidad_Medico_idMedico",
                table: "MedicoEspecialidad");

            migrationBuilder.RenameColumn(
                name: "idEspecialidad",
                table: "MedicoEspecialidad",
                newName: "IdEspecialidad");

            migrationBuilder.RenameColumn(
                name: "idMedico",
                table: "MedicoEspecialidad",
                newName: "IdMedico");

            migrationBuilder.RenameIndex(
                name: "IX_MedicoEspecialidad_idEspecialidad",
                table: "MedicoEspecialidad",
                newName: "IX_MedicoEspecialidad_IdEspecialidad");

            migrationBuilder.CreateTable(
                name: "Turno",
                columns: table => new
                {
                    IdTurno = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdPaciente = table.Column<int>(unicode: false, nullable: false),
                    IdMedico = table.Column<int>(unicode: false, nullable: false),
                    FechaHoraInicio = table.Column<DateTime>(unicode: false, nullable: false),
                    FechaHoraFin = table.Column<DateTime>(unicode: false, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Turno", x => x.IdTurno);
                    table.ForeignKey(
                        name: "FK_Turno_Medico_IdMedico",
                        column: x => x.IdMedico,
                        principalTable: "Medico",
                        principalColumn: "IdMedico",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Turno_Paciente_IdPaciente",
                        column: x => x.IdPaciente,
                        principalTable: "Paciente",
                        principalColumn: "IdPaciente",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Turno_IdMedico",
                table: "Turno",
                column: "IdMedico");

            migrationBuilder.CreateIndex(
                name: "IX_Turno_IdPaciente",
                table: "Turno",
                column: "IdPaciente");

            migrationBuilder.AddForeignKey(
                name: "FK_MedicoEspecialidad_Especialidad_IdEspecialidad",
                table: "MedicoEspecialidad",
                column: "IdEspecialidad",
                principalTable: "Especialidad",
                principalColumn: "IdEspecialidad",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicoEspecialidad_Medico_IdMedico",
                table: "MedicoEspecialidad",
                column: "IdMedico",
                principalTable: "Medico",
                principalColumn: "IdMedico",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MedicoEspecialidad_Especialidad_IdEspecialidad",
                table: "MedicoEspecialidad");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicoEspecialidad_Medico_IdMedico",
                table: "MedicoEspecialidad");

            migrationBuilder.DropTable(
                name: "Turno");

            migrationBuilder.RenameColumn(
                name: "IdEspecialidad",
                table: "MedicoEspecialidad",
                newName: "idEspecialidad");

            migrationBuilder.RenameColumn(
                name: "IdMedico",
                table: "MedicoEspecialidad",
                newName: "idMedico");

            migrationBuilder.RenameIndex(
                name: "IX_MedicoEspecialidad_IdEspecialidad",
                table: "MedicoEspecialidad",
                newName: "IX_MedicoEspecialidad_idEspecialidad");

            migrationBuilder.AddForeignKey(
                name: "FK_MedicoEspecialidad_Especialidad_idEspecialidad",
                table: "MedicoEspecialidad",
                column: "idEspecialidad",
                principalTable: "Especialidad",
                principalColumn: "IdEspecialidad",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicoEspecialidad_Medico_idMedico",
                table: "MedicoEspecialidad",
                column: "idMedico",
                principalTable: "Medico",
                principalColumn: "IdMedico",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
