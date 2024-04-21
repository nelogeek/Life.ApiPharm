﻿// <auto-generated />
using Life.ApiPharm;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Life.ApiPharm.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240414172425_UpdateDb2")]
    partial class UpdateDb2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Life.ApiPharm.AtgItemDb", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("GrlsId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.HasIndex("GrlsId");

                    b.ToTable("AtgItems");
                });

            modelBuilder.Entity("Life.ApiPharm.GRLS", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("CancelDate")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CertNum")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CirculationPeriod")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ExpDate")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("HolderCountry")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("HolderName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Inn")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsFs")
                        .HasColumnType("boolean");

                    b.Property<string>("IsInterchangeable")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("IsLifeImportant")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("IsNarcotic")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("OrphanDate")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("RegDate")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("RenewDate")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("TradeName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("id_grls")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("GRLS");
                });

            modelBuilder.Entity("Life.ApiPharm.InstructionDb", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("Filename")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("GrlsId")
                        .HasColumnType("integer");

                    b.Property<int>("IdReg")
                        .HasColumnType("integer");

                    b.Property<string>("InstructionFolderPath")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("InstructionLabel")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Label")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Section")
                        .HasColumnType("integer");

                    b.Property<string>("SourceName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("SourceUrl")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.HasIndex("GrlsId");

                    b.ToTable("Instructions");
                });

            modelBuilder.Entity("Life.ApiPharm.ManufacturingFormDb", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("Dose")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Form")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("GrlsId")
                        .HasColumnType("integer");

                    b.Property<string>("Packs")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ShelfLife")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("StorageConditions")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.HasIndex("GrlsId");

                    b.ToTable("ManufacturingForms");
                });

            modelBuilder.Entity("Life.ApiPharm.ManufacturingInfoDb", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("GrlsId")
                        .HasColumnType("integer");

                    b.Property<string>("Manufacturer")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Stage")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.HasIndex("GrlsId");

                    b.ToTable("ManufacturingInfos");
                });

            modelBuilder.Entity("Life.ApiPharm.NormativeDocDb", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("ChangeNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("DocNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("GrlsId")
                        .HasColumnType("integer");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Year")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.HasIndex("GrlsId");

                    b.ToTable("NormativeDocs");
                });

            modelBuilder.Entity("Life.ApiPharm.Pack", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<int>("ManufacturingFormId")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.HasIndex("ManufacturingFormId");

                    b.ToTable("Packs");
                });

            modelBuilder.Entity("Life.ApiPharm.PharmaceuticalSubstanceDb", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CertNum")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("DrugsPresence")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("GrlsId")
                        .HasColumnType("integer");

                    b.Property<string>("Inn")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Manufacturer")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ShelfLife")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("StorageConditions")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("TradeName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.HasIndex("GrlsId");

                    b.ToTable("PharmaceuticalSubstances");
                });

            modelBuilder.Entity("Life.ApiPharm.AtgItemDb", b =>
                {
                    b.HasOne("Life.ApiPharm.GRLS", "Grls")
                        .WithMany()
                        .HasForeignKey("GrlsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Grls");
                });

            modelBuilder.Entity("Life.ApiPharm.InstructionDb", b =>
                {
                    b.HasOne("Life.ApiPharm.GRLS", "Grls")
                        .WithMany()
                        .HasForeignKey("GrlsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Grls");
                });

            modelBuilder.Entity("Life.ApiPharm.ManufacturingFormDb", b =>
                {
                    b.HasOne("Life.ApiPharm.GRLS", "Grls")
                        .WithMany()
                        .HasForeignKey("GrlsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Grls");
                });

            modelBuilder.Entity("Life.ApiPharm.ManufacturingInfoDb", b =>
                {
                    b.HasOne("Life.ApiPharm.GRLS", "Grls")
                        .WithMany()
                        .HasForeignKey("GrlsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Grls");
                });

            modelBuilder.Entity("Life.ApiPharm.NormativeDocDb", b =>
                {
                    b.HasOne("Life.ApiPharm.GRLS", "Grls")
                        .WithMany()
                        .HasForeignKey("GrlsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Grls");
                });

            modelBuilder.Entity("Life.ApiPharm.Pack", b =>
                {
                    b.HasOne("Life.ApiPharm.ManufacturingFormDb", "ManufacturingForm")
                        .WithMany()
                        .HasForeignKey("ManufacturingFormId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ManufacturingForm");
                });

            modelBuilder.Entity("Life.ApiPharm.PharmaceuticalSubstanceDb", b =>
                {
                    b.HasOne("Life.ApiPharm.GRLS", "Grls")
                        .WithMany()
                        .HasForeignKey("GrlsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Grls");
                });
#pragma warning restore 612, 618
        }
    }
}
