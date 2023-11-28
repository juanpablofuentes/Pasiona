namespace Hilos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ejemplo de hilo normal
            Thread myThread = new Thread(MyThreadFunction);
            myThread.Start();
            Console.WriteLine("Main 1 thread is running.");

            Thread myThread2 = new Thread(MyThreadFunctionWithParam);
            myThread2.Start("Hello from the secondary thread!");
            Console.WriteLine("Main 2 thread is running.");

            Thread myThread3 = new Thread(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Hilo anónimo.");
            });
            myThread3.Start();
            Console.WriteLine("Main 3 thread is running.");

            Thread myThread4 = new Thread(MyThreadFunction);
            myThread4.Start();
            
            myThread4.Join(); // Esperar el hilo
            Console.WriteLine("Main 4 thread is running.");
        }
        static void MyThreadFunction()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Hilo secundario fin");
        }

        static void MyThreadFunctionWithParam(object? message)
        {
            Thread.Sleep(1000);
            Console.WriteLine($"Hilo secundario mensaje: {message}");
        }


        
    }
}