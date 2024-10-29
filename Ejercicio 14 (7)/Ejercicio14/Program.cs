using System;
namespace DecimoCuarto_ejercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mayor o Menor By:Heather");
            Console.WriteLine();

            int N, N2;

            Console.WriteLine("Ingrese el primer número entero: ");
            N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número entero: ");
            N2 = Convert.ToInt32(Console.ReadLine());

            if (N > N2)
            {Console.WriteLine("El número mayor es: " + N);}

            else if (N < N2)
            {Console.WriteLine("El número mayor es: " + N2);}

            else
            {Console.Write("¡Ambos números son iguales!");}

        }
    }
}
