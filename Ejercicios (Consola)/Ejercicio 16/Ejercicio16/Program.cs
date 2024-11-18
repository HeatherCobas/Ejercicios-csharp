using System;
namespace ejercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mayor,centra y menor By:Heather");
            Console.WriteLine();

            double N1, N2, N3, M, C, ME;


            Console.Write("Ingrese un primer número entero: ");
            N1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese un segundo número entero: ");
            N2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese un tercer número entero: ");
            N3 = Convert.ToInt32(Console.ReadLine());


            if (N1 > N2 && N1 > N3)
            {
                M = N1;
                if (N2 > N3)
                {
                    C = N2;
                    ME = N3;
                }
                else
                {
                    C = N3;
                    ME = N2;
                }
            }
            else if (N2 > N1 && N2 > N3)
            {
                M = N2;
                if (N1 > N3)
                {
                    C = N1;
                    ME = N3;
                }
                else
                {
                    C = N3;
                    ME = N1;
                }
            }
            else
            {
                M = N3;
                if (N1 > N2)
                {
                    C = N1;
                    ME = N2;
                }
                else
                {
                    C = N2;
                    ME = N1;
                }
            }

            Console.WriteLine("El número mayor es: " + M);
            Console.WriteLine("El número central es: " + C);
            Console.WriteLine("El número menor es: " + ME);

        }
    }
}

