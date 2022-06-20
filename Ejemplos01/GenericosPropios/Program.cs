
if (ClsCalculator.AreEqual<double>(10.5, 20.5))
{
    Console.WriteLine("Iguales");
}

if (ClsCalculator.AreEqual<String>("ana", "ana"))
{
    Console.WriteLine("Iguales");
}

Coleccion<Animal> zoo = new Coleccion<Animal>();

zoo.add(new Animal("Leon"));
zoo.add(new Animal("Cabra"));
zoo.add(new Animal("Cerdo"));
zoo.mostrar();

Coleccion<Planta> jardin = new Coleccion<Planta>();

jardin.add(new Planta("Ficus"));
jardin.add(new Planta("Abeto"));
jardin.add(new Planta("Margarita"));
//  jardin.add(new Animal("Jabalí")); Error porque no se puede añadir un animal
jardin.mostrar();

ClaseGenerica<int> claseEntero = new ClaseGenerica<int>(10);

int val = claseEntero.metodoGenerico(200);

ClaseGenerica<string> strGenericClass = new ClaseGenerica<string>("Hola ¿Qué tal?");

strGenericClass.propiedadGenerica = "Ejemplo de propiedad genérica";
string result = strGenericClass.metodoGenerico("Parámetro genérico");

Prueba<int> p = new Prueba<int>(10);
Console.WriteLine(p.igual(20));
Console.WriteLine(p.igual(10));

Persona juan = new Persona("Juan");
Prueba<Persona> p2 = new Prueba<Persona>(juan);
Console.WriteLine(p2.igual(juan));
Console.WriteLine(p2.igual(new Persona("Juan")));

DataStore<Animal> dsa = new DataStore<Animal>();
public class ClsCalculator
{
    public static bool AreEqual<T>(T value1, T value2)
    {
        return value1.Equals(value2);
    }
}
class Coleccion<T>
{
    private List<T> elementos = new List<T>();

    public void add(T elemento)
    {
        elementos.Add(elemento);
    }

    public void mostrar()
    {
        foreach (T el in elementos)
        {
            if (el is Animal animal)
            {
                Console.Write(animal.Ruido());
            }
            Console.WriteLine(el);
        }
    }

}

class Animal
{
    public string Nombre { get; set; }
    public string Sonido { get; set; }
    public Animal(string nombre)
    {
        Nombre = nombre;
    }
    public String Ruido()
    {
        return "GRRRR";
    }
    public override string ToString()
    {
        return Nombre;
    }

}
class Planta
{
    public string Clasificacion { get; set; }
    public Planta(string clasificacion)
    {
        Clasificacion = clasificacion;
    }
    public override string ToString()
    {
        return Clasificacion;
    }

}
class Mineral
{
    public string Denominacion { get; set; }
    public Mineral(string denominacion)
    {
        Denominacion = denominacion;
    }
    public override string ToString()
    {
        return Denominacion;
    }
}
class ClaseGenerica<T>
{
    private T variableTipoGenerico;

    public ClaseGenerica(T valor)
    {
        variableTipoGenerico = valor;
    }

    public T metodoGenerico(T paramGenerico)
    {
        Console.WriteLine("Tipo parámetro: {0}, valor: {1}", typeof(T).ToString(), paramGenerico);
        Console.WriteLine("Tipo return: {0}, valor: {1}", typeof(T).ToString(), variableTipoGenerico);

        return variableTipoGenerico;
    }

    public T propiedadGenerica { get; set; }
}
class Foo
{
    public int valor { get; set; }
}

class Persona
{
    private string nombre;

    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }
    public Persona(string nombre)
    {
        Nombre = nombre;
    }
    public override bool Equals(Object obj)
    {
        return Nombre == ((Persona)obj).Nombre;
    }
}

class Prueba<T>
{
    T interna;
    public Prueba(T valor)
    {
        interna = valor;
    }
    public bool igual(T valor)
    {
        return interna.Equals(valor);
    }
}

class DataStore<T> where T : class, new()
{
    public T Data { get; set; }
}