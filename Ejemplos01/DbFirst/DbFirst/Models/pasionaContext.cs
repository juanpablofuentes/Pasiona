using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DbFirst.Models
{
    public partial class pasionaContext : DbContext
    {
        public pasionaContext()
        {
        }

        public pasionaContext(DbContextOptions<pasionaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Alumno> Alumnos { get; set; } = null!;
        public virtual DbSet<Asignatura> Asignaturas { get; set; } = null!;
        public virtual DbSet<Book> Books { get; set; } = null!;
        public virtual DbSet<Course> Courses { get; set; } = null!;
        public virtual DbSet<Curso> Cursos { get; set; } = null!;
        public virtual DbSet<CursosAsignatura> CursosAsignaturas { get; set; } = null!;
        public virtual DbSet<Profesore> Profesores { get; set; } = null!;
        public virtual DbSet<Student> Students { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=pasiona;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alumno>(entity =>
            {
                entity.HasIndex(e => e.CursoId, "IX_Alumnos_CursoId");

                entity.Property(e => e.Dni).HasColumnName("DNI");

                entity.HasOne(d => d.Curso)
                    .WithMany(p => p.Alumnos)
                    .HasForeignKey(d => d.CursoId);
            });

            modelBuilder.Entity<Asignatura>(entity =>
            {
                entity.Property(e => e.Tiempo).HasColumnName("tiempo");
            });

            modelBuilder.Entity<Book>(entity =>
            {
                entity.ToTable("Books", "test");
            });

            modelBuilder.Entity<Curso>(entity =>
            {
                entity.HasIndex(e => e.ProfesorId, "IX_Cursos_ProfesorId");

                entity.HasOne(d => d.Profesor)
                    .WithMany(p => p.Cursos)
                    .HasForeignKey(d => d.ProfesorId);
            });

            modelBuilder.Entity<CursosAsignatura>(entity =>
            {
                entity.ToTable("Cursos_Asignaturas");

                entity.HasIndex(e => e.AsignaturaId, "IX_Cursos_Asignaturas_AsignaturaId");

                entity.HasIndex(e => e.CursoId, "IX_Cursos_Asignaturas_CursoId");

                entity.HasOne(d => d.Asignatura)
                    .WithMany(p => p.CursosAsignaturas)
                    .HasForeignKey(d => d.AsignaturaId);

                entity.HasOne(d => d.Curso)
                    .WithMany(p => p.CursosAsignaturas)
                    .HasForeignKey(d => d.CursoId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
