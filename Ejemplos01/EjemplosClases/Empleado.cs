using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosClases
{
    internal class Empleado
    {
        // Field data.
        private string _empName;

        private string _surname;

        public string Surname { get { return _surname; } set { _surname = value; } }


        // Accessor (get method).
        public string GetName() => _empName;
        // Mutator (set method).
        public void SetName(string name)
        {
            // Do a check on incoming value
            // before making assignment.
            if (name.Length > 15)
            {
                Console.WriteLine("Error! Name length exceeds 15 characters!");
            }
            else
            {
                _empName = name;
            }
        }

    }
}
