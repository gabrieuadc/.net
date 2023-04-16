using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace padrao.Migrations.ServiceDB
{
    /// <inheritdoc />
    public partial class ServiceMigration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "date",
                table: "Services",
                type: "character varying(70)",
                maxLength: 70,
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date",
                oldMaxLength: 70);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateOnly>(
                name: "date",
                table: "Services",
                type: "date",
                maxLength: 70,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(70)",
                oldMaxLength: 70);
        }
    }
}
