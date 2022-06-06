using EjemplosClases;

Point p=new Point();

Point p2 = p;

p2.Increment();

p.Display();

Console.WriteLine(CuentaAhorro.GetInterestRate());

CuentaAhorro ca = new CuentaAhorro(1000);

//Console.WriteLine(ca.GetInterestRate()); Error por acceder desde la instancia


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