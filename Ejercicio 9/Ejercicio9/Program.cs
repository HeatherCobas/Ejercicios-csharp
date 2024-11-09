using System;
namespace Noveno_ejercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("  By:Heather");
            Console.WriteLine();

            double P,D,T;

            Console.Write("Ingrese el precio del articulo: ");
            P = Convert.ToDouble(Console.ReadLine());

            if (P >= 1000)
            {
                D = P * 0.3;
                T = P - D;
                Console.Write("El precio del articulo es:" + P);
                Console.Write("El descuento es:" + T);
            }

            else if (P >= 5001)
            {
                D = P * 0.5;
                T = P - D;
                Console.Write("El precio del articulo es:" + P);
                Console.Write("El descuento es:" + T);
            }

            else if (P >= 10001)
            {
                D = P * 0.8;
                T = P - D;
                Console.Write("El precio del articulo es:" + P);
                Console.Write("El descuento es:" + T);
            }

            else if (P >= 15001 && P >= 20000)
            {
                D = P * 0.10;
                T = P - D;
                Console.Write("El precio del articulo es:" + P);
                Console.Write("El descuento es:" + T);
            }


            else
            {
                Console.Write("No recibe descuento");
            }


        }
    }
}
