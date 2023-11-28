using Pruebas;

Alumno ana = new Alumno("Ana Pi", 8);

Console.WriteLine(ana.ToString());
Console.WriteLine(ana.GetType());
Console.WriteLine(ana.GetHashCode());

Alumno juan = new Alumno("Ana Pi", 8);

Console.WriteLine(juan);

Alumno pepe = new Alumno(ana.Nombre, ana.Nota);

Console.WriteLine(juan.GetHashCode());
Console.WriteLine(pepe.GetHashCode());

Console.WriteLine(ana.Equals(juan));
Console.WriteLine(ana.Equals(pepe));

var products = new[] { new { Name = "Apple", Color = "Red", Price = 0.99m }, new  { Name = "Banana", Color = "Yellow", Price = 0.79m }, new  { Name = "Grape", Color = "Purple", Price = 1.29m } }; 
var productQuery = from prod in products select new { prod.Color, prod.Price }; 
foreach (var v in productQuery) { Console.WriteLine($"Color: {v.Color}, Price: {v.Price}"); }