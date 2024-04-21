using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Life.ApiPharm.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDb5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ptg",
                table: "GRLS",
                type: "text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ptg",
                table: "GRLS");
        }
    }
}
