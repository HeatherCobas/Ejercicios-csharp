using System;
namespace Ejercicio_34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Suma de números By:Heather");
            Console.WriteLine();

            Console.WriteLine("Introduce 5 números:");

            int[] numeros = new int[5];
            int suma = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write($"Número {i + 1}: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
                suma += numeros[i];
            }

            Console.WriteLine();


            if (suma == 100)
            { Console.WriteLine($"La suma de los números es: {suma}. igual a 100."); }

            else if (suma > 100)
            { Console.WriteLine($"La suma de los números es: {suma}. Es mayor."); }

            else
            { Console.WriteLine($"La suma de los números es: {suma}. Es menor a 100."); }


            Console.ReadKey();
        }
    }
}
