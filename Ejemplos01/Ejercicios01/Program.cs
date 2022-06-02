// See https://aka.ms/new-console-template for more information
Console.WriteLine(String.Join(",", CreateArray("hola", 3)));
Console.WriteLine(String.Join(",", CreateArray("hola")));
Console.WriteLine(String.Join(",", CreateArray()));

Console.WriteLine(Suma(new int[] { 2, 3, 4 }));

(int menor, int mayor) = Extremos(new int[] { 22, 13, 43 });
Console.WriteLine($"Menor {menor} Mayor {mayor}");

Console.WriteLine(String.Join(",", CreateNumbers(6)));


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