using System;
namespace Decimotercero_ejercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Par o Impar By:Heather");
            Console.WriteLine();

            int N;

            Console.WriteLine("Ingrese el Número");
            N = Convert.ToInt32(Console.ReadLine());

            if (N % 2 == 0)
            {
                Console.WriteLine("¡El número ingresado es: " + N);
                Console.WriteLine("¡El número es par!");
            }

            else
            {
                Console.WriteLine("¡El número ingresado es: " + N);
                Console.WriteLine("¡El número ingresado es impar!");
            }


        }
    }
}

