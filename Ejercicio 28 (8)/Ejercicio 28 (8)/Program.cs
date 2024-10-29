using System;
namespace Ejercicio_28__8_
{
    internal class Program
    {
        static void Main(string[] args)
        {

         int S = 0, N;

         Console.WriteLine("Introduce números enteros. Ingresa 0 para terminar y ver la sumatoria.");
         Console.WriteLine();

            do
            {
                Console.Write("Introduce un número: ");
                N = Convert.ToInt32(Console.ReadLine());

                S += N;
            }
            while (N != 0);


            Console.WriteLine($"La sumatoria de los números ingresados es: " + S);

         Console.WriteLine("\nPresione cualquier tecla para salir...");
         Console.ReadKey();

        }
    }
}
