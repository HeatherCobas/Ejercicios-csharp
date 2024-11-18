using System;
namespace Quinto_Ejercicio
{ 
   internal class Program
    {
        static void Main(string[] args) 
        {

        double Cant, Precio, IMP;

        Console.WriteLine("Calculo_Importe By:Heather");
        Console.WriteLine();

        Console.WriteLine("Introdusca la cantidad de articulos");
        Cant = double.Parse(Console.ReadLine());
        Console.WriteLine("Introdusca el Precio Unitario de los articulos");
        Precio = double.Parse(Console.ReadLine());
         

        IMP = Precio * Cant;

        Console.WriteLine("El importe es de " + IMP);


        }
    }
}
