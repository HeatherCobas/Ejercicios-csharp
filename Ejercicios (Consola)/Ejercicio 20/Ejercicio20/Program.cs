using System;

namespace Ventiagesimo_ejercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Promedio By:Heather");
            Console.WriteLine();

            double N1, N2, N3, N4, Suma, P, Cali, NEx, NC;
            string Nom, M, Estado, tipo;

            Console.WriteLine("Ingrese el Nombre del Estudiante: ");
            Nom = Console.ReadLine();
            Console.WriteLine("Ingrese la Materia:" );
            M = Console.ReadLine();
            Console.WriteLine("Ingrese la nota 1: ");
            N1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la nota 2: ");
            N2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la nota 3: ");
            N3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la nota 4: ");
            N4 = Convert.ToDouble(Console.ReadLine());

           Suma = N1 + N2 + N3 + N4;
           P = Suma / 4;
           Cali = P;

           tipo = "Normal";

         if (Cali < 70)
            {tipo = "Completivo";
              Console.WriteLine("El estudiante va a completivo.");
              Console.WriteLine("Ingrese la nota del examen completivo:");
              NC = double.Parse(Console.ReadLine());
              Cali = (P * 0.5) + (NC * 0.5);

         if (Cali < 70)
               {tipo = "Extraordinario";
                    Console.WriteLine("El estudiante va a extraordinario.");
                    Console.WriteLine("Ingrese la nota del examen extraordinario:");
                    NEx = double.Parse(Console.ReadLine());
                    Cali = (P * 0.3) + (NEx * 0.7);
                }
            }

            Console.WriteLine("Resultados:");
            Console.WriteLine("El Nombre del estudiante es: " + Nom);
            Console.WriteLine("La Materia es: " + M);
            Console.WriteLine("La Calificación " + tipo + " del estudiante es: " + Cali);

            if (Cali >= 70)
            {
                Console.WriteLine("Situación: Aprobado");
            }
            else
            {
                Console.WriteLine("Situación: Reprobado");
            }
        }
    }
}
