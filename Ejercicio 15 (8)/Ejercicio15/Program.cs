using System;
namespace DecimoQuintoejercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" By:Heather");
            Console.WriteLine();

            int N1, N2, N3;

            Console.Write("Ingrese un primer número entero: ");
            N1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese un segundo número entero: ");
            N2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese un tercer número entero: ");
            N3 = Convert.ToInt32(Console.ReadLine());


            if (N1 > N2 && N1 > N3)
            {
                Console.WriteLine("El número mayor es: " + N1);
            }

            else if (N2 < N1 && N2 > N3)
            {
                Console.WriteLine("El número mayor es: " + N2);
            }

            else
            {
                Console.WriteLine("El número mayor es: " + N3);
            }

        }
    }
}

