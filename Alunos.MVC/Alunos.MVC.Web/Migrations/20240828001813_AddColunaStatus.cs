using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Alunos.MVC.Web.Migrations
{
    /// <inheritdoc />
    public partial class AddColunaStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Aluno",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Aluno");
        }
    }
}
