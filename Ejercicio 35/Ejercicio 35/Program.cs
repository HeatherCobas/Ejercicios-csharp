using System;
namespace Ejercicio_35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 clase = new Class1();
            Console.Write("Introduce el tipo de dispositivo: ");
            clase.Tipo = Console.ReadLine();

            Console.WriteLine();
            Console.Write("Introduce el color del dispositivo: ");
            clase.Color = Console.ReadLine();

            Console.WriteLine();
            Console.Write("Introduce la marca del dispositivo: ");
            clase.Marca = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine($"El dispositivo es un {clase.Tipo} de color {clase.Color} y de la marca {clase.Marca}.");
            Console.WriteLine();

            clase.Encender();
            clase.Fondo();
            clase.ReproducirMusica();
            clase.AjustarVolumen();
            clase.Apagar();

            Console.ReadKey();
        }
    }

    class Class1
    {
      public string Tipo { get; set; }
      public string Color { get; set; }
      public string Marca { get; set; }

      public void Encender()
      { Console.WriteLine($"El {Tipo} se enciende."); }

      public void Apagar()
      { Console.WriteLine($"El {Tipo} se puede apagar."); }

      public void ReproducirMusica()
      { Console.WriteLine($"El {Tipo} reproduce música."); }

      public void Fondo()
      { Console.WriteLine($"Al {Tipo} se le puede cambiar el fondo."); }

      public void AjustarVolumen()
      { Console.WriteLine($"Al {Tipo} se le puede ajustar el volumen."); }
    }
}

