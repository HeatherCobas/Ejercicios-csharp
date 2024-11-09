using System;
namespace Ejercicio_29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Triangulo de * By:Heather");
            Console.WriteLine();

            int F;

            Console.Write("Ingrese el número de filas para el triángulo: ");
            F = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= F; i++)
            {
                for (int j = 1; j <= i; j++)
                { Console.Write("* "); }

                Console.WriteLine();
            }

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();

        }
    }
}
