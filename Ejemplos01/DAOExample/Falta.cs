using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOExample
{
    internal class Falta
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string Comentario { get; set; }
        public int IdAlumno { get; set; }
        public Alumno Alumno { get; set; }

        public Falta(int id, DateTime fecha, string comentario, int idalumno)
        {
            Id = id;
            Fecha = fecha;
            Comentario = comentario;
            IdAlumno = idalumno;
            AlumnoDAO adao=new AlumnoDAO(ConnectionDB.connection);
            Alumno = adao.getAlumno(idalumno);
        }
        public override string ToString()
        {
            return Id + " - " + Fecha + " - " + Comentario ;
        }
    }
}
