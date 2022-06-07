
using System.Globalization;
using System.Text;

string cadena = "   Hola que tal   ";
Console.WriteLine(cadena);
Console.WriteLine(cadena.Trim());

Console.WriteLine(cadena.ToLower());
Console.WriteLine(cadena.ToUpper());

Console.WriteLine(cadena.Contains("a"));
Console.WriteLine(cadena.Contains("j"));

Console.WriteLine(cadena.IndexOf("a"));
Console.WriteLine(cadena.IndexOf("a", 7));
Console.WriteLine(cadena.IndexOf("j"));

Console.WriteLine(cadena.EndsWith("a"));
Console.WriteLine(cadena.StartsWith("   H"));

Console.WriteLine(cadena.Insert(5, "cucu"));
Console.WriteLine(cadena.Remove(5, 3));

Console.WriteLine(cadena[4]);
Console.WriteLine(cadena.Substring(4, 2));

string[] palabras = cadena.Split(" ");
foreach (string palabra in palabras)
{
    Console.WriteLine(palabra);
}

Console.WriteLine(String.Join("|", palabras));

string s1 = "Adios";
string s2 = "ADIOS";
Console.WriteLine("Por defecto: s1={0},s2={1}s1.Equals(s2): {2}", s1, s2, s1.Equals(s2));
Console.WriteLine("Case  insensitive: s1.Equals(s2, StringComparison.OrdinalIgnoreCase): {0}", s1.Equals(s2, StringComparison.OrdinalIgnoreCase));

Console.WriteLine(FromRainbow("Red"));

(String letra, String resto) = Trocear("hola", 0);

string[] foo = Anagrama("pera");
foreach (var el in foo)
{
    Console.WriteLine(el);
}

Console.WriteLine(Normalizar("áÉìpepeÒüö"));
Console.WriteLine(RemoveAccents("áÉìpepeÒüö"));

Console.WriteLine(InternalTrim("hola    que   tal"));
Console.WriteLine(ToTitleCase("hola    que   tal"));


Console.WriteLine(CountVocals("hola    qué   tal"));

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
        for (int i = 0; i < longitud; i++)
        {
            (string letra, string resto) = Trocear(cadena, i);
            string[] temp = Anagrama(resto);
            for (int j = 0; j < temp.Length; j++)
            {
                res[indice++] = letra + temp[j];
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
    for (int i = 1; i <= num; i++)
    {
        res *= i;
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

int GetRomanoValue(string letra)
{
    return letra switch
    {
        "M" => 1000,
        "D" => 500,
        "C" => 100,
        "L" => 50,
        "X" => 10,
        "V" => 5,
        "I" => 1,
        _ => 0
    };
}

string RockPaperScissors(string first, string second)
{
    return (first, second) switch
    {
        ("rock", "paper") => "Paper wins.",
        ("rock", "scissors") => "Rock wins.",
        ("paper", "rock") => "Paper wins.",
        ("paper", "scissors") => "Scissors wins.",
        ("scissors", "rock") => "Rock wins.",
        ("scissors", "paper") => "Scissors wins.",
        (_, _) => "Tie.",
    };
}

string InternalTrim(string cadena)
{
    while (cadena.IndexOf("  ") != -1)
    {
        cadena = cadena.Replace("  ", " ");
    }
    return cadena;
}

string ToTitleCase(string cadena)
{
    string[] palabras = cadena.Split(" ");
    for (int i = 0; i < palabras.Length; i++)
    {
        if (palabras[i].Length > 0)
        {
            palabras[i] = palabras[i].Substring(0, 1).ToUpper() + palabras[i].Substring(1).ToLower();
        }
    }
    return String.Join(" ", palabras);
}

int CountVocals(string cadena)
{
    cadena = Normalizar(cadena);
    string vocales = "aeiou";
    int count = 0;
    for(int i=0; i< vocales.Length; i++)
    {
        count += CountChar(cadena, vocales.Substring(i, 1));
    }
    return count;
}

int CountChar(string cadena, string c)
{
    string cad = cadena.Replace(c, "");
    return cadena.Length - cad.Length;
}

string Normalizar(string cadena)
{
    System.Text.EncodingProvider provider = System.Text.CodePagesEncodingProvider.Instance;
    Encoding.RegisterProvider(provider);
    byte[] tempBytes;
    tempBytes = System.Text.Encoding.GetEncoding("ISO-8859-8").GetBytes(cadena);
    return System.Text.Encoding.UTF8.GetString(tempBytes);
}

string RemoveAccents(string text)
{
    StringBuilder sbReturn = new StringBuilder();
    var arrayText = text.Normalize(NormalizationForm.FormD).ToCharArray();
    foreach (char letter in arrayText)
    {
        if (CharUnicodeInfo.GetUnicodeCategory(letter) != UnicodeCategory.NonSpacingMark)
            sbReturn.Append(letter);
    }
    return sbReturn.ToString();
}