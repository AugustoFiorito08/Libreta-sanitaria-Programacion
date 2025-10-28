using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Biblioeta_de_Clases.Migrations
{
    /// <inheritdoc />
    public partial class Migracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descripcion",
                table: "HistorialesMedicos");

            migrationBuilder.DropColumn(
                name: "Fecha",
                table: "HistorialesMedicos");

            migrationBuilder.DropColumn(
                name: "Observaciones",
                table: "HistorialesMedicos");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Descripcion",
                table: "HistorialesMedicos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "Fecha",
                table: "HistorialesMedicos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Observaciones",
                table: "HistorialesMedicos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
