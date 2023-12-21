using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDatos
{
    public class Curso
    {
        [Key] public int Id { get; set; }
        public string Titulo { get; set; }
        public int Creditos { get; set; }
        public virtual ObservableCollectionListSource<Alumno> Alumnos { get; set; } = new();
    }
}
