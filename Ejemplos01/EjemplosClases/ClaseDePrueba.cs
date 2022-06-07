using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosClases
{
    internal class ClaseDePrueba
    {
        public string prop1;
        private string _prop2;
        private string _prop4;

        public string getProp2()
        {
            return _prop2;
        }

        public void setProp2(string cad)
        {
            _prop2 = cad;
        }

        public string prop3 { get; set; }
        public string Prop4 { get { return _prop4 + "@"; } set {
                if (value.Length > 3)
                {
                    _prop4 = value;
                }
                else
                {
                    throw new Exception("Cadena muy corta");
                }
            } }

    }
}
