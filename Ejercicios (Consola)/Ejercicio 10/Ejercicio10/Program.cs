using System;
namespace Decimo_ejercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculo_Promedio By:Heather");
            Console.WriteLine();

            double N1,N2,N3,N4,Suma,D,P;
            D = 5;

            Console.WriteLine("Ingrese la nota 1");
            N1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota 2");
            N2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota 3");
            N3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota 4");
            N4 = double.Parse(Console.ReadLine());

            Suma = N1 + N2 + N3 + N4;
            P = Suma / D;

            if (P < 70)
            {Console.WriteLine("Reprobado " + P);}

            else {Console.WriteLine("Aprobado " + P);}

        }
    }
}


