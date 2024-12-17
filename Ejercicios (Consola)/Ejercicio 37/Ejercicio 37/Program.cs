using System;
namespace Ejercicio_37
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Gestión de contactos By:Heather");
            Console.WriteLine();

            Contactos[] contactos = new Contactos[3];

            for (int i = 0; i < contactos.Length; i++)
            {
                contactos[i] = new Contactos();
                Console.WriteLine($"Contactos: " + (i + 1));
                Console.Write("Nombre: ");
                contactos[i].Name = Console.ReadLine();
                Console.Write("Edad: ");
                contactos[i].Age = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine();
            }

            Console.WriteLine("Lista contactos");
            Console.WriteLine();

            for (int i = 0; i < contactos.Length; i++)
            {
                Console.WriteLine("Contacto: " + (i + 1));
                Console.WriteLine("Nombre: " + contactos[i].Name);
                Console.WriteLine("Edad: " + contactos[i].Age);
                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }

    class Contactos
    {
        public string Name { get; set; }
        public int Age { get; set; }

    }

}