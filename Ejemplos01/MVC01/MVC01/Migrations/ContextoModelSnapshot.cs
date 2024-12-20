﻿// <auto-generated />
using MVC01.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MVC01.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MVC01.Models.Alumno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Nota")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Alumnos");
                });

            modelBuilder.Entity("MVC01.Models.AlumnoCurso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AlumnoId")
                        .HasColumnType("int");

                    b.Property<int>("CursoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AlumnoId");

                    b.HasIndex("CursoId");

                    b.ToTable("AlumnoCurso");
                });

            modelBuilder.Entity("MVC01.Models.Curso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Curso");
                });

            modelBuilder.Entity("MVC01.Models.AlumnoCurso", b =>
                {
                    b.HasOne("MVC01.Models.Alumno", "Alumno")
                        .WithMany("Cursos")
                        .HasForeignKey("AlumnoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MVC01.Models.Curso", "Curso")
                        .WithMany()
                        .HasForeignKey("CursoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Alumno");

                    b.Navigation("Curso");
                });

            modelBuilder.Entity("MVC01.Models.Alumno", b =>
                {
                    b.Navigation("Cursos");
                });
#pragma warning restore 612, 618
        }
    }
}
