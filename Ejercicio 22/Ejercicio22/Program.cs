using System;

namespace ejercicio22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Contraseña By: Heather");
            Console.WriteLine();

            int C = 2008, Itm = 3, I = 0, Al;

            while (I < Itm)
            {

                Console.Write("Ingresa la contraseña (intento {0}/{1}): ", I + 1, Itm);
                bool isNumber = int.TryParse(Console.ReadLine(), out Al);

                if (Al == C)
                {
                    Console.WriteLine("Contraseña correcta. Acceso concedido.");
                    Console.WriteLine();
                    return;
                }
                else
                {
                    Console.WriteLine("Contraseña incorrecta. Intenta nuevamente.");
                    Console.WriteLine();
                    I++;
                }
            }
        }
    }
}

