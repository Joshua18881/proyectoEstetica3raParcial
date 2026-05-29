using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace proyectoEstetica3raParcial.Migrations
{
    /// <inheritdoc />
    public partial class AgregandoColumnaPrecio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ServicioId",
                table: "DetallesServicios",
                newName: "ProductoApiId");

            migrationBuilder.RenameColumn(
                name: "PrecioAplicado",
                table: "DetallesServicios",
                newName: "Precio");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProductoApiId",
                table: "DetallesServicios",
                newName: "ServicioId");

            migrationBuilder.RenameColumn(
                name: "Precio",
                table: "DetallesServicios",
                newName: "PrecioAplicado");
        }
    }
}
