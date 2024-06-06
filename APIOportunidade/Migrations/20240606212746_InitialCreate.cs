using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIOportunidade.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Oportunidade",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dataEntrega = table.Column<DateTime>(type: "datetime2", nullable: false),
                    nvlSurto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    qtdHoras = table.Column<int>(type: "int", nullable: false),
                    qtdErros = table.Column<long>(type: "bigint", nullable: false),
                    aprendizadoNvl = table.Column<long>(type: "bigint", nullable: false),
                    horasDeSono = table.Column<short>(type: "smallint", nullable: false),
                    horasFolga = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oportunidade", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Oportunidade");
        }
    }
}
