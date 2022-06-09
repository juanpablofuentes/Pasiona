string nombre = "Juan pablo fuentes";

object foo = new object();



String Nombre, Apellido1, Apellido2;

string[] partes =nombre.Split(" ");

Nombre = partes[0];
Apellido1 = partes.Length > 1 ? partes[1]:"";

if (partes.Length > 1)
{
    Apellido1 = partes[1];
}
else
{
    Apellido1 = "";
}
Apellido2 = partes.Length > 2 ? String.Join(" ",partes[2..^0]):"";



Console.WriteLine(String.Join(",", CreateArray("hola", 3)));
Console.WriteLine(String.Join(",", CreateArray("hola")));
Console.WriteLine(String.Join(",", CreateArray()));

string hola = "hola";



Console.WriteLine(Suma(new int[] { 2, 3, 4 }));

(int menor, int mayor) = Extremos(new int[] { 22, 13, 43 });
Console.WriteLine($"Menor {menor} Mayor {mayor}");

Console.WriteLine(String.Join(",", CreateNumbers(6)));

Console.WriteLine(hasOrder(new int[] { 2, 3, 4 }));
Console.WriteLine(hasOrder(new int[] { 2, 3, 4 }, Orden.Descendente));

Console.WriteLine(String.Join(",", ReverseNumbers(new int[] { 2, 3, 4 })));

string[] CreateArray(string cadena = "", int tam = 1)
{
    string[] temp = new string[tam];
    for (int i = 0; i < tam; i++)
    {
        temp[i] = cadena;
    }
    return temp;
}

int Suma(int[] numeros)
{
    int suma = 0;
    foreach (int numero in numeros)
    {
        suma += numero;
    }
    return suma;
}

(int, int) Extremos(int[] numeros)
{
    if (numeros.Length == 0)
    {
        return (0, 0);
    }
    int mayor = numeros[0], menor = numeros[0];
    foreach (int numero in numeros)
    {
        if (numero > mayor) { mayor = numero; }
        if (numero < menor) { menor = numero; }
    }
    return (menor, mayor);
}
int[] CreateNumbers(int tam)
{
    int[] temp = new int[tam];
    for (int i = 0; i < tam; i++)
    {
        temp[i] = i + 1;
    }
    return temp;
}
bool hasOrder(int[] numeros, Orden orden = Orden.Ascendente)
{
    for (int i = 1; i < numeros.Length; i++)
    {
        if (orden == Orden.Ascendente)
        {
            if (numeros[i] < numeros[i - 1])
            {
                return false;
            }
        }
        else
        {
            if (numeros[i] > numeros[i - 1])
            {
                return false;
            }
        }
    }
    return true;
}
int[] ReverseNumbers(int[] numeros)
{
    int[] temp = new int[numeros.Length];
    for (int i = 0; i < numeros.Length; i++)
    {
        temp[numeros.Length - i - 1] = numeros[i];

    }
    return temp;
}
enum Orden : int { Ascendente = 0, Descendente = 1 };