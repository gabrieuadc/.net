using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace padrao.Migrations.ImpostosDBContexMigrations
{
    /// <inheritdoc />
    public partial class secondMigartion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "exercicio",
                table: "Imp",
                type: "text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "exercicio",
                table: "Imp");
        }
    }
}
