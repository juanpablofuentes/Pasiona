﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListGenerico
{
   
    class Persona
    {
        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

    }
    class Program
    {
        static bool esPositivo(int i)
        {
            return i > 0;
        }
        static void Main(string[] args)
        {
            List<int> intList = new List<int>();
            intList.Add(10);
            intList.Add(20);
            intList.Add(30);
            intList.Add(40);
            

            List<string> strList = new List<string>();
            strList.Add("one");
            strList.Add("two");
            strList.Add("three");
            strList.Add("four");
            strList.Add("four");
            strList.Add(null);
            strList.Add(null);

            List<Persona> perList = new List<Persona>();
            perList.Add(new Persona());

            List<int> intList2 = new List<int>() { 10, 20, 30, 40 };

            intList.ForEach(Console.WriteLine);

            Console.WriteLine("-------");
            intList.ForEach(elemento=>Console.WriteLine(elemento));
            Console.WriteLine("-------");
            foreach (int el in intList)
                Console.WriteLine(el);
            Console.WriteLine("-------");
            Console.WriteLine(strList[0]);
            Console.WriteLine(strList[2]);
            Console.WriteLine("-------");
            intList2.Sort();
            Console.WriteLine(intList2.BinarySearch(30)); //Podemos buscar porque está ordenada
            strList.Sort();
            strList.ForEach(Console.WriteLine);
            Console.WriteLine("-------");
            strList.Remove("four"); //Elimina un four
            strList.ForEach(Console.WriteLine);
            Console.WriteLine("-------");
            strList.RemoveAt(2); //Elimina el segundo elemento
            strList.ForEach(Console.WriteLine);
            Console.WriteLine("-------");
            strList.RemoveRange(0, 2);// Elimina los dos primeros
            strList.ForEach(Console.WriteLine);
            Console.WriteLine("-------");
            Console.WriteLine(strList.Contains("two"));
            Console.WriteLine(strList.Contains("cuatro"));
            Console.WriteLine(strList.IndexOf("two"));
            strList.Add("two");
            strList.Add("dos");
            strList.Add("two");
            strList.Add("dos");
            int pos = strList.IndexOf("two");
            while (pos != -1)
            {
                Console.WriteLine(pos);
                pos = strList.IndexOf("two",pos+1);
            }
            Console.WriteLine("-------");
            Console.WriteLine(intList2.Find(esPositivo));
            Console.WriteLine("-------");
            Console.WriteLine(intList2.Find(el => el > 20));
            Console.WriteLine("-------");
            List<int> res = intList2.FindAll(el => el > 20);
            res.ForEach(Console.WriteLine);
            Console.WriteLine("-------");
            Console.WriteLine(intList2.TrueForAll(esPositivo));
            Console.WriteLine(intList2.TrueForAll(el=>el>0));
          
        }
    }
}
