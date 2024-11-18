using System;
namespace Cuarto_Ejercicio
{ 
    internal class Program
    {  
      static void Main(string[] args)
      {
            Console.WriteLine("Promedio By:Heather");
            Console.WriteLine();

            double Num1, Num2, Num3, Num4, Num5, PR, D, Suma;

            D = 5;

            Console.WriteLine("Introdusca el primer número ");
            Num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Introdusca el segundo número ");
            Num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Introdusca el tercer número ");
            Num3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Introdusca el cuarto número ");
            Num4 = double.Parse(Console.ReadLine());
            Console.WriteLine("Introdusca el quinto número ");
            Num5 = double.Parse(Console.ReadLine());1

            Suma = Num1 + Num2 + Num3 + Num4 + Num5;

            PR = Suma / D;

            Console.WriteLine("El promedio es de " + PR);



        } 
    }
}

