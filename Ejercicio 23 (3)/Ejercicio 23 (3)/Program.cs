using System;
namespace Ejercicio_23__3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sumatoria By: Heather");
            Console.WriteLine();

            int S = 0, N, C;

            Console.Write("¿Cuántos números deseas introducir? ");
            C = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < C; i++)
            {
                Console.Write("Introduce un número: ");
                N = Convert.ToInt32(Console.ReadLine());

                S += N;

                Console.WriteLine("Sumatoria actual: " + S);

                if (S >= 100)
                {
                    Console.WriteLine("La sumatoria es mayor o igual a 100.");
                    return;
                }
            }

            Console.WriteLine("La sumatoria no alcanzó 100.");

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}