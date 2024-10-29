using System;
namespace Ejercicio25
{
    internal class Program
    {
        static void Main(string[] args)
        {
         Console.WriteLine("Promedio primeros 100 números By:Heather");
         Console.WriteLine();

         int n = 100, S = 0, i = 1;
         Double P;


            while (i <= n)
            {
                S = S + i; 
                i = i + 1; 
            }

            P = S / n;

         Console.WriteLine("La suma de los primeros 100 números naturales es: " + S);
         Console.WriteLine("El promedio de los primeros 100 números naturales es: " + P);

         Console.WriteLine("\nPresione cualquier tecla para salir...");
         Console.ReadKey();

        }
    }
}
