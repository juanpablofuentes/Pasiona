using FiestaAlumnos;

Fiesta summer = new Fiesta();

summer[10] = new Alumno("Eva", 7);
summer[10] = new Alumno("Ana", 8);
summer[10] = new Alumno("Juan", 3);

Console.WriteLine(summer);

summer.Juego(baile);
summer.Juego(loteria);

summer.Proceso(Halago);

Fiesta winter = new Fiesta(esPar);

winter[10] = new Alumno("Eva", 7);
winter[10] = new Alumno("Ana", 8);
winter[10] = new Alumno("Juan", 3);

Console.WriteLine(winter);

bool esPar(Alumno alumno)
{
    return alumno.Nota % 2 == 0;
}

void baile(String nombre)
{
    Console.WriteLine("Vamos " + nombre + " a mover el esqueleto ¡Bailar, bailar!");
}

void loteria(String nombre)
{
    Console.WriteLine( nombre + " Has entrado en el sorteo");
}

String Halago(String nombre, int nota)
{
    if (nota >= 8) return "Eres un crack ";
    if (nota >= 6) return "Eres bueno";
    return "Vale, bueno, de acuerdo";
}