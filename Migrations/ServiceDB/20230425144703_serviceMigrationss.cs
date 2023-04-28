using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace padrao.Migrations.ServiceDB
{
    /// <inheritdoc />
    public partial class serviceMigrationss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "value",
                table: "Services",
                type: "integer",
                maxLength: 70,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(70)",
                oldMaxLength: 70);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "value",
                table: "Services",
                type: "character varying(70)",
                maxLength: 70,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldMaxLength: 70);
        }
    }
}
