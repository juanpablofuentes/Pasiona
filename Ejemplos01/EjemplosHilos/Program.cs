namespace EjemplosHilos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Thread t = new Thread(DoWork);
                t.Start(i);
            }
        }

        public static void DoWork(object data)
        {
            int id = (int)data;
            Console.WriteLine("Working on task {0}...", id);
            Thread.Sleep(1000);
            Console.WriteLine("Task {0} complete.", id);
        }
    }
}