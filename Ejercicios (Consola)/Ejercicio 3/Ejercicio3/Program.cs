using System; 
namespace Tercer_ejercicio
{
    internal class Program
    { 
        static void Main(string[] args) 
       {
            Console.WriteLine("Calcuadora2.0 By:Heather");
            Console.WriteLine();

            double Num1, Num2, Num3, Suma, Resta, Multiplicación, Divición;

            Console.WriteLine("Introduce el primer valor: ");
            Num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el segundo valor: ");
            Num2 = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Introduce el tercer valor: ");
            Num3 = double.Parse(Console.ReadLine());
            Console.WriteLine();



            Suma = Num1 + Num2 + Num3;
            Resta = Num1 - Num2 - Num3 ;
            Multiplicación = Num1 * Num2 * Num3;
            Divición = Num1 / Num2 / Num3;


            Console.WriteLine("El resultado de la Suma es: " + Suma);
            Console.WriteLine("El resultado de la Resta es: " + Resta);
            Console.WriteLine("El resultado de la Multiplicación es: " + Multiplicación);
            Console.WriteLine("El resultado de la Divición es: " + Divición);



        }
    }
}
