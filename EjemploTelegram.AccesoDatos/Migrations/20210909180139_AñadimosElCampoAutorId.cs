using Microsoft.EntityFrameworkCore.Migrations;

namespace EjemploTelegram.AccesoDatos.Migrations
{
    public partial class AñadimosElCampoAutorId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AutorId",
                table: "Libro",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AutorId",
                table: "Libro");
        }
    }
}
