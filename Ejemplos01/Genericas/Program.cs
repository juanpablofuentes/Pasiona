bool esPositivo(int i)
{
    return i > 0;
}

List<int> intList = new List<int>();
intList.Add(10);
intList.Add(20);
intList.Add(30);
intList.Add(40);


List<string> strList = new List<string>();
strList.Add("one");
strList.Add("two");
strList.Add("three");
strList.Add("four");
strList.Add("four");
strList.Add(null);
strList.Add(null);

List<Persona> perList = new List<Persona>();
perList.Add(new Persona());

List<int> intList2 = new List<int>() { 10, 20, 30, 40 };

intList.ForEach(Console.WriteLine);

Console.WriteLine("-------");
intList.ForEach(elemento => Console.WriteLine(elemento));
Console.WriteLine("-------");
intList.ForEach(elemento => { Console.WriteLine("Elemento por 2"); 
    Console.WriteLine(elemento*2); });
Console.WriteLine("-------");
foreach (int el in intList)
{
    Console.WriteLine("Elemento por 2");
    Console.WriteLine(el * 2);
}
Console.WriteLine("-------");
foreach (int el in intList)
    Console.WriteLine(el);
Console.WriteLine("-------");
Console.WriteLine(strList[0]);
Console.WriteLine(strList[2]);
Console.WriteLine("-------");
intList2.Sort();
Console.WriteLine(intList2.BinarySearch(30)); //Podemos buscar porque está ordenada
strList.Sort();
strList.ForEach(Console.WriteLine);
Console.WriteLine("-------");
strList.Remove("four"); //Elimina un four
strList.ForEach(Console.WriteLine);
Console.WriteLine("-------");
strList.RemoveAt(2); //Elimina el segundo elemento
strList.ForEach(Console.WriteLine);
Console.WriteLine("-------");
strList.RemoveRange(0, 2);// Elimina los dos primeros
strList.ForEach(Console.WriteLine);
Console.WriteLine("-------");
Console.WriteLine(strList.Contains("two"));
Console.WriteLine(strList.Contains("cuatro"));
Console.WriteLine(strList.IndexOf("two"));
strList.Add("two");
strList.Add("dos");
strList.Add("two");
strList.Add("dos");
int pos = strList.IndexOf("two");
while (pos != -1)
{
    Console.WriteLine(pos);
    pos = strList.IndexOf("two", pos + 1);
}
Console.WriteLine("-------");
Console.WriteLine(intList2.Find(esPositivo));
Console.WriteLine("-------");
Console.WriteLine(intList2.Find(el => el > 20));
Console.WriteLine("-------");
List<int> res = intList2.FindAll(el => el > 20);
res.ForEach(Console.WriteLine);
Console.WriteLine("-------");
Console.WriteLine(intList2.TrueForAll(esPositivo));
Console.WriteLine(intList2.TrueForAll(el => el > 0));



Stack<int> myStack = new Stack<int>();

myStack.Push(1);
myStack.Push(2);
myStack.Push(3);
myStack.Push(4);
myStack.Push(5);

//Recorrer la pila
foreach (int itm in myStack)
    Console.WriteLine(itm);
Console.WriteLine("---------");

Console.WriteLine(myStack.Peek()); //Devuelve el último pero no lo quita
Console.WriteLine(myStack.Peek());
Console.WriteLine(myStack.Peek());
Console.WriteLine("---------");

Console.WriteLine(myStack.Pop()); //Devuelve el último Y LO QUITA
Console.WriteLine(myStack.Pop());
Console.WriteLine(myStack.Pop());
Console.WriteLine("---------");

Console.WriteLine(myStack.Contains(3));
Console.WriteLine(myStack.Contains(5));
Console.WriteLine("---------");

Console.WriteLine(myStack.Count);
Console.WriteLine("---------");

Queue<int> queue = new Queue<int>();
queue.Enqueue(3);
queue.Enqueue(2);
queue.Enqueue(1);
queue.Enqueue(4);
//Recorrer la pila
foreach (int itm in queue)
    Console.WriteLine(itm);
Console.WriteLine("---------");
Console.WriteLine(queue.Peek());//Muestra sin quitar
Console.WriteLine(queue.Peek());
Console.WriteLine(queue.Peek());
Console.WriteLine("---------");
Console.WriteLine(queue.Dequeue());//Muestra QUITANDO
Console.WriteLine(queue.Dequeue());
Console.WriteLine(queue.Dequeue());
Console.WriteLine("---------");



IDictionary<int, string> dict = new Dictionary<int, string>();
dict.Add(1, "Uno");
dict.Add(2, "Dos");
dict.Add(3, "Tres");

dict.Add(new KeyValuePair<int, string>(4, "Cuatro"));
dict.Add(new KeyValuePair<int, string>(5, "Cinco"));

IDictionary<int, string> dict2 = new Dictionary<int, string>()
                                            {
                                                {1,"Uno"},
                                                {2, "Dos"},
                                                {3,"Tres"}
                                            };

//Recorrer un diccionario
foreach (var item in dict)
{
    Console.WriteLine("Clave: {0}, Valor: {1}", item.Key, item.Value);
}
Console.WriteLine("-----");

for (int i = 0; i < dict.Count; i++)
{
    Console.WriteLine("Clave: {0}, Valor: {1}",
                                            dict.Keys.ElementAt(i),
                                            dict[dict.Keys.ElementAt(i)]);
}
Console.WriteLine("-----");
foreach (int key in dict.Keys)
{
    Console.WriteLine("Clave: {0}, Valor: {1}", key, dict[key]);
}
Console.WriteLine("-----");

foreach (string valor in dict.Values)
{
    Console.WriteLine("Value: {0}", valor);
}
Console.WriteLine("-----");
Console.WriteLine(dict[1]); //returns Uno
Console.WriteLine(dict[2]); // returns Dos
Console.WriteLine("-----");
string result;
for (int i = 0; i < 10; i++)
{
    if (dict.TryGetValue(i, out result))
    {
        Console.WriteLine(result);
    }
    else
    {
        Console.WriteLine("No hay valor para esa posición");
    }
}

Console.WriteLine(dict.ContainsKey(1)); // returns true
Console.WriteLine(dict.ContainsKey(4)); // returns false
Console.WriteLine(dict.Values.Contains("Uno")); // returns false


Console.WriteLine(dict.Contains(new KeyValuePair<int, string>(1, "Uno"))); // returns true


//Eliminar
dict.Remove(1);

SortedList<string, string> sList = new SortedList<string, string>(new InvertedComparer());
sList.Add("ana", "Ana Pérez");
sList.Add("evaa", "Eva Pi");
sList.Add("juanaa", "Juan Buj");
sList.Add("rosaaaa", "Rosa Sanz");
sList.Add("pedroaaaa", "Pedro Sánchez");
foreach (string valor in sList.Values)
{
    Console.WriteLine(valor);
}
Console.WriteLine(sList.ContainsKey("ana"));
Console.WriteLine(sList.ContainsValue("Eva Pi"));
Console.WriteLine(sList.IndexOfKey("ana"));
Console.WriteLine(sList.IndexOfValue("Eva Pi"));
Console.WriteLine(sList.Keys[0]);
Console.WriteLine(sList.Values[0]);

class Persona
{
    private string _nombre;

    public string Nombre
    {
        get { return _nombre; }
        set { _nombre = value; }
    }

}

class InvertedComparer : IComparer<String>
{
    public int Compare(string x, string y)
    {
        return y.CompareTo(x);
    }
}