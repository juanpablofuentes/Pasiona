using Pruebas;

Alumno ana = new Alumno("Ana Pi", 8);

Console.WriteLine(ana.ToString());
Console.WriteLine(ana.GetType());
Console.WriteLine(ana.GetHashCode());

Alumno juan = new Alumno("Ana Pi", 8);

Console.WriteLine(juan);

Alumno pepe = new Alumno(ana.Nombre,ana.Nota);

Console.WriteLine(juan.GetHashCode());
Console.WriteLine(pepe.GetHashCode());

Console.WriteLine(ana.Equals(juan));
Console.WriteLine(ana.Equals(pepe));