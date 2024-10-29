using System;
namespace Sexto_ejercicio
    {  
    internal class Program
       {
        static void Main(string[] args) 


        { 
            double Cant, Precio, IMP, ITBIS, DES, TG; 

                DES = 0.10;

            //

            Console.WriteLine("Introduce el Precio Unitario");
            Precio = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduce la Cantidad de articulos");
            Cant = double.Parse(Console.ReadLine());

            IMP = Precio * Cant;
            ITBIS = IMP * 0.18;
            DES = IMP * 0.10;
            TG = (IMP - DES) + ITBIS;


            Console.WriteLine("El importe es de " + IMP);
            Console.WriteLine("El ITBIS es de " + ITBIS);
            Console.WriteLine("El Total General es de " + TG);
            




        }
    }
}