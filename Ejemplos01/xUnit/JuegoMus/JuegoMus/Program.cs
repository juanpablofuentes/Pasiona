using JuegosCartas;


Mus JuegoMus = new Mus(new Jugador("Rosa"), new Jugador("Luis"), new Jugador("Eva"), new Jugador("Ana"));

Console.WriteLine(JuegoMus);
Console.WriteLine("---");
Console.WriteLine(JuegoMus.AGrande());
Console.WriteLine("---");
Console.WriteLine(JuegoMus.APequenya());

Console.WriteLine("---");
Console.WriteLine(JuegoMus.APares());
Console.WriteLine("---");
Console.WriteLine(JuegoMus.AJuego());
Console.WriteLine(JuegoMus.NumJuego(JuegoMus.AJuego().Mano.Select(x=>x.Valor).ToArray()));

Console.WriteLine("---");
