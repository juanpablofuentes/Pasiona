TipoEmpleado tipo = TipoEmpleado.Comunicacion;

Errores error = Errores.BadRequest;

Console.WriteLine(tipo);
Console.WriteLine(error);
Console.WriteLine((int)error);

Point p = new Point(3, 4);

p.Display();
p.Increment();
p.Display();

Point p2 = p;

p2.Increment();
p.Display();
p2.Display();
enum TipoEmpleado
{
    Administracion,
    Contabilidad,
    Comunicacion
}

enum Errores
{
    NotFound=404,
    BadRequest=400,
    Forbidden=403
}

struct Point
{
    // Fields of the structure.
    public int X;
    public int Y;
    public Point(int xPos, int yPos)
    {
        X = xPos;
        Y = yPos;
    }
    // Add 1 to the (X, Y) position.
    public void Increment()
    {
        X++; Y++;
    }
    // Subtract 1 from the (X, Y) position.
    public void Decrement()
    {
        X--; Y--;
    }
    // Display the current position.
    public void Display()
    {
        Console.WriteLine("X = {0}, Y = {1}", X, Y);
    }
    public (int XPos, int YPos) Deconstruct() => (X, Y);
}