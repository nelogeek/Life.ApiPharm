using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Life.ApiPharm.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RefLinks",
                table: "GRLS");

            migrationBuilder.AlterColumn<string>(
                name: "Packs",
                table: "ManufacturingForms",
                type: "text",
                nullable: false,
                oldClrType: typeof(List<string>),
                oldType: "text[]");

            migrationBuilder.AddColumn<string>(
                name: "id_grls",
                table: "GRLS",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "id_grls",
                table: "GRLS");

            migrationBuilder.AlterColumn<List<string>>(
                name: "Packs",
                table: "ManufacturingForms",
                type: "text[]",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<List<string>>(
                name: "RefLinks",
                table: "GRLS",
                type: "text[]",
                nullable: false);
        }
    }
}
