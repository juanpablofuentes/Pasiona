int a = 3;

Duplicar(ref a);
Console.WriteLine(a);

int[] numeros = {1,2,3};

DuplicarArray(numeros);

Console.WriteLine(String.Join(",", numeros));

object num = 3;
DuplicarObjeto(num);
Console.WriteLine(num);

Console.WriteLine(sumaParams(1,2,3));
Console.WriteLine(sumaParams(1,2,3,4,5,6,7));

Console.WriteLine(NombreCompleto("Ana", "Pi"));
Console.WriteLine(NombreCompleto(apellido1:"Pi",apellido2:"Margall"));

void Duplicar(ref int numero)
{
    numero *= 2;
}

void DuplicarArray(int[] tabla)
{
    for(int i=0; i < tabla.Length; i++)
    {
        tabla[i] *= 2;
    }
}

void DuplicarObjeto(object n)
{
    n = (int)n*2;
    Console.WriteLine(n);
}

int suma(int a, int b)
{
    a += b;
    return a;
}

int suma2(in int a, int b)
{
 //   a += b; Error  parámetro solo lectura
    return a;
}

int sumaParams(params int[] sumandos)
{
    int res = 0;
    foreach(int i in sumandos)
    {
        res += i;
    }
    return res;
}

string NombreCompleto(string nombre="", string apellido1="",string apellido2 = "")
{
    return nombre + " " + apellido1 + " " + apellido2;
}