using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TesteApi.Migrations
{
    public partial class Aluno : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aluno",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(type: "varchar(120)", maxLength: 120, nullable: false),
                    Idade = table.Column<int>(type: "int", nullable: false),
                    Matricula = table.Column<int>(type: "int", maxLength: 5, nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aluno", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aluno");
        }
    }
}
