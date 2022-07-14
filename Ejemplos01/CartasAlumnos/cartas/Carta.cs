using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cartas {
    internal class Carta {

        private string _valor, _palo;

        public string Valor { get => _valor; }
        public string Palo { get => _palo; }

        public Carta(string valor, string palo, IBaraja baraja) {

            string [] valores = baraja.Valores();
            string [] palos = baraja.Palos();

            valor = valor.ToLower();
            palo = palo.ToLower();

            _valor = valores.Contains(valor) ? valor : throw new Exception("El valor introducido no es valido");
            _palo = palos.Contains(palo) ? palo : throw new Exception("El palo introducido no es valido");

        }

        public override string ToString () => $"[{Valor}, {Palo}]";

        public override bool Equals (object? obj) => obj is Carta carta && carta.Valor == Valor && carta.Palo == Palo;

        public override int GetHashCode () => HashCode.Combine(Valor, Palo);

        public static bool operator == (Carta Left, Carta Right) => Left.Equals(Right);
        public static bool operator != (Carta Left, Carta Right) => !Left.Equals(Right);     

    }
}
