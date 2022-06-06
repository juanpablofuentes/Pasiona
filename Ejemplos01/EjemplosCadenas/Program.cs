string cadena = "   Hola que tal   ";
Console.WriteLine(cadena);
Console.WriteLine(cadena.Trim());

Console.WriteLine(cadena.ToLower());
Console.WriteLine(cadena.ToUpper());

Console.WriteLine(cadena.Contains("a"));
Console.WriteLine(cadena.Contains("j"));

Console.WriteLine(cadena.IndexOf("a"));
Console.WriteLine(cadena.IndexOf("a",7));
Console.WriteLine(cadena.IndexOf("j"));

Console.WriteLine(cadena.EndsWith("a"));
Console.WriteLine(cadena.StartsWith("   H"));

Console.WriteLine(cadena.Insert(5,"cucu"));
Console.WriteLine(cadena.Remove(5,3));

Console.WriteLine(cadena[4]);
Console.WriteLine(cadena.Substring(4,2));

String[] palabras = cadena.Split(" ");
foreach(string palabra in palabras)
{
    Console.WriteLine(palabra);
}