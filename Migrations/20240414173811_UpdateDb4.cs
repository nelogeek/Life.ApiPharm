using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Life.ApiPharm.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDb4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Packs",
                type: "text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Packs");
        }
    }
}
