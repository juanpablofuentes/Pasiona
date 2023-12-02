using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotonTarea
{
    internal class Elemento
    {
        public int Numero { get; set; }
        public int Estado { get; set; }
        public TextBox? txtMostrar { get; set; }
        public int[]? Elementos { get; set; }
        public Elemento(int numero,int estado, TextBox txtMostrar) { 
            this.Numero = numero;
            this.Estado = estado;
            this.txtMostrar = txtMostrar;
        }


    }
}
