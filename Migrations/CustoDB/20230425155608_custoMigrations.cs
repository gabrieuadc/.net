using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace padrao.Migrations.CustoDB
{
    /// <inheritdoc />
    public partial class custoMigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Custo",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    cc = table.Column<string>(type: "character varying(70)", maxLength: 70, nullable: false),
                    mod = table.Column<int>(type: "integer", nullable: false),
                    md = table.Column<int>(type: "integer", nullable: false),
                    cif = table.Column<int>(type: "integer", nullable: false),
                    cpp = table.Column<int>(type: "integer", nullable: false),
                    exercicio = table.Column<string>(type: "character varying(70)", maxLength: 70, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Custo", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Custo");
        }
    }
}
