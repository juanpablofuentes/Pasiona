using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosSimplesC
{
    public class Persona
    {
        public int Edad { get; set; }
        private static bool procesar= true; // Campo estático
        // Propiedad que tiene un campo privado asociado y que en el get o el set
        // Hacemos o comprobaciones o algo
        private string _nombre; // Campo privado para almacenar el valor de la propiedad
        public string Nombre
        {
            get => "Don/doña "+_nombre; // Descriptor de acceso get (lectura)
            set
            {
                // Descriptor de acceso set (escritura)
                if (!string.IsNullOrEmpty(value))
                {
                    this._nombre = value;
                }
            }
        }
        
        public Persona(): this("Anonimo")
        {
            
        }
        public Persona(String nombre):this(nombre,18)
        {
            
        }
        public Persona(String nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }
        public void procesarOrden()
        {
            if (procesar) {
                procesar=false;
                Console.WriteLine("Procesando la orden");
            }
            else
            {
                Console.WriteLine("No puedo procesar cpu ocupada");
            }
        }
        public void acabarProceso()
        {
            procesar= true;
            Console.WriteLine("Proceso acabado");
        }
        public virtual String saludo()
        {
            return "Hola "+Nombre;
        }
        public override string ToString()
        {
            return Nombre+" - "+Edad;
        }
        public override int GetHashCode()
        {
            return Nombre.GetHashCode() + Edad.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Persona other = (Persona)obj;
            return other.Nombre==Nombre && other.Edad==Edad;
        }
    }
}
