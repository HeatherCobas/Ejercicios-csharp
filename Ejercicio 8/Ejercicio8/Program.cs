using System;
namespace Octavo_ejercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Disco By:Heather");
            Console.WriteLine();

            int Edad;
            string Genero;

         Console.WriteLine("Ingrese su edad");
         Edad = Convert.ToInt32(Console.ReadLine());

         Console.WriteLine("Ingrese su genero(Femenino/Masculino)");
         Genero = Console.ReadLine();



            if (Genero == "Femenino" && Edad >= 18)
            { Console.WriteLine("Puede entrar gratis"); }

            else if (Genero == "Femenino" && Edad < 18)
            { Console.WriteLine("No puede pasar"); }

            else if (Genero == "Masculino" && Edad >= 18)
            {Console.WriteLine("Puede pasar pagando"); }

            else{Console.WriteLine("No puede pasar");}

        }
    }
}