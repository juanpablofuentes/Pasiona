﻿// <auto-generated />
using System;
using Comics;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Comics.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20190902105359_ComicInicio")]
    partial class ComicInicio
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Comics.Autor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AnyNacimiento");

                    b.Property<string>("Nacionalidad");

                    b.Property<string>("Nombre");

                    b.HasKey("Id");

                    b.ToTable("Autor");
                });

            modelBuilder.Entity("Comics.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion");

                    b.Property<string>("Nombre");

                    b.HasKey("Id");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("Comics.Comic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoriaId");

                    b.Property<string>("Descripcion");

                    b.Property<DateTime>("Fecha");

                    b.Property<string>("Titulo");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.ToTable("Comic");
                });

            modelBuilder.Entity("Comics.ComicAutor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AutorId");

                    b.Property<int>("ComicId");

                    b.HasKey("Id");

                    b.HasIndex("AutorId");

                    b.HasIndex("ComicId");

                    b.ToTable("ComicAutor");
                });

            modelBuilder.Entity("Comics.Comic", b =>
                {
                    b.HasOne("Comics.Categoria", "Categoria")
                        .WithMany("Comics")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Comics.ComicAutor", b =>
                {
                    b.HasOne("Comics.Autor", "Autor")
                        .WithMany("ComicAutor")
                        .HasForeignKey("AutorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Comics.Comic", "Comic")
                        .WithMany("ComicAutor")
                        .HasForeignKey("ComicId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
