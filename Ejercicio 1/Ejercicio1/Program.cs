using System;
namespace Primer_ejercicio
{
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Calculadora By:Heather");
        Console.WriteLine();

        double Num1, Num2, Suma, Resta, Multiplicación, Divición;

        Console.WriteLine("Introduce el primer valor: ");
        Num1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Introduce el segundo valor: ");
        Num2 = double.Parse(Console.ReadLine());
        Console.WriteLine();

        Suma = Num1 + Num2;
        Resta = Num1 - Num2;
        Multiplicación = Num1 * Num2 ;
        Divición = Num1 / Num2;

        Console.WriteLine("El resultado de la Suma es: " + Suma);
        Console.WriteLine("El resultado de la Resta es: " + Resta);
        Console.WriteLine("El resultado de la Multiplicación es: " + Multiplicación);
        Console.WriteLine("El resultado de la Divición es: " + Divición);
    }

  } 

}