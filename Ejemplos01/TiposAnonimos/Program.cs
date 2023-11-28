namespace TiposAnonimos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tipos anónimos son objetos que se crean bajo demanda en tiempo
            // de ejecución sin una clase que los defina
            // El compilador detecta los tipos automáticamente

            var a = 5;

            var v = new { Amount = 108, Message = "Hello" };

            Console.WriteLine(v);
            Console.WriteLine(v.Message);
            Console.WriteLine(v.Amount);

            var products = new[]
            {
                new { Name = "Apple", Color = "Red", Price = 0.99m },
                new { Name = "Banana", Color = "Yellow", Price = 0.79m },
                new { Name = "Grape", Color = "Purple", Price = 1.29m }
            };

            var productQuery = from prod in products
                               where prod.Price>1
                               select prod.Name;

            foreach (var prod in productQuery)
            {
               Console.WriteLine(prod);
            }

            var productQuery2 = from prod in products
                               where prod.Price > 1
                               select new { Nombre = prod.Name,
                                   Precio = prod.Price };

            foreach (var prod in productQuery2)
            {
                Console.WriteLine(prod.Nombre+" - "+prod.Precio);
            }
        }
    }
}