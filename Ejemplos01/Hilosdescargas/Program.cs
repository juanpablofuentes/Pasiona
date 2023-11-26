using System.Net;

namespace Hilosdescargas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> urls = new List<string>
        {
            "https://files.icyflamestudio.com/200MB.zip",
            "https://files.icyflamestudio.com/512MB.zip",
            "https://files.icyflamestudio.com/1GB.bin",
            "https://files.icyflamestudio.com/100MB.bin"
            // Agrega más URLs según sea necesario
        };

            // Creamos una lista para almacenar los hilos
            List<Thread> threads = new List<Thread>();

            foreach (var url in urls)
            {
                // Creamos un hilo para cada descarga
                Thread downloadThread = new Thread(() => DownloadFile(url));
                threads.Add(downloadThread);

                // Iniciamos el hilo
                downloadThread.Start();

                Console.WriteLine($"Descarga de {url} iniciada.");
            }
            Console.WriteLine("Todas las descargas iniciadas. Seguiríamos con el programa principal.");

            // Esperamos a que todos los hilos hayan terminado antes de continuar
            foreach (var thread in threads)
            {
                thread.Join();
            }

            Console.WriteLine("Todas las descargas acabadas.");

        }
        static void DownloadFile(string url)
        {
            using (WebClient client = new WebClient())
            {
                // Puedes modificar la ruta y el nombre del archivo según tus necesidades
                string fileName = $"downloaded_file_{Guid.NewGuid()}.txt";

                Console.WriteLine($"En proceso de descarga de {url}...");

                // Descargamos el archivo
                client.DownloadFile(url, fileName);

                Console.WriteLine($"Descarga de {url} completada.");
            }
        }
    }
}