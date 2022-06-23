using JuegosCartas;


Mus2 JuegoMus = new Mus2(new Jugador("Rosa"), new Jugador("Luis"), new Jugador("Eva"), new Jugador("Ana"));

Console.WriteLine(JuegoMus);
Console.WriteLine("---");
Console.WriteLine(JuegoMus.AGrande());
Console.WriteLine("---");
Console.WriteLine(JuegoMus.APequenya());

Console.WriteLine("---");
Console.WriteLine(JuegoMus.APares());
Console.WriteLine("---");
Console.WriteLine(JuegoMus.AJuego());
Console.WriteLine("---");
