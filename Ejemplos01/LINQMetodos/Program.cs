using LinqBasico;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Text.RegularExpressions;
using System;

namespace LINQMetodos
{
    internal class Program
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

            //Filtrar(Where):   Seleccionar alumnos mayores de 25 años.

            var mayoresDe25 = listaAlumnos.Where(alumno => alumno.Edad > 25).ToList();

            // Ordenar(OrderBy, ThenBy):    Ordenar alumnos por edad y luego por nombre.

            var ordenados = listaAlumnos.OrderBy(alumno => alumno.Edad).ThenBy(alumno => alumno.Nombre).ToList();

            // 3.Seleccionar(Select):   Obtener solo los nombres de los alumnos.

            var nombres = listaAlumnos.Select(alumno => alumno.Nombre).ToList();

            // 4.Proyección(Select):   Crear una lista de objetos anónimos con nombres y edades.

            var proyeccion = listaAlumnos.Select(alumno => new { Nombre = alumno.Nombre, Edad = alumno.Edad }).ToList();

            foreach(var elemento in proyeccion)
            {
                Console.WriteLine(elemento.Nombre+" - "+ elemento.Edad);
            }
            // 5.Agregación(Count, Sum, Average, Min, Max):
            // Contar el número de alumnos.

            var cantidadAlumnos = listaAlumnos.Count();

            // Calcular la suma de las edades.

            var sumaEdades = listaAlumnos.Sum(alumno => alumno.Edad);

            // Calcular el promedio de las notas.

            var promedioNotas = listaAlumnos.Average(alumno => alumno.Nota);

            // Obtener la edad mínima y máxima.

            var edadMinima = listaAlumnos.Min(alumno => alumno.Edad);
            var edadMaxima = listaAlumnos.Max(alumno => alumno.Edad);

            // 6.Agrupar(GroupBy):    Agrupar alumnos por edad.

            var gruposPorEdad = listaAlumnos.GroupBy(alumno => alumno.Edad);

            // 7.Filtrar y Proyectar(Where, Select):    Obtener nombres de alumnos mayores de 25 años.

            var nombresMayoresDe25 = listaAlumnos
                .Where(alumno => alumno.Edad > 25)
                .Select(alumno => alumno.Nombre)
                .ToList();

            // 8.Unión(Concat):    Unir dos listas de alumnos.

            var otraLista = new List<Alumno> { new Alumno("Sara", 28, 8.5), new Alumno("David", 25, 6.7) };

            var listaCombinada = listaAlumnos.Concat(otraLista).ToList();

            // 9.Buscar(FirstOrDefault, LastOrDefault):    Obtener el primer alumno mayor de 30 años.

            var primerMayorDe30 = listaAlumnos.FirstOrDefault(alumno => alumno.Edad > 30);

            /// Obtener el último alumno con una nota mayor a 7.

            var ultimoNotaMayor7 = listaAlumnos.LastOrDefault(alumno => alumno.Nota > 7);

            // 10.Existencia(Any, All):
            //Verificar si hay algún alumno con edad menor de 18.

            var hayMenorDe18 = listaAlumnos.Any(alumno => alumno.Edad < 18);

            //     Verificar si todos los alumnos tienen una nota mayor a 5.

            var todosAprobados = listaAlumnos.All(alumno => alumno.Nota > 5);

            // Tomar un número específico de elementos(Take):   Obtener los primeros 3 alumnos de la lista.

            var primerosTresAlumnos = listaAlumnos.Take(3).ToList();

            // Tomar los alumnos mayores de 25 años y limitar a los primeros 2.

            var mayoresDe25_2 = listaAlumnos.Where(alumno => alumno.Edad > 25).Take(2).ToList();

            // .Saltar un número específico de elementos(Skip):   Saltar los primeros 2 alumnos de la lista.

            var alumnosDespuesDeDos = listaAlumnos.Skip(2).ToList();

            // Obtener los alumnos mayores de 25 años después de saltar los primeros 1.

            var mayoresDespuesDeUno = listaAlumnos.Where(alumno => alumno.Edad > 25).Skip(1).ToList();

            //.Combinar Take y Skip para paginación:  Obtener la segunda página de 3 alumnos cada una.

            int pageSize = 3;
            int pageNumber = 2;

            var pagina = listaAlumnos.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();


        }
    }
}