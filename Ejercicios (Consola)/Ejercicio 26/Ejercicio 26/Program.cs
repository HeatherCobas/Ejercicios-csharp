using System;
namespace Ejercicio_26
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Números impares 1 al 30 By:Heather");
            Console.WriteLine();

            for (int i = 1; i <= 30; i++)
            {
                if (i % 2 != 0)
                { Console.WriteLine(i); }
            }

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();

        }
    }
}
