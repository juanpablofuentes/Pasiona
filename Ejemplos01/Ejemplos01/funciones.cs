static void arbolito(int tam)
{
    if (tam > 0)
    {
        Console.WriteLine(new String('*', tam));
        arbolito(tam - 1);
    }
}
static int Fibonacci(int posicion)
{
    int a = 1, b = 1, t = 2;
    for (int i = 1; i < posicion - 1; i++)
    {
        t = a + b;
        a = b;
        b = t;

    }
    return t;
}

static int fibonacci(int posicion)
{
    if (posicion <= 2)
    {
        return 1;
    }
    else
    {
        return fibonacci(posicion - 1) + fibonacci(posicion - 2);
    }
}

static int factorial(int num)
{
    if (num <= 1)
    {
        return 1;
    }
    else
    {
        return num * factorial(num - 1);
    }
}
static String OtroSaludo(string nombre = "Anonimo", int edad = 5)
{
    return "Hola " + nombre + " tienes " + edad + " años";
}
static string Saludo(String nombre)
{
    return "Hola " + nombre;
}
static string Saludo()
{
    return Saludo("Anonimo");
}
static int BuscarPosicionFeten(int[] elementos, int buscado)
{
    int pos = -1;
    for (int i = 0; i < elementos.Length && pos == -1; i++)
    {
        if (elementos[i] == buscado)
        {
            pos = i;
        }
    }
    return pos;
}
static (int, int) BuscarPosicion(int[] elementos, int buscado)
{
    for (int i = 0; i < elementos.Length; i++)
    {
        if (elementos[i] == buscado)
        {
            return (i, buscado);
        }
    }
    return (-1, buscado);
}