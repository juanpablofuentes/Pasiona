namespace JuegoCartas
{
    class Mano
    {
        public List<Carta> Cartas { get; set; }

        public Mano(List<Carta> cartas)
        {
            Cartas = cartas;
        }

        public void Print()
        {
            foreach (var c in Cartas)
            {
                Console.WriteLine(c.ToString());
            }
        }
    }
}