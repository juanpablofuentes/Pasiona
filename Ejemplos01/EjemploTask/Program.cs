namespace EjemploTask
{
    internal class Program
    {
        public static async Task Main()
        {
            Task task1 = Task.Run(() => DoWork(1));
            Task task2 = Task.Run(() => DoWork(2));
            Task task3 = Task.Run(() => DoWork(3));
            Console.WriteLine("Antes del await");
            await Task.WhenAll(task1, task2, task3);

            Console.WriteLine("All work complete.");
        }

        public static void DoWork(int id)
        {
            Console.WriteLine("Working on task {0}...", id);
            Task.Delay(1000).Wait();
            Console.WriteLine("Task {0} complete.", id);
        }
    }
}