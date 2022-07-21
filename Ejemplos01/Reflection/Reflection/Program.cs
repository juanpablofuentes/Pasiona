using Reflection;
using System.Reflection;

Alumno Ana = new Alumno("Ana", "1123", 7);

Console.WriteLine(Ana.GetType().FullName);
Console.WriteLine(typeof(Alumno).FullName);

PropertyInfo[] properties = typeof(Alumno).GetProperties();
foreach (PropertyInfo propertyInfo in properties)
{
    Console.WriteLine(propertyInfo.Name + ":"+propertyInfo.GetValue(Ana));
}

MethodInfo[] myArrayMethodInfo = typeof(Alumno).GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
foreach (MethodInfo myMethod in myArrayMethodInfo)
{
    Console.WriteLine("\nThe name of the method is {0}.", myMethod.Name);
}
