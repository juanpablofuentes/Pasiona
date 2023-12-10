using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOExample
{
    internal class Faltav1
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string Comentario { get; set; }
        public int IdAlumno { get; set; }

        public Faltav1(int id, DateTime fecha, string comentario, int idalumno)
        {
            Id = id;
            Fecha = fecha;
            Comentario = comentario;
            IdAlumno = idalumno;
        }
        public override string ToString()
        {
            return Id + " - " + Fecha + " - " + Comentario ;
        }
    }
}
