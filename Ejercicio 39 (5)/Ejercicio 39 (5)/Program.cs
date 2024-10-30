using System;
namespace Ejercicio_39__5_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Estudiantes By:Heather");
            Console.WriteLine();


            Estudiante[] estudiantes = new Estudiante[5];

            for (int i = 0; i < estudiantes.Length; i++)
            {
                Console.WriteLine($"Ingrese los datos del estudiante {i + 1}:");

                Console.Write("Matrícula: ");
                string Matricula = Console.ReadLine();

                Console.Write("Nombre: ");
                string Nombre = Console.ReadLine();

                Console.Write("Edad: ");
                int Edad = int.Parse(Console.ReadLine());

                Console.Write("Carrera: ");
                string Carrera = Console.ReadLine();
            }

            Console.WriteLine("Lista de estudiantes ingresados:");
            Console.WriteLine();

            foreach (Estudiante estudiante in estudiantes)
            {
                Console.WriteLine($"Matrícula: {estudiante.Matricula}, Nombre: {estudiante.Nombre}, Edad: {estudiante.Edad}, Carrera: {estudiante.Carrera}");
            }
        }
    }

    class Estudiante
    {
     
        public string Matricula { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Carrera { get; set; }


    }
}
