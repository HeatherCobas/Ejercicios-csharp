using System;
namespace Ejercicio_36
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Sonidos animales By:Heather");
            Console.WriteLine();

            Animal animal = new Animal();
            Console.Write("Ingresa el tipo de animal (Perro, Gato o Ambos): ");
            animal.Nombre = Console.ReadLine();

            animal.HS();

            Console.ReadKey();

        }
    }

    class Animal
    {

        public string Nombre { get; set; }

        public void HS()
        {
            string S;

            if (Nombre.ToLower() == "perro")
            {
                S = "Guau guau";
                Console.WriteLine();
                Console.WriteLine($"El {Nombre} hace: {S}");
            }

            else if (Nombre.ToLower() == "gato")
            {
                S = "Miau miau";
                Console.WriteLine();
                Console.WriteLine($"El {Nombre} hace: {S}");
            }

            else if (Nombre.ToLower() == "ambos")
            {
                Console.WriteLine();
                Console.WriteLine("El gato hace miau miau y el perro hace guau guau");
            }

            else
            { Console.WriteLine("Animal desconocido"); }

        }
    }
}
