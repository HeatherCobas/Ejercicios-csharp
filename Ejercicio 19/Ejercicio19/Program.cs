using System;
namespace ejercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Incentivo Muchachos By:Heather");
            Console.WriteLine();

            int Nh;
            Double S, In;
            In = 0;

            Console.WriteLine("Ingrese el sueldo del empleado:");
            S = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el número de hijos del empleado:");
            Nh = Convert.ToInt32(Console.ReadLine());

            if (Nh > 0)
            {In = Nh * 500;}

            Console.WriteLine("Sueldo: " + S);
            Console.WriteLine("Número de hijos: " + Nh);

            if (In > 0)
            {
                Console.WriteLine("Incentivo: " + In);
                Console.WriteLine("Sueldo total: " + (S + In));
            }
            else
            {Console.WriteLine("Incentivo: N/A");}
        }
    }
}

