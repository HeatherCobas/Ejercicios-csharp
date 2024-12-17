using System;
namespace Ejercicio_40
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Operaciones Basicas Herencia By:Heather");
                Console.WriteLine("===================================");
                Console.WriteLine();

                double N1, N2;

                Console.Write("Introduce el primer número: ");
                N1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Introduce el segundo número: ");
                N2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("\nSeleccione la operación:");
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicación");
                Console.WriteLine("4. División");
                Console.WriteLine("5. Salir");
                Console.Write("Ingrese su opción (1-5): ");

                int opción = Convert.ToInt32(Console.ReadLine());
                OperacionMatematica operación;

                switch (opción)
                {
                    case 1:
                        operación = new Suma();
                        break;
                    case 2:
                        operación = new Resta();
                        break;
                    case 3:
                        operación = new Multiplicacion();
                        break;
                    case 4:
                        operación = new Division();
                        break;
                    case 5:
                        Console.WriteLine("Gracias por usar el programa.");
                        return;
                    default:
                        Console.WriteLine("Operación no válida.");
                        return;
                }
                double resultado = operación.Calcular(N1, N2);
                Console.WriteLine($"\nResultado: {resultado}");
                Console.WriteLine();
                Console.ReadKey();
            }
        }
        public abstract class OperacionMatematica
        { public abstract double Calcular(double N1, double N2); }
        public class Suma : OperacionMatematica
        {
            public override double Calcular(double N1, double N2)
            { return N1 + N2; }
        }
        public class Resta : OperacionMatematica
        {
            public override double Calcular(double N1, double N2)
            { return N1 - N2; }
        }
        public class Multiplicacion : OperacionMatematica
        {
            public override double Calcular(double N1, double N2)
            { return N1 * N2; }
        }
        public class Division : OperacionMatematica
        {
            public override double Calcular(double N1, double N2)
            {
                if (N2 == 0)
                {
                    throw new DivideByZeroException("No se puede dividir por cero.");
                }
                return N1 / N2;
            }
        }
    }
}