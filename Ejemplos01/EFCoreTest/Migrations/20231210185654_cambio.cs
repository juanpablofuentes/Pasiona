using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreTest.Migrations
{
    /// <inheritdoc />
    public partial class cambio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Profesores",
                newName: "NombreCompleto");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NombreCompleto",
                table: "Profesores",
                newName: "Nombre");
        }
    }
}
