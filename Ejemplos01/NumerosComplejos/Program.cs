namespace NumerosComplejos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Futbolista ana = new Futbolista("Ana", 7);
            ana += 3;
            ana++;
            Console.WriteLine(ana);
            List<Futbolista> equipo=new List<Futbolista>();
            equipo.Add(new Futbolista("aaaa",4));
            equipo.Add(new Futbolista("bbbb", 1));
            equipo.Add(new Futbolista("cccc", 7));
            equipo.Add(new Futbolista("dddd", 1));
            equipo.Sort();
            Console.WriteLine(String.Join(",", equipo));
            NumeroComplejo a = new NumeroComplejo(1, 2);
            NumeroComplejo b = new NumeroComplejo(2,1);
            Console.WriteLine(a);
            Console.WriteLine(b);
            // SOn iguales
            Console.WriteLine(a.CompareTo(b));
            Console.WriteLine(a.Modulo);
            Console.WriteLine(a>=b); // True
            Console.WriteLine(a > b); // false
            List<NumeroComplejo> lista= new List<NumeroComplejo>() {
                new NumeroComplejo(3, 4), 
                new NumeroComplejo(7, 7),
                new NumeroComplejo(3, 1), 
                new NumeroComplejo(2, 3), 
                new NumeroComplejo(1, 1) };
            Console.WriteLine(String.Join(",",lista));
            // La lista se ordena por lo implementado en compareto
            lista.Sort();
            Console.WriteLine(String.Join(",", lista));
            NumeroComplejo c = new NumeroComplejo(2, 1);
            Console.WriteLine(c.GetHashCode());
            Console.WriteLine(b.GetHashCode());
            Dictionary<NumeroComplejo, int> numeros=new Dictionary<NumeroComplejo, int>();
            numeros.Add(c, 1);
           // numeros.Add(b, 2); // Error puesto que b y c valen lo mismo
            Console.WriteLine(numeros[c]);
        }
    }
}