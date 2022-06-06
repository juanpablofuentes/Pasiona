string[] cadenas = { "hola", "que", "tal","amigo" };

var cads= new[]  { "hola", "que", "tal" };

//Error en compilación, no hay un tipo adecuado
//var error = new[] { "hola", 7, "tal" };

object[] variado = { "hola", 4, 5.5, new DateTime(2022,6,4) };

foreach(var c in variado)
{
    Console.WriteLine(c);
    Console.WriteLine(c.GetType());

}

Console.WriteLine(String.Join(",",cadenas));
Array.Sort(cadenas);
Console.WriteLine(String.Join(",", cadenas));
Array.Reverse(cadenas);
Console.WriteLine(String.Join(",", cadenas));
Array.Fill(cadenas, "foo");
Console.WriteLine(String.Join(",", cadenas));


int[,] myMatrix;
myMatrix = new int[3, 4];
// Rellenar (3 * 4) array.
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        myMatrix[i, j] = i * j;
    }
}

int[,] otra = { { 1, 2 }, { 3, 4 } };

Console.WriteLine(myMatrix.Length);
Console.WriteLine(myMatrix.Rank);


printArray(myMatrix);
printArray(otra);

printArrayPretty(myMatrix);
printArrayPretty(otra);


int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

foreach(int i in numeros[2..5])
{
    Console.WriteLine(i);
}

Range rango = 2..5;

foreach (int i in numeros[rango])
{
    Console.WriteLine(i);
}

foreach (int i in numeros[3..^1])
{
    Console.WriteLine(i);
}


void printArray(int[,] tabla)
{
    foreach(var c in tabla)
    {
            Console.Write(c+",");
    }
}
void printArrayPretty(int[,] tabla)
{
    for(int i = 0; i < tabla.GetLength(0); i++)
    {
        for(int j = 0; j < tabla.GetLength(1); j++)
        {
            Console.Write(tabla[i, j]+",");
        }
        Console.WriteLine();
    }
}