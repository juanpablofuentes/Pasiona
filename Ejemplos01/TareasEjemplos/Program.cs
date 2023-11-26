using System.Diagnostics;

namespace TareasEjemplos
{
    internal class Program
    {
        public static async Task Main()
        {
            Task task1 = Task.Run(() => DoWork(1));
            Task task2 = Task.Run(() => DoWork(2));
            Task task3 = Task.Run(() => DoWork(3));

            await Task.WhenAll(task1, task2, task3);

            Console.WriteLine("Todo acabado.");

            List<Task> lista = new List<Task>();
            for(int i=0;i<10; i++)
            {
                lista.Add(DoWorkAsync(i));
            }
            Console.WriteLine("Tareas lanzadas");

            await Task.WhenAll(lista);

            Console.WriteLine("Tareas acabadas");
        }
        public static void DoWork(int id)
        {
            Console.WriteLine("Ejecutando tarea {0}...", id);
            Task.Delay((new Random()).Next(2000)).Wait();
            Console.WriteLine("Tarea {0} completa.", id);
        }
        public static async Task DoWorkAsync(int id)
        {
            Console.WriteLine("Ejecutando tarea {0}...", id);
            await Task.Delay((new Random()).Next(5000));
            Console.WriteLine("Tarea {0} completa.", id);

        }
    }
}