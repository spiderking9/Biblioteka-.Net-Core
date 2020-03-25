﻿// <auto-generated />
using Biblioteczka.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Biblioteczka.Migrations
{
    [DbContext(typeof(KsiazkiContext))]
    [Migration("20200323155808_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Biblioteczka.Models.Ksiazki", b =>
                {
                    b.Property<int>("KsiazkaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Autor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Categoria")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("CzyDostepna")
                        .HasColumnType("bit");

                    b.Property<string>("Tytul")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KsiazkaID");

                    b.ToTable("Ksiazkis");
                });
#pragma warning restore 612, 618
        }
    }
}