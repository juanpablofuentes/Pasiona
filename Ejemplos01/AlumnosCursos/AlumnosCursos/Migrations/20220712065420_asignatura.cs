using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AlumnosCursos.Migrations
{
    public partial class asignatura : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cursos_Profesor_ProfesorId",
                table: "Cursos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Profesor",
                table: "Profesor");

            migrationBuilder.RenameTable(
                name: "Profesor",
                newName: "Profesores");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Profesores",
                table: "Profesores",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Asignaturas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Horas = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asignaturas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cursos_Asignaturas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CursoId = table.Column<int>(type: "int", nullable: false),
                    AsignaturaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cursos_Asignaturas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cursos_Asignaturas_Asignaturas_AsignaturaId",
                        column: x => x.AsignaturaId,
                        principalTable: "Asignaturas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cursos_Asignaturas_Cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "Cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cursos_Asignaturas_AsignaturaId",
                table: "Cursos_Asignaturas",
                column: "AsignaturaId");

            migrationBuilder.CreateIndex(
                name: "IX_Cursos_Asignaturas_CursoId",
                table: "Cursos_Asignaturas",
                column: "CursoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cursos_Profesores_ProfesorId",
                table: "Cursos",
                column: "ProfesorId",
                principalTable: "Profesores",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cursos_Profesores_ProfesorId",
                table: "Cursos");

            migrationBuilder.DropTable(
                name: "Cursos_Asignaturas");

            migrationBuilder.DropTable(
                name: "Asignaturas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Profesores",
                table: "Profesores");

            migrationBuilder.RenameTable(
                name: "Profesores",
                newName: "Profesor");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Profesor",
                table: "Profesor",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cursos_Profesor_ProfesorId",
                table: "Cursos",
                column: "ProfesorId",
                principalTable: "Profesor",
                principalColumn: "Id");
        }
    }
}
