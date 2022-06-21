using Campeonato;

Campeonato<String> liga = new Campeonato<string>();

liga.Add("ana");
liga.Add("eva");
liga.Add("rosa");
liga.Add("juan");
Console.WriteLine(liga);
liga.Organizar();
liga.gana("ana");
Console.WriteLine(liga);
liga.gana("eva");
Console.WriteLine(liga);
liga.gana("rosa");
//Console.WriteLine(liga);
//liga.SiguienteRonda();
//Console.WriteLine(liga);
//liga.SiguienteRonda();

Console.WriteLine("hola wue tal".WordCount());
Console.WriteLine(300.IsGreaterThan(20)); 
