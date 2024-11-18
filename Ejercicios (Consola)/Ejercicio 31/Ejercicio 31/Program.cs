using System;
namespace Ejercicio_31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arreglos By:Heather");
            Console.WriteLine();

            int[] A = new int[10];
            int[] B = new int[10];
            int[] S = new int[10];


            Console.WriteLine("Ingrese los primeros 10 números:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Elemento {i + 1} de A: ");
                A[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nIngrese 10 números más:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Elemento {i + 1} de B: ");
                B[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 10; i++)
            { S[i] = A[i] + B[i]; }

            Console.WriteLine();
            Console.WriteLine("Resultado de la suma es:");
            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Elemento {i + 1}: {S[i]}");
            }

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}

