using System;
namespace ejercicio21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("No se By: Heather");
            Console.WriteLine();

            int CN;
            int P = 0, N = 0, I = 0, PA = 0;

            Console.WriteLine("Ingrese la cantidad de números: ");
            CN = int.Parse(Console.ReadLine());


            for (int i = 0; i < CN; i++)
            {
                Console.Write("Ingrese el número " + (i + 1) + ": ");
                int num = int.Parse(Console.ReadLine());

                if (num > 0)
                { P++; }

                else if (num < 0)
                { N++; }

                if (num % 2 == 0) 
                { PA++; }

                else { I++; }
            }

            Console.WriteLine("\nResultados:");
            Console.WriteLine("Positivos: " + P);
            Console.WriteLine("Negativos: " + N);
            Console.WriteLine("Pares: " + PA);
            Console.WriteLine("Impares: " + I);

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();

        }
    }
}