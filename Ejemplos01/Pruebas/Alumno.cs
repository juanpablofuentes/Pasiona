using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    internal class Alumno
    {
        public string Nombre { get; set; }
        public int Nota { get; set; }

        public Alumno(string nombre,int nota)
        {
            Nombre = nombre;
            Nota = nota;
        }

        public override string ToString()
        {
            return Nombre+" "+Nota;
        }

        public override bool Equals(object? obj)
        {
            //if (obj is Alumno)
            //{
            //    Alumno alum = (Alumno)obj;
            //    return alum.Nombre == Nombre && alum.Nota == Nota;
            //}
            //else
            //{
            //    return false;
            //}

            //Alumno alum2 = obj as Alumno;
            
            //if (alum2!=null)
            //{
            //    return alum2.Nombre == Nombre && alum2.Nota == Nota;
            //}
            //else
            //{
            //    return false;
            //}

            //return alum2?.Nota == Nota && alum2?.Nombre == Nombre;

            return obj is Alumno alumno &&
                   Nombre == alumno.Nombre &&
                   Nota == alumno.Nota;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode()+HashCode.Combine(Nombre,Nota);
        }
    }
}
