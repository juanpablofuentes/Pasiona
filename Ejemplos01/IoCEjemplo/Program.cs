using Microsoft.Extensions.DependencyInjection;

namespace IoCEjemplo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Inyectamos la dependencia directamente
            Inyectada prueba1 = new Inyectada(new SaludoConsola());
            Inyectada prueba2 = new Inyectada(new SaludoFichero());

            prueba1.saludar("Ana");
            prueba2.saludar("Ana");

            // Con contenedor

            // Registrar la dependencia en el contenedor
            var services = new ServiceCollection();
            services.AddTransient<ISaludo, SaludoConsola>();
            services.AddTransient<Inyectada>();
            // Crear el contenedor
            var serviceProvider = services.BuildServiceProvider();

            // Obtener una instancia de MyClass con la dependencia inyectada
            var prueba3 = serviceProvider.GetService<Inyectada>();
            prueba3?.saludar("Ana");

            services.AddSingleton<ISaludo, SaludoFichero>();

            // Crea una instancia de Inyectada
            var inyectada = services.BuildServiceProvider().GetService<Inyectada>();

            // Llama al método saludar()
            inyectada.saludar("Juan");

            // Llama al método saludar() de nuevo
            inyectada.saludar("Pedro");

            services.AddSingleton<IGetNumber, NumeroFijo>();
            services.AddSingleton<Ruleta>();
            serviceProvider = services.BuildServiceProvider();
            var miRuleta = serviceProvider.GetService<Ruleta>();
            var otraRuleta = serviceProvider.GetService<Ruleta>();

            miRuleta?.tirada();
            Console.WriteLine(otraRuleta);
        }
    }
}