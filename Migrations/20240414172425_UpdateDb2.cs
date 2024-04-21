using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Life.ApiPharm.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDb2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsRef",
                table: "GRLS");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IsRef",
                table: "GRLS",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
