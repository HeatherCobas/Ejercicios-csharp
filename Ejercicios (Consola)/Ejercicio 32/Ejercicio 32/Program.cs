using System;
namespace Ejercicio_32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Matrices By: Heather\n");

            Console.Write("Número de tipos de dispositivos: ");
            int tipos = int.Parse(Console.ReadLine());

            Console.Write("Número de almacenes: ");
            int alma = int.Parse(Console.ReadLine());

            string[] D = new string[tipos];
            int[,] inv = new int[tipos, alma];

            for (int i = 0; i < tipos; i++)
            {
                Console.Write($"\nNombre del dispositivo {i + 1}: ");
                D[i] = Console.ReadLine();

                for (int j = 0; j < alma; j++)
                {
                    Console.Write($"Cantidad de {D[i]} en almacén {j + 1}: ");
                    inv[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int j = 0; j < alma; j++)
            {
                int total = 0, maxCant = int.MinValue, minCant = int.MaxValue;
                string DMax = "", DMin = "";

                for (int i = 0; i < tipos; i++)
                {
                    total += inv[i, j];
                    if (inv[i, j] > maxCant) { maxCant = inv[i, j]; DMax = D[i]; }
                    if (inv[i, j] < minCant) { minCant = inv[i, j]; DMin = D[i]; }
                }

                Console.WriteLine($"\nAlmacén {j + 1}:");
                Console.WriteLine($" - Total de dispositivos: {total}");
                Console.WriteLine($" - Dispositivo con mayor cantidad: {DMax} con {maxCant} unidades");
                Console.WriteLine($" - Dispositivo con menor cantidad: {DMin} con {minCant} unidades");
            }

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}


