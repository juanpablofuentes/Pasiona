
using EjemplosHerencia;
Console.OutputEncoding = System.Text.Encoding.UTF8;
Cuadrado c = new Cuadrado(2);

c.Dibujar();
Console.WriteLine(c.area());

Circulo e = new Circulo(1);
e.Dibujar();
Console.WriteLine(e.area());