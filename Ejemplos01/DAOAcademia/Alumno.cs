using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOAcademia
{
    
     class Alumno
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string DNI { get; set; }
        public string Email { get; set; }

        public Alumno(int id, string nombre, string dni, string email)
        {
            Id = id;
            Nombre = nombre;
            DNI = dni;
            Email = email;
        }
        public override string ToString()
        {
            return Id+" - "+Nombre+" - "+DNI+" - "+Email;
        }
    }
}
