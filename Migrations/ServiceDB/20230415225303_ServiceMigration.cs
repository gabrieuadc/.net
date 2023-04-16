using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace padrao.Migrations.ServiceDB
{
    /// <inheritdoc />
    public partial class ServiceMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    contact = table.Column<int>(type: "integer", maxLength: 70, nullable: false),
                    name = table.Column<string>(type: "character varying(70)", maxLength: 70, nullable: false),
                    service = table.Column<string>(type: "character varying(70)", maxLength: 70, nullable: false),
                    value = table.Column<string>(type: "character varying(70)", maxLength: 70, nullable: false),
                    date = table.Column<DateOnly>(type: "date", maxLength: 70, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Services");
        }
    }
}
