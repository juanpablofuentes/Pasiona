namespace EjemploDelegados
{
    internal class Program
    {
        delegate void MiDelegado(string mensaje);
        static void Main()
        {
            PrintResult(3, 4, Add); // Output: 7
            PrintResult(3, 4, Multiply); // Output: 12
        }
        static void test(MiDelegado m)
        {
            m("Llamado desde un método");
        }
        static void MostrarMensaje(string mensaje)
        {
            Console.WriteLine($"Mensaje 1: {mensaje}");
        }

        static void MostrarOtroMensaje(string mensaje)
        {
            Console.WriteLine($"Mensaje 2: {mensaje}");
        }
        public static void PrintResult(int x, int y, Func<int, int, int> operation)
        {
            int result = operation(x, y);
            Console.WriteLine(result);
        }

        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int Multiply(int x, int y)
        {
            return x * y;
        }
    }
}