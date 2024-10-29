using System;
namespace ejercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calificaciones By:Heather");
            Console.WriteLine();

            Double C;

            Console.Write("Ingrese la calificación del estudiante: ");
            C = Convert.ToDouble(Console.ReadLine());


            if (C > 100)
            {
                Console.WriteLine("La calificación no puede ser mayor a 100:");
            }

            else if (C >= 90)
            {
                Console.WriteLine("La calificación ingresada fue: " + C);
                Console.WriteLine("¡La situación del estudiante esta excelente!");
            }

            else if (C >= 80)
            {
                Console.WriteLine("La calificación ingresada fue: " + C);
                Console.WriteLine("¡La situación del estudiante esta muy bien!");
            }

            else if (C >= 75)
            {
                Console.WriteLine("La calificación ingresada fue: " + C);
                Console.WriteLine("¡La situación del estudiante esta bien!");
            }

            else if (C >= 70)
            {
                Console.WriteLine("La calificación ingresada fue: " + C);
                Console.WriteLine("¡La situación del estudiante esta regular!");
            }

            else
            {
                Console.WriteLine("La calificación ingresada fue: " + C);
                Console.WriteLine("¡La situación del estudiante esta deficiente!");
            }


        }
    }
}

