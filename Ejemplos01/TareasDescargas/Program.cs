using System.Net;

namespace TareasDescargas
{
    internal class Program
    {
        static async Task Main()
        {
            List<string> urls = new List<string>
        {
            "https://files.icyflamestudio.com/200MB.zip",
            "https://files.icyflamestudio.com/512MB.zip",
            "https://files.icyflamestudio.com/1GB.bin",
            "https://files.icyflamestudio.com/100MB.bin"
                };

            // Creamos una lista para almacenar las tareas
            List<Task> downloadTasks = new List<Task>();

            foreach (var url in urls)
            {
                // Creamos una tarea para cada descarga
                
                downloadTasks.Add(DownloadFileAsync(url));

                Console.WriteLine($"Descarga de {url} iniciada.");
            }
            Console.WriteLine("Todas las descargas iniciadas. Seguiríamos con el programa principal.");

            // Esperamos a que todas las tareas hayan terminado antes de continuar
            await Task.WhenAll(downloadTasks);

            Console.WriteLine("Todas las descargas acabadas."); ;
        }
        static async Task DownloadFileAsync(string url)
        {
            using (WebClient client = new WebClient())
            {
                // Puedes modificar la ruta y el nombre del archivo según tus necesidades
                string fileName = $"downloaded_file_{Guid.NewGuid()}.txt";


                Console.WriteLine($"En proceso de descarga de {url}...");

                // Descargamos el archivo de forma asíncrona
                await client.DownloadFileTaskAsync(new Uri(url), fileName);

                Console.WriteLine($"Descarga de {url} completada.");
            }
        }
    }
}