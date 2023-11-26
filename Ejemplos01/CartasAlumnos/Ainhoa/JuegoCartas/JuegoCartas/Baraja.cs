namespace JuegoCartas
{
    class Baraja : Carta
    {
        //private List<Carta> baraja;
        private int contador = 0;

        public List<Carta> BarajaAct { get; set; }
        public Baraja()
        {
            BarajaAct = new List<Carta>();
        }

        public void RellenarBaraja()
        {
            foreach (Tipo c in Enum.GetValues(typeof(Tipo)))
            {
                foreach(Valor v in Enum.GetValues(typeof(Valor)))
                {
                    BarajaAct.Add(new Carta { MiTipo = c, MiValor = v });
                }
            }
            BarajarCartas();
        }

        public void BarajarCartas()
        {
            Random rand = new Random();
            Carta temp;
            for (int i = 0; i < BarajaAct.Count; i++)
            {
                int indice2 = rand.Next(0, 40);
                temp = BarajaAct[indice2];
                BarajaAct[indice2] = BarajaAct[i];
                BarajaAct[i]=temp;
            }
        }

        public Carta Repartir()
        {
           if(contador <= BarajaAct.Count)
            {
                Carta carta = BarajaAct[contador++];
                return carta;
            }
            return null;
        }

        public Mano RepartirMano()
        {
            List<Carta> cartasMano = new List<Carta>();
            for(int i = 0; i < 4; i++)
            {
                cartasMano.Add(Repartir());
            }

            return new Mano(cartasMano);
        }

        public void Print()
        {
            foreach(var c in BarajaAct)
            {
                Console.WriteLine(c.ToString());
            }
        }
    }
}