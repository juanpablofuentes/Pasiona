using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DBFirstTest.Models;

public partial class PruebasContext : DbContext
{
    public PruebasContext()
    {
    }

    public PruebasContext(DbContextOptions<PruebasContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Alumno> Alumnos { get; set; }

    public virtual DbSet<City> Cities { get; set; }

    public virtual DbSet<Country> Countries { get; set; }

    public virtual DbSet<Curso> Cursos { get; set; }

    public virtual DbSet<Falta> Faltas { get; set; }

    public virtual DbSet<Profesore> Profesores { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-B3NEDPH;Initial Catalog=pruebas;Integrated Security=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Alumno>(entity =>
        {
            entity.ToTable("alumno");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Email)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Inscripcion)
                .HasColumnType("date")
                .HasColumnName("inscripcion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Nota).HasColumnName("nota");
        });

        modelBuilder.Entity<City>(entity =>
        {
            entity.HasIndex(e => e.CountryId, "IX_Cities_CountryId");

            entity.Property(e => e.CityName).HasMaxLength(50);

            entity.HasOne(d => d.Country).WithMany(p => p.Cities).HasForeignKey(d => d.CountryId);
        });

        modelBuilder.Entity<Country>(entity =>
        {
            entity.Property(e => e.CountryName).HasMaxLength(50);
        });

        modelBuilder.Entity<Falta>(entity =>
        {
            entity.ToTable("faltas");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Comentario)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("comentario");
            entity.Property(e => e.Fecha)
                .HasColumnType("date")
                .HasColumnName("fecha");
            entity.Property(e => e.Idalumno).HasColumnName("idalumno");

            entity.HasOne(d => d.IdalumnoNavigation).WithMany(p => p.Falta)
                .HasForeignKey(d => d.Idalumno)
                .HasConstraintName("FK_faltas_alumno");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
