using Ruleta;

List<String> alumnos = new List<string> { "Marie Kade", "Manuel", "Ainhoa", "Júlia", "David", "Alejandro", "Dani G","Dani M", "Albert" };

alumnos.Shuffle();

Console.WriteLine(String.Join("\n", alumnos));