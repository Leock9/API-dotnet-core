using Microsoft.EntityFrameworkCore.Migrations;

namespace TesteApi.Migrations
{
    public partial class AlteracaoStatusAluno : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "Aluno",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Aluno",
                maxLength: 120,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(120)",
                oldMaxLength: 120);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Status",
                table: "Aluno",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Aluno",
                type: "varchar(120)",
                maxLength: 120,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 120);
        }
    }
}
