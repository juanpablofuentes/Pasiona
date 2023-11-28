using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqBasico
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Alumno> listaAlumnos = new List<Alumno>()
    {
        new Alumno("Eva",20,6.0),
        new Alumno("Ana",22,7.0),
        new Alumno("Rosa",22,4.0),
        new Alumno("Ot",20,3.0),
        new Alumno("Iu",30,6.8),
        new Alumno("Pep",32,5.9),
        new Alumno("Laia",30,2.3),
        new Alumno("Quim",32,1.7),
    };
            //  Seleccionamos todos los alumnos (devuelve un IEnumerable de  tipo Alumno
            var res = from alumno in listaAlumnos select alumno;
           
            Console.WriteLine(String.Join(",", res));
            //  Seleccionamos sólo el nombre de los alumnos (devuelve un IEnumerable de tipo string
            var res2 = from alumno in listaAlumnos select alumno.Nombre;
           
            Console.WriteLine(String.Join(",", res2));
            //Sólo los aprobados
            res = from alumno in listaAlumnos where alumno.Nota >= 5 select alumno;

            Console.WriteLine(String.Join(" | ", res));
            listaAlumnos.Add(new Alumno("Einstein", 50, 10));
            //Vuelve a ejecutarse la consulta LINQ
            Console.WriteLine(String.Join(" | ", res));

            //Ejecución inmediata
            List<Alumno> inmediato = (from alumno in listaAlumnos where alumno.Nota >= 5 select alumno).ToList<Alumno>();
            //Podemos usar las funciones de los enumerables
            Console.WriteLine(res.Count());

            Console.WriteLine(String.Join(" | ", res.Reverse()));
            //Ordenadr ascendente o descendente
            res = from alumno in listaAlumnos 
                  where alumno.Nota >= 5 
                  orderby alumno.Nota descending 
                  select alumno;
            Console.WriteLine(String.Join(" | ", res));


            //Agrupando
            var agrupado = from alumno in listaAlumnos 
                           group alumno by alumno.Nombre.Length;
            Console.WriteLine(String.Join(",", agrupado.First()));
            Console.WriteLine(agrupado.Count());
            foreach (var grupo in agrupado)
            {
                Console.WriteLine("Agrupado por el valor: " + grupo.Key + " valores " + grupo.Count());
                foreach (Alumno al in grupo)
                {
                    Console.WriteLine(al);
                }
            }

            agrupado = from alumno in listaAlumnos 
                       group alumno by alumno.Edad into g 
                       orderby g.Key descending select g;
            foreach (var grupo in agrupado)
            {
                Console.WriteLine("Agrupado por el valor: " + grupo.Key);
                foreach (Alumno al in grupo)
                {
                    Console.WriteLine(al);
                }
            }
            Console.WriteLine("-----");
            agrupado = from alumno in listaAlumnos 
                       group alumno by alumno.Nombre.Length into g 
                       where g.Sum(al => al.Nota) > 10 
                       orderby g.Key descending select g;
            foreach (var grupo in agrupado)
            {
                Console.WriteLine("Agrupado por el valor: " + grupo.Key);
                Console.WriteLine(String.Join(",", grupo));
            }



            // Obtener los nombres y edades de los alumnos mayores de 25 años,
            // ordenados por edad de forma descendente, y mostrar solo los primeros 3 resultados.



            var consultaCompleja = (from alumno in listaAlumnos
                                    where alumno.Edad > 25
                                    orderby alumno.Edad descending
                                    select new { alumno.Nombre, alumno.Edad })
                                    .Take(3)
                                    .ToList();

            // Agrupar los alumnos por edad y calcular el promedio de notas
            // para cada grupo.

            var agrupacionPromedio = from alumno in listaAlumnos
                                     group alumno by alumno.Edad into grupos
                                     select new
                                     {
                                         Edad = grupos.Key,
                                         PromedioNotas = grupos.Average(a => a.Nota)
                                     };

            //    Realizar una consulta que combine la lista de alumnos con otra
            //    lista, utilizando join y seleccionando solo aquellos que tienen
            //    una nota mayor a 5.



            var otraListaAlumnos = new List<Alumno> { new Alumno("Eva", 20, 8.0), new Alumno("Ana", 22, 6.5), new Alumno("Rosa", 22, 4.5) };

            var resultadoJoin = from alumno in listaAlumnos
                                join otraLista in otraListaAlumnos on alumno.Nombre equals otraLista.Nombre
                                where otraLista.Nota > 5
                                select new { alumno.Nombre, alumno.Nota, NotaOtraLista = otraLista.Nota };

            //    Utilizar la claúsula let para calcular la edad ajustada de cada
            //    alumno y seleccionar aquellos cuya edad ajustada sea mayor a 25.



            var consultaLet = from alumno in listaAlumnos
                              let edadAjustada = alumno.Edad + 5
                              where edadAjustada > 25
                              select new { alumno.Nombre, EdadAjustada = edadAjustada };

            //            Filtrar los alumnos mayores de 25 años cuya nota
            //            sea mayor a 5, ordenados por edad de forma ascendente y
            //            luego por nota de forma descendente.



            var consultaConCondiciones = from alumno in listaAlumnos
                                         where alumno.Edad > 25 && alumno.Nota > 5
                                         orderby alumno.Edad, alumno.Nota descending
                                         select alumno;

            var mejorAlumno = (from alumno in listaAlumnos
                               orderby alumno.Nota descending
                               select alumno).First();
            // Encuentra el nombre y la edad de los alumnos que tienen una nota
            // superior a 5 y que no tienen el mismo nombre que ningún otro alumno.
            var alumnosUnicosConBuenasNotas = (from alumno in listaAlumnos
                                               where alumno.Nota > 5
                                               group alumno by alumno.Nombre into grupo
                                               where grupo.Count() == 1
                                               select grupo);

            Console.ReadLine();
        }
    }
}

