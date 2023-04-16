using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace padrao.Migrations.ImpostosDBContexMigrations
{
    /// <inheritdoc />
    public partial class firstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Imp",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    rbruta = table.Column<int>(type: "integer", maxLength: 70, nullable: false),
                    pis = table.Column<int>(type: "integer", maxLength: 70, nullable: false),
                    cofins = table.Column<int>(type: "integer", maxLength: 70, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Imp", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Imp");
        }
    }
}
