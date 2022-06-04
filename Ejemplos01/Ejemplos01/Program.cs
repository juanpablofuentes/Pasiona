// Verbatim @

string s1 = "He said, \"This is the last \u0063hance\x0021\"";
string s2 = @"He said, ""This is the last \u0063hance\x0021""";
string s3 = @"Hola
que
tal      estás";

Console.WriteLine(s1);
Console.WriteLine(s2);
Console.WriteLine(s3);

int price = 90;

Console.WriteLine($"The price is {price}");


//Tipos nullables
int? edad=null;

//Esto da error
//Console.WriteLine(edad.GetType());

int older = edad ?? 18 + 10;

Console.WriteLine(edad);
Console.WriteLine(older);

if (edad is null)
{
    edad = 18;
}

Console.WriteLine(edad);

edad = 9;
Console.WriteLine(edad.GetType());

string nombre = "Juan";
string? apellidos = null;

Console.WriteLine(nombre + apellidos);
Console.WriteLine($"{nombre} {apellidos}");

//Tipos implícitos (nombre es de tipo string)
var nombre2 = "Ana Pi";

Console.WriteLine(nombre2.GetType());

//Tipos anónimos
var sueldo = new { importe = 30000, irpf = 15 };

Console.WriteLine(sueldo.GetType());

// Alias de objetos

//object:  System.Object
//string:  System.String
//bool:    System.Boolean
//byte:    System.Byte
//sbyte:   System.SByte
//short:   System.Int16
//ushort:  System.UInt16
//int:     System.Int32
//uint:    System.UInt32
//long:    System.Int64
//ulong:   System.UInt64
//float:   System.Single
//double:  System.Double
//decimal: System.Decimal
//char:    System.Char

//Break y continue



//TUPLAS

(double, int) t1 = (4.5, 3);
Console.WriteLine($"Tuple with elements {t1.Item1} and {t1.Item2}.");
// Output:
// Tuple with elements 4.5 and 3.

(double Sum, int Count) t2 = (4.5, 3);
Console.WriteLine($"Sum of {t2.Count} elements is {t2.Sum}.");
// Output:
// Sum of 3 elements is 4.5.

//Arrays
int[] array = new int[5];
string[] stringArray = new string[6];

int[] array1 = new int[] { 1, 3, 5, 7, 9 };

int[] array2 = { 1, 3, 5, 7, 9 };
string[] weekDays2 = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

Console.WriteLine(weekDays2.Length);
Console.WriteLine(weekDays2[0]);
Console.WriteLine(String.Join(",",weekDays2[0..2]));



//IF y scope
string playerCount;
System.Console.Write(
"Enter the number of players (1 or 2):");
playerCount = System.Console.ReadLine();
if (playerCount != "1" && playerCount != "2")
{
    string message =
    "You entered an invalid number of players.";
}
else
{
    // ...
}
// ERROR: message is not in scope
//System.Console.WriteLine(message);

string? uri = null;
// ...
if (uri != null)
{
    System.Console.WriteLine(
    $"Uri is: {uri}");
}
else // (uri == null)
{
    System.Console.WriteLine(
    "Uri is null");
}


// ?. ?[]

//https://docs.microsoft.com/es-es/dotnet/csharp/language-reference/keywords/params

static string Combine(params string[] paths)
{
    string result = string.Empty;
    foreach (string path in paths)
    {
        result = Path.Combine(result, path);
    }
    return result;
}

//Overloading https://www.programiz.com/csharp-programming/method-overloading
// Parámetros opcionales  https://docs.microsoft.com/es-es/dotnet/csharp/programming-guide/classes-and-structs/named-and-optional-arguments

string firstName;
string ageText;
int age;
int result = 0;
Console.Write("Enter your first name: ");
firstName = Console.ReadLine();
Console.Write("Enter your age: ");
ageText = Console.ReadLine();
try
{
    age = int.Parse(ageText);
    Console.WriteLine(
    $"Hi {firstName}! You are {age * 12} months old.");
}
catch (FormatException)
{
    Console.WriteLine(
    $"The age entered, {ageText}, is not valid.");
    result = 1;
}
catch (Exception exception)
{
    Console.WriteLine(
    $"Unexpected error: {exception.Message}");
    result = 1;
}
finally
{
    Console.WriteLine($"Goodbye {firstName}");
}


