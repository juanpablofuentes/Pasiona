using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiestaAlumnos
{
    internal class Fiesta
    {
        public List<Alumno> listaAlumnos = new List<Alumno>();

        Predicate<Alumno> Admision;

        public Fiesta()
        {
            Admision = Aprobado;
        }
        public Fiesta(Predicate<Alumno> admision)
        {
            Admision = admision;
        }
        public Alumno this[int i]
        {
            get { return listaAlumnos[i]; }
            set
            {
                try
                {
                    if (Admision(value))
                    {
                        if (i >= listaAlumnos.Count)
                        {
                            listaAlumnos.Add(value);
                        }
                    }
                    else
                    {
                        listaAlumnos[i] = value;
                    }
                }
                catch (Exception) { }
            }
        }
        public int this[string nombre]
        {
            get
            {
                int result = -1;
                Alumno alumne;

                for (int i = 1; i < 11 && result == -1; i++)
                {
                    alumne = new Alumno(nombre, i);

                    for (int j = 0; j < listaAlumnos.LongCount(); j++)
                    {
                        if (alumne.GetHashCode() == listaAlumnos[j].GetHashCode())
                        {
                            result = j;
                        }
                    }

                }

                return result;
            }
        }
        public int this[string nombre, int nota]
        {
            get
            {
                int result = -1;

                Alumno alumne = new Alumno(nombre, nota);

                for (int i = 0; i < listaAlumnos.LongCount(); i++)
                {
                    if (alumne.GetHashCode() == listaAlumnos[i].GetHashCode())
                    {
                        result = i;
                    }
                }

                return result;
            }
        }


        public void Juego(Action<String> metodo)
        {
            foreach(var al in listaAlumnos)
            {
                metodo(al.Nombre);
            }
        }

        public void Proceso(Func<String,int,String> metodo)
        {
            foreach (var al in listaAlumnos)
            {
               Console.WriteLine(al.Nombre+" "+metodo(al.Nombre, al.Nota));
            }
        }
        public override string ToString()
        {
            return String.Join(",", listaAlumnos);
        }

        private bool Aprobado(Alumno alumno)
        {
            return alumno.Nota >= 5;
        }
    }
}
