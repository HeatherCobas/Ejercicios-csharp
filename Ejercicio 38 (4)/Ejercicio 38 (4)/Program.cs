using System;
namespace Ejercicio_38__4_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Articulo[] articulos = new Articulo[2];

            for (int i = 0; i < articulos.Length; i++)
            {
                articulos[i] = new Articulo();

                Console.WriteLine($"\nIngrese los datos del artículo {i + 1}:");
                Console.Write("Nombre: ");
                articulos[i].Nombre = Console.ReadLine();
                Console.Write("Precio: ");
                articulos[i].Precio = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Categoría: ");
                articulos[i].Categoria = Console.ReadLine();
            }

            Console.WriteLine("\nDatos de los artículos:");
            for (int i = 0; i < articulos.Length; i++)
            {
              Console.WriteLine($"Artículo {i + 1}: Nombre: {articulos[i].Nombre}, Precio: {articulos[i].Precio:C}, Categoría: {articulos[i].Categoria}");
            }

            Console.ReadKey();
        }
    }

      class Articulo
      {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public string Categoria { get; set; }
      }
}
