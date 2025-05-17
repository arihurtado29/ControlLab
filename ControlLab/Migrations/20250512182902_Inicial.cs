using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ControlLab.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AnalisisClinicos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Estudio = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TipodeMuestra = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Resultados = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnalisisClinicos", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnalisisClinicos");
        }
    }
}
