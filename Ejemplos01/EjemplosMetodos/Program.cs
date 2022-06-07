int a = 3;

Duplicar(ref a);
Console.WriteLine(a);

DuplicarInOut(3, out a);

int.TryParse("45", out int res);
Console.WriteLine(res);

int[] numeros = {1,2,3};

DuplicarArray(numeros);


Console.WriteLine(String.Join(",", numeros));

object num = 3;
DuplicarObjeto(num);
Console.WriteLine("Fuera: "+num);

Console.WriteLine(sumaParams(1,2,3));
Console.WriteLine(sumaParams(1,2,3,4,5,6,7));

Console.WriteLine(NombreCompleto("Ana", "Pi"));
Console.WriteLine(NombreCompleto(apellido1:"Pi",apellido2:"Margall"));

(int menor, int mayor) =Extremos(1,5,3,0,90,-5);

Console.WriteLine(menor + "," + mayor);
void Duplicar(ref int numero)
{
    numero *= 2;
}

void DuplicarInOut(in int numero, out int resultado)
{
    resultado = numero * 2;
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
    Console.WriteLine("Dentro: "+n);
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


(int,int) Extremos(params int[] numeros)
{
    int mayor = numeros[0];
    int menor = numeros[0];
    foreach (int numero in numeros)
    {
        if (numero > mayor) mayor = numero;
        if (numero < menor) menor = numero;
    }
    return (menor,mayor);
}
string NombreCompleto(string nombre="", string apellido1="",string apellido2 = "")
{
    return nombre + " " + apellido1 + " " + apellido2;
}