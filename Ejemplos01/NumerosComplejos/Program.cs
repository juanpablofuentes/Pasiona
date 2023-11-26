namespace NumerosComplejos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NumeroComplejo a = new NumeroComplejo(1, 2);
            NumeroComplejo b = new NumeroComplejo(2,1); 
            Console.WriteLine(a.CompareTo(b));
            Console.WriteLine(a.Modulo);
            Console.WriteLine(a>=b);
            Console.WriteLine(a > b);
            List<NumeroComplejo> lista= new List<NumeroComplejo>() { new NumeroComplejo(3, 4), new NumeroComplejo(7, 7), new NumeroComplejo(3, 1), new NumeroComplejo(2, 3), new NumeroComplejo(1, 1) };
            Console.WriteLine(String.Join(",",lista));
            lista.Sort();
            Console.WriteLine(String.Join(",", lista));
            NumeroComplejo c = new NumeroComplejo(2, 1);

            Dictionary<NumeroComplejo, int> numeros=new Dictionary<NumeroComplejo, int>();
            numeros.Add(c, 1);
            numeros.Add(b, 2);
            Console.WriteLine(numeros[c]);
        }
    }
}