using System;
namespace ejercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" By:Heather");
            Console.WriteLine();


            int lunes, martes, miercoles, jueves, viernes;

            Console.WriteLine("Ingrese la producción del lunes:");
            lunes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese la producción del martes:");
            martes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese la producción del miércoles:");
            miercoles = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese la producción del jueves:");
            jueves = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese la producción del viernes:");
            viernes = Convert.ToInt32(Console.ReadLine());

            int totalproduccion = lunes + martes + miercoles + jueves + viernes;
            double promedioproduccion = totalproduccion / 5;

            Console.WriteLine("Total de la producción semanal: " + totalproduccion);
            Console.WriteLine("Promedio de la producción semanal: " + promedioproduccion);

            if (promedioproduccion >= 20000)
            {
                Console.WriteLine("Incentivo: 3000");
            }
            else
            {
                Console.WriteLine("Incentivo: N/A");
            }


        }
    }
}
