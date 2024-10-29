using System;
namespace ejercicio30
{
    internal class Program
    {

        static int S(int a, int b)
        { return a + b; }

        static int M(int a, int b)
        { return a * b; }

        static void PoI(int numero)

        {
            if (numero % 2 == 0)

            { Console.WriteLine("El número " + numero + " es par."); }

            else
            { Console.WriteLine("El número " + numero + " es impar."); }
        }

        static double DaP(double d)

        {
            double tasaCambio = 60.27;
            return d * tasaCambio;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(" Funciones By:Heather");
            Console.WriteLine();


            Console.WriteLine("Introduce el primer número: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el segundo número: ");
            int n2 = int.Parse(Console.ReadLine());


            
            
            int RS = S(n1, n2);
            Console.WriteLine("La suma de " + n1 + " y " + n2 + " es: " + RS);
            Console.WriteLine();

            int RM = M(n1, n2);
            Console.WriteLine("La multiplicación de " + n1 + " y " + n2 + " es: " + RM);
            Console.WriteLine();

            Console.WriteLine("Introduce la cantidad en dólares para convertir a pesos dominicanos:");
            double d = double.Parse(Console.ReadLine());


            double P = DaP(d);
            Console.WriteLine(d + " dólares son equivalentes a " + P + " pesos dominicanos.");
            Console.WriteLine();


            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
