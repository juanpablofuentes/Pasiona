﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlumnosCursos
{
    internal class Contexto:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=pasiona;Trusted_Connection=True;");
            }
        }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Alumno> Alumnos{ get; set; }
        public DbSet<Profesor> Profesores{ get; set; }
        public DbSet<Asignatura> Asignaturas{ get; set; }
        public DbSet<Curso_Asignatura> Cursos_Asignaturas { get; set; }
        public DbSet<Book> Book{ get; set; }
        public DbSet<CursoAsig> CursoAsigs{ get; set; }
    }
}
