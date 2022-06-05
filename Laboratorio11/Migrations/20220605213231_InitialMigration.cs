using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Laboratorio11.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "autor",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", maxLength: 3, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    primeiroNome = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ultimoNome = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_autor", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "emprestimo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dataRetirada = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dataDevolucao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    entregue = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_emprestimo", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "livro",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    titulo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_livro", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "autor");

            migrationBuilder.DropTable(
                name: "emprestimo");

            migrationBuilder.DropTable(
                name: "livro");
        }
    }
}
