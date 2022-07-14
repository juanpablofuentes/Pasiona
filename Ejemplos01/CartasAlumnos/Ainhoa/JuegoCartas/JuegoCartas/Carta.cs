namespace JuegoCartas
{
    class Carta
    {
        public enum Tipo
        {
            oros,
            espadas,
            copas,
            bastos
        }

        public enum Valor
        {
            uno = 1, dos, tres, cuatro, cinco, seis, siete, diez, once, doce
        }

        public override string ToString()
        {
            return String.Format($"{MiTipo} {MiValor}");
        }

        public Tipo MiTipo { get; set; }
        public Valor MiValor { get; set; }
    }
}