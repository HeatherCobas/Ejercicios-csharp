using System;
namespace ejercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sueldo Empleado By:Heather");
            Console.WriteLine();

            double SN, ISR, SB, AFP, SFS,SA, AFr, SFr,T1,T2,exISR;

            AFr = 0.0287;
            SFr = 0.0304;
            T1 = 749822.00;
            T2 = 1041224.00;
            exISR = 499884.00;
            ISR = 0;

            Console.WriteLine("Ingrese el Sueldo del empleado: ");
            SB = Convert.ToDouble(Console.ReadLine());

            AFP = SB * AFr;
            SFS = SB * SFr;
            SA = SB * 12;

            if (SA > exISR)
            {
                if (SA <= T1)
                {ISR = (SA - exISR) * 0.15;}

                else if (SA <= T2)
                {ISR = (SA - T1) * 0.20 + 37_491.00;}

                else
                {ISR = (SA - T2) * 0.25 + 75_082.00;}
            }

            SN = SB - AFP - SFS - (ISR / 12);

            Console.WriteLine("Sueldo Bruto Mensual: RD$ " + SB);
            Console.WriteLine("Descuento AFP: RD$ " + AFP);
            Console.WriteLine("Descuento SFS: RD$ " + SFS);

            if (ISR > 0)
            {Console.WriteLine("ISR Mensual: RD$ " + (ISR / 12));}

            else
            {Console.WriteLine("ISR: No Aplica");}

            Console.WriteLine("Sueldo Neto Mensual: RD$ " + SN);


        }
    }
}
