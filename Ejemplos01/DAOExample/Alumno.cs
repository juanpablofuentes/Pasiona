using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOExample
{
    internal class Alumno
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Nota { get; set; }
        public DateTime Inscripcion { get; set; }
        public string Email { get; set; }
        public List<Falta> Faltas { get; set; }

        public Alumno(int id, string nombre, int nota, DateTime inscripcion, string email)
        {
            Id = id;
            Nombre = nombre;
            Nota = nota;
            Inscripcion = inscripcion;
            Email = email;
            // TODO: Una vez creada la lógica de faltas obtener todas las faltas del alumno
        }
        public override string ToString()
        {
            return Id+" - "+Nombre+" - "+Nota+" - "+Email;
        }
    }
}
