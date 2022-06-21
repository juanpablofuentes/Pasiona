using Indexadores;

Clase Mates = new Clase("Matemáticas");

Mates.Alumnos.Add("Eva");
Mates.Alumnos.Add("Ana");
Mates.Alumnos.Add("Rosa");

//Mates[1] = "Juan";
Mates.Alumnos[1] = "Juan";

//Mates[10] = "Pep";


Console.WriteLine(Mates);
Console.WriteLine(Mates[3]);