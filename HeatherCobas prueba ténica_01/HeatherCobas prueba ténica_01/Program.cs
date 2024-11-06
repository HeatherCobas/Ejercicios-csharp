using System;
namespace HeatherCobas_prueba_ténica_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Teatro El Títere By:Heather");
            Console.WriteLine();

            Teatro.Empezar();
            int opción;

            do
            {
             Console.WriteLine("1. Ver el mapa de asientos");
             Console.WriteLine("2. Reservar un asiento");
             Console.WriteLine("3. Salir");

             Console.WriteLine();
             Console.Write("Seleciona una opción: ");
             opción = int.Parse(Console.ReadLine());
             Console.WriteLine();

              switch (opción) 
              { 
                 case 1: 
                       Teatro.Mostrar();
                        break;
                 case 2:
                    Console.Write("Ingrese número de fila (1-10): ");
                    int fila = int.Parse(Console.ReadLine());

                    Console.Write("Ingrese número de asiento (1-10): ");
                    int asiento = int.Parse(Console.ReadLine());
                    Teatro.Reserva(fila, asiento);
                   break;

                 case 3:
                      Console.WriteLine("Saliendo");
                        break;

                 default:
                      Console.WriteLine("Opción Invalida.");
                      break;
                } 
            }while (opción != 3) ;
        }
    }

    class Teatro
    {
        const int Filas = 10;
        const int Asientos = 10;
        static char[,] mapa = new char[Filas, Asientos];

      public static void Empezar()
      {
            for (int i = 0; i < Filas; i++)
                for (int j = 0; j < Asientos; j++)
                    mapa[i, j] = 'L';

      }

     public static void Mostrar()
        {
            Console.WriteLine("Mapa de asientos (X = Ocupado, L = Libre):\n");
            for (int i = 0; i < Filas; i++)
            {
                Console.Write($"{i + 1} ");
                for (int j = 0; j < Asientos; j++)
                    Console.Write(mapa[i, j] + " ");
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static void Reserva(int fila, int asiento)
      {
            if (fila < 1 || fila > Filas || asiento < 1 || asiento > Asientos)
            {
                Console.WriteLine("Número de fila o asiento no válido. Intente nuevamente.");
                return;
            }

            if (mapa[fila - 1, asiento - 1] == 'L')
            {
                mapa[fila - 1, asiento - 1] = 'X';

                Console.WriteLine();
                Console.WriteLine("Asiento reservado con éxito.");
                Console.WriteLine();

            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("El asiento ya está ocupado. Por favor, elija otro asiento.");
                Console.WriteLine();
            }
        }
    }
}
