
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

string[] palabras = cadena.Split(" ");
foreach(string palabra in palabras)
{
    Console.WriteLine(palabra);
}

string s1 = "Adios";
string s2 = "ADIOS";
Console.WriteLine("Por defecto: s1={0},s2={1}s1.Equals(s2): {2}", s1, s2, s1.Equals(s2));
Console.WriteLine("Case  insensitive: s1.Equals(s2, StringComparison.OrdinalIgnoreCase): {0}", s1.Equals(s2, StringComparison.OrdinalIgnoreCase));

Console.WriteLine(FromRainbow("Red"));

(String letra, String resto) = Trocear("hola", 0);

string[] foo=Anagrama("pera");
foreach(var el in foo)
{
    Console.WriteLine(el);
}

string[] Anagrama(string cadena)
{
    int longitud = cadena.Length;
    int tamany = Factorial(longitud);
    string[] res = new string[tamany];
    if (longitud == 1)
    {
        res[0] = cadena;
    }
    else
    {
        int indice = 0;
        for(int i = 0; i < longitud; i++)
        {
            (string letra, string resto)=Trocear(cadena,i);
            string[] temp = Anagrama(resto);
            for(int j=0;j<temp.Length; j++)
            {
                res[indice++] = letra+temp[j];
            }
        }
    }
    return res;
}

(string, string) Trocear(string cadena, int pos)
{
    String letra = cadena.Substring(pos, 1);
    String resto = cadena.Remove(pos, 1);
    return (letra, resto);
}

int Factorial(int num)
{
    int res = 1;
    for(int i = 1; i <= num; i++)
    {
        res*=i;
    }
    return res;
}

string FromRainbow(string colorBand)
{
    return colorBand switch
    {
        "Red" => "#FF0000",
        "Orange" => "#FF7F00",
        "Yellow" => "#FFFF00",
        "Green" => "#00FF00",
        "Blue" => "#0000FF",
        "Indigo" => "#4B0082",
        "Violet" => "#9400D3",
        _ => "#FFFFFF",
    };
}