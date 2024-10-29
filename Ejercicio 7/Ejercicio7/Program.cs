using System;
namespace Septimo_ejercicio
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Sueldo By:Heather");
            Console.WriteLine();

            double Sueldo,Aumento,T;

            Console.WriteLine("Ingrese el sueldo");
            Sueldo = double.Parse(Console.ReadLine());

            Aumento = Sueldo * 0.15;
            T = Sueldo + Aumento;

            Console.WriteLine("El sueldo anterior es: " + Sueldo);
            Console.WriteLine("El aumento es de: " + Aumento);
            Console.WriteLine("El sueldo nuevo es de: " + T);
        }
    }
}