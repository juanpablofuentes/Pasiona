﻿List<double> radios = new List<double> { 1, 2, 4 };

opDouble ops = circunferencia;
ops += areaCirculo;
ops += volumenEsfera;

Console.WriteLine(ops(2));
ops-=areaCirculo;
mostrar(radios, ops);
mostrar2(radios, areaCirculo);

ops = perimetro;
ops += area;


List<double> lados = new List<double> { 1, 2, 4 };
mostrar(lados, ops);
mostrar2(lados, ops.Invoke);


void mostrar(List<double> lista, opDouble operacion)
{
    foreach (double num in lista)
    {
        // Recorro todos los delegados que contiene el delegado multicast
        foreach (opDouble metodo in operacion.GetInvocationList())
        {
            Console.WriteLine(metodo.Method.Name);
            Console.WriteLine(metodo(num));
        }
    }
}

void mostrar2(List<double> lista, Func<double, double> operacion)
{
    foreach (double num in lista)
    {
        Console.WriteLine(operacion(num));
    }
}
double circunferencia(double radio)
{
    return Math.PI * radio * 2;
}
double areaCirculo(double radio)
{
    return Math.PI * radio * radio;
}
double volumenEsfera(double radio)
{
    return Math.PI * 4 / 3 * Math.Pow(radio, 3);
}

double perimetro(double lado)
{
    return lado*4;
}

double area(double lado)
{
    return lado * lado;
}

delegate double opDouble(double valor);