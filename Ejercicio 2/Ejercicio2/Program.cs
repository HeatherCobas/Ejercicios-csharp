using System;
namespace Segundo_ejercicio
{internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculo_de_Sueldo By:Heather");
            Console.WriteLine();

            double PH, HT, AFS, SFP, SB, SN, RD;

            Console.WriteLine("Introduzca el Pago por hora");
            PH = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca las Horas trabajadas");
            HT = double.Parse(Console.ReadLine());

            SB = PH * HT;
            AFS = SB * 0.0287;
            SFP = SB * 0.0304;

            RD = AFS + SFP;
            SN = SB - RD;

            Console.WriteLine("El Sueldo Neto es de: " + SN);
        }

    }

}