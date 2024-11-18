using System;
namespace Ejercicio_33
{
    internal class Program
    {
        static void MostrarEstudiantes(string[] Nom, int[] Cali)
        {

            Console.WriteLine("Lista de estudiantes y sus calificaciones:");


            for (int i = 0; i < Nom.Length; i++)
            {

                Console.WriteLine();
                Console.WriteLine($"Estudiante: {Nom[i]}, Calificación: {Cali[i]}");

            }
        }

        static void Main()
        {
            Console.Write("Ingrese la cantidad de estudiantes: ");
            int Cant = int.Parse(Console.ReadLine());
            Console.WriteLine();

            string[] Nom = new string[Cant];
            int[] Cali = new int[Cant];


            for (int i = 0; i < Cant; i++)
            {
                Console.Write($"Ingrese el nombre del estudiante {i + 1}: ");
                Nom[i] = Console.ReadLine();


                Console.Write($"Ingrese la calificación de {Nom[i]}: ");
                Cali[i] = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }

            MostrarEstudiantes(Nom, Cali);

            Console.ReadKey();
        }
    }
}
