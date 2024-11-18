using System;
namespace Ejercicio_27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tabla de multiplicar del 7 By:Heather");
            Console.WriteLine();

            int N = 7;

            for (int i = 1; i <= 12; i++)
            {
                int R = N * i;
                Console.WriteLine($"{N} x {i} = {R}");
            }

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();

        }
    }
}

