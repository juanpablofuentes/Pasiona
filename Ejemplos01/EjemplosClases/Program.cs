
using EjemplosClases;

Producto[] cestaCompra = { new Producto("caja", 100), new Libro("libro", 20, "El quijote"), new Manzana("Golden", 5) };

foreach(Producto prod in cestaCompra)
{
    Console.WriteLine(prod.etiqueta());
    if (prod is Libro libro)
    {
        ((Libro)prod).Calidad();
        Console.WriteLine(libro.Calidad());
    }
}

IRebaja[] foo2 = { new Producto("caja", 100), new Complejo() };

foreach (IRebaja reb in foo2)
{
    Console.WriteLine(reb.Rebaja());
}

Complejo a = new Complejo(), b = new Complejo();

Complejo[] tabla = new Complejo[3];

a.real = 3;
a.imaginaria = 4;

b.real = 3;
b.imaginaria = 4;

if (a==b)
{
    Console.WriteLine("Iguales");
}
if (a == null)
{

}
Console.WriteLine(a.absoluto);
Console.WriteLine(b);

if (a == 5)
{
    Console.WriteLine("Iguales");
}

Producto caja = new Producto("caja", 100);

Console.WriteLine(caja.PVP);

caja.Precio = 200;
caja.PVP = 130;

ClaseDePrueba foo = new ClaseDePrueba();

foo.prop1 = "hola";
Console.WriteLine(foo.prop1);

foo.setProp2("Adios");

Console.WriteLine(foo.getProp2());

foo.prop3 = "ejem";
Console.WriteLine(foo.prop3);

foo.Prop4 = "H";
Console.WriteLine(foo.Prop4);

Point p =new Point();

Point p2 = p;

p2.Increment();

p.Display();

(int x, int y) = p;

Console.WriteLine(CuentaAhorro.GetInterestRate());

CuentaAhorro ca = new CuentaAhorro(1000);

//Console.WriteLine(ca.GetInterestRate()); Error por acceder desde la instancia


Empleado ana = new Empleado();

ana.Sueldo = 500;

ana.Surname = "Pi";
ana.SetName("Ana");



Console.WriteLine(ana.Sueldo);

//CLases estáticas
Math.Sqrt(2);


//Encapsulación, herencia y polimorfismo
//SOLID

/*
 * public Types or type
members
Public items have no access restrictions. A public member can be
accessed from an object, as well as any derived class. A public type
can be accessed from other external assemblies.
private Type members or
nested types
Private items can be accessed only by the class (or structure) that
defines the item.
protected Type members or
nested types
Protected items can be used by the class that defines it and any child
class. They cannot be accessed from outside the inheritance chain.
internal Types or type
members
Internal items are accessible only within the current assembly.
Other assemblies can be explicitly granted permission to see the
internal items.
protected
internal
Type members or
nested types
When the protected and internal keywords are combined on an
item, the item is accessible within the defining assembly, within
the defining class, and by derived classes inside or outside of the
defining assembly.
private
protected
(new 7.2)
Type members or
nested types
When the private and protected keywords are combined on an
item, the item is accessible within the defining class and by derived
classes in the same assembly.
*/

