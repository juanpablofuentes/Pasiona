namespace JuegoCartas
{

    internal class Program
    {
        static void Main(string[] args)
        {
            var deck = new Baraja();
            deck.RellenarBaraja();
            //deck.Print();

            Mano mano1 = deck.RepartirMano();
            mano1.Print();
            Console.WriteLine("------------------");
            Mano mano2 = deck.RepartirMano();
            mano2.Print();
        }
    }
}