using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AlumnosCursos.Migrations
{
    public partial class mapping : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Horas",
                table: "Asignaturas",
                newName: "tiempo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "tiempo",
                table: "Asignaturas",
                newName: "Horas");
        }
    }
}
