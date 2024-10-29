using System;
namespace Ejercicio24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Suma primeros 100 números By:Heather");
            Console.WriteLine();

            int n = 100, S = 0, i = 1; 

            while (i <= n)
            {
                S = S + i; 
                i = i + 1; 
            }

            Console.WriteLine("La suma de los primeros 100 números naturales es: " + S);

        }
    }
}
