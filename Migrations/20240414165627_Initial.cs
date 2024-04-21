using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Life.ApiPharm.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GRLS",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Inn = table.Column<string>(type: "text", nullable: false),
                    IsFs = table.Column<bool>(type: "boolean", nullable: false),
                    IsRef = table.Column<string>(type: "text", nullable: false),
                    CertNum = table.Column<string>(type: "text", nullable: false),
                    ExpDate = table.Column<string>(type: "text", nullable: false),
                    RegDate = table.Column<string>(type: "text", nullable: false),
                    RefLinks = table.Column<List<string>>(type: "text[]", nullable: false),
                    RenewDate = table.Column<string>(type: "text", nullable: false),
                    TradeName = table.Column<string>(type: "text", nullable: false),
                    CancelDate = table.Column<string>(type: "text", nullable: false),
                    HolderName = table.Column<string>(type: "text", nullable: false),
                    IsNarcotic = table.Column<string>(type: "text", nullable: false),
                    OrphanDate = table.Column<string>(type: "text", nullable: false),
                    HolderCountry = table.Column<string>(type: "text", nullable: false),
                    IsLifeImportant = table.Column<string>(type: "text", nullable: false),
                    CirculationPeriod = table.Column<string>(type: "text", nullable: false),
                    IsInterchangeable = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GRLS", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "AtgItems",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    GrlsId = table.Column<int>(type: "integer", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AtgItems", x => x.id);
                    table.ForeignKey(
                        name: "FK_AtgItems_GRLS_GrlsId",
                        column: x => x.GrlsId,
                        principalTable: "GRLS",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Instructions",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    GrlsId = table.Column<int>(type: "integer", nullable: false),
                    Url = table.Column<string>(type: "text", nullable: false),
                    IdReg = table.Column<int>(type: "integer", nullable: false),
                    Label = table.Column<string>(type: "text", nullable: false),
                    Section = table.Column<int>(type: "integer", nullable: false),
                    Filename = table.Column<string>(type: "text", nullable: false),
                    SourceUrl = table.Column<string>(type: "text", nullable: false),
                    SourceName = table.Column<string>(type: "text", nullable: false),
                    InstructionLabel = table.Column<string>(type: "text", nullable: false),
                    InstructionFolderPath = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructions", x => x.id);
                    table.ForeignKey(
                        name: "FK_Instructions_GRLS_GrlsId",
                        column: x => x.GrlsId,
                        principalTable: "GRLS",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ManufacturingForms",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    GrlsId = table.Column<int>(type: "integer", nullable: false),
                    Dose = table.Column<string>(type: "text", nullable: false),
                    Form = table.Column<string>(type: "text", nullable: false),
                    Packs = table.Column<List<string>>(type: "text[]", nullable: false),
                    ShelfLife = table.Column<string>(type: "text", nullable: false),
                    StorageConditions = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManufacturingForms", x => x.id);
                    table.ForeignKey(
                        name: "FK_ManufacturingForms_GRLS_GrlsId",
                        column: x => x.GrlsId,
                        principalTable: "GRLS",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ManufacturingInfos",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    GrlsId = table.Column<int>(type: "integer", nullable: false),
                    Stage = table.Column<string>(type: "text", nullable: false),
                    Number = table.Column<string>(type: "text", nullable: false),
                    Address = table.Column<string>(type: "text", nullable: false),
                    Country = table.Column<string>(type: "text", nullable: false),
                    Manufacturer = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManufacturingInfos", x => x.id);
                    table.ForeignKey(
                        name: "FK_ManufacturingInfos_GRLS_GrlsId",
                        column: x => x.GrlsId,
                        principalTable: "GRLS",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NormativeDocs",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    GrlsId = table.Column<int>(type: "integer", nullable: false),
                    Year = table.Column<string>(type: "text", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Number = table.Column<string>(type: "text", nullable: false),
                    DocNumber = table.Column<string>(type: "text", nullable: false),
                    ChangeNumber = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NormativeDocs", x => x.id);
                    table.ForeignKey(
                        name: "FK_NormativeDocs_GRLS_GrlsId",
                        column: x => x.GrlsId,
                        principalTable: "GRLS",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PharmaceuticalSubstances",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    GrlsId = table.Column<int>(type: "integer", nullable: false),
                    Inn = table.Column<string>(type: "text", nullable: false),
                    Address = table.Column<string>(type: "text", nullable: false),
                    CertNum = table.Column<string>(type: "text", nullable: false),
                    ShelfLife = table.Column<string>(type: "text", nullable: false),
                    TradeName = table.Column<string>(type: "text", nullable: false),
                    Manufacturer = table.Column<string>(type: "text", nullable: false),
                    DrugsPresence = table.Column<string>(type: "text", nullable: false),
                    StorageConditions = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PharmaceuticalSubstances", x => x.id);
                    table.ForeignKey(
                        name: "FK_PharmaceuticalSubstances_GRLS_GrlsId",
                        column: x => x.GrlsId,
                        principalTable: "GRLS",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Packs",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ManufacturingFormId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Packs", x => x.id);
                    table.ForeignKey(
                        name: "FK_Packs_ManufacturingForms_ManufacturingFormId",
                        column: x => x.ManufacturingFormId,
                        principalTable: "ManufacturingForms",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AtgItems_GrlsId",
                table: "AtgItems",
                column: "GrlsId");

            migrationBuilder.CreateIndex(
                name: "IX_Instructions_GrlsId",
                table: "Instructions",
                column: "GrlsId");

            migrationBuilder.CreateIndex(
                name: "IX_ManufacturingForms_GrlsId",
                table: "ManufacturingForms",
                column: "GrlsId");

            migrationBuilder.CreateIndex(
                name: "IX_ManufacturingInfos_GrlsId",
                table: "ManufacturingInfos",
                column: "GrlsId");

            migrationBuilder.CreateIndex(
                name: "IX_NormativeDocs_GrlsId",
                table: "NormativeDocs",
                column: "GrlsId");

            migrationBuilder.CreateIndex(
                name: "IX_Packs_ManufacturingFormId",
                table: "Packs",
                column: "ManufacturingFormId");

            migrationBuilder.CreateIndex(
                name: "IX_PharmaceuticalSubstances_GrlsId",
                table: "PharmaceuticalSubstances",
                column: "GrlsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AtgItems");

            migrationBuilder.DropTable(
                name: "Instructions");

            migrationBuilder.DropTable(
                name: "ManufacturingInfos");

            migrationBuilder.DropTable(
                name: "NormativeDocs");

            migrationBuilder.DropTable(
                name: "Packs");

            migrationBuilder.DropTable(
                name: "PharmaceuticalSubstances");

            migrationBuilder.DropTable(
                name: "ManufacturingForms");

            migrationBuilder.DropTable(
                name: "GRLS");
        }
    }
}
