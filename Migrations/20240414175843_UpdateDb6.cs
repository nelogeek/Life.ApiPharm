using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Life.ApiPharm.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDb6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Packs",
                table: "ManufacturingForms");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Packs",
                table: "ManufacturingForms",
                type: "text",
                nullable: true);
        }
    }
}
