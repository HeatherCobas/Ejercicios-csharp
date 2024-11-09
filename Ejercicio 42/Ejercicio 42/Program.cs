using System;
namespace Ejercicio_42
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Papeles y Utencilios By:Heather");
            Console.WriteLine();

            Console.WriteLine("Ingrese los datos del papel:");
            Console.Write("Nombre: ");
            string nombrePapel = Console.ReadLine();
            Console.Write("Precio: ");
            decimal precioPapel = decimal.Parse(Console.ReadLine());
            Console.Write("Cantidad: ");
            int cantidadPapel = int.Parse(Console.ReadLine());
            Console.Write("Tipo de Papel: ");
            string tipoPapel = Console.ReadLine();
            Console.Write("Tamaño: ");
            string tamañoPapel = Console.ReadLine();

            Papel papel = new Papel(nombrePapel, precioPapel, cantidadPapel, tipoPapel, tamañoPapel);
            Console.WriteLine("\nDatos del producto (Papel):");
            papel.MostrarInformacion();

            Console.WriteLine("\nIngrese los datos del utensilio:");
            Console.Write("Nombre: ");
            string nombreUtensilio = Console.ReadLine();
            Console.Write("Precio: ");
            decimal precioUtensilio = decimal.Parse(Console.ReadLine());
            Console.Write("Cantidad: ");
            int cantidadUtensilio = int.Parse(Console.ReadLine());
            Console.Write("Material: ");
            string materialUtensilio = Console.ReadLine();
            Console.Write("Color: ");
            string colorUtensilio = Console.ReadLine();

            Utensilio utensilio = new Utensilio(nombreUtensilio, precioUtensilio, cantidadUtensilio, materialUtensilio, colorUtensilio);
            Console.WriteLine("\nDatos del producto (Utensilio):");
            utensilio.MostrarInformacion();


            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();

        }
    }

    public class Producto
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }

        public Producto(string nombre, decimal precio, int cantidad)
        {
            Nombre = nombre;
            Precio = precio;
            Cantidad = cantidad;
        }

        public virtual void MostrarInformacion()
        { Console.WriteLine($"Nombre: {Nombre}, Precio: {Precio:C}, Cantidad: {Cantidad}"); }

    }

    public class Papel : Producto
    {
        public string TipoDePapel { get; set; }
        public string Tamaño { get; set; }

        public Papel(string nombre, decimal precio, int cantidad, string tipoDePapel, string tamaño)
            : base(nombre, precio, cantidad)
        {
            TipoDePapel = tipoDePapel;
            Tamaño = tamaño;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Tipo de Papel: {TipoDePapel}, Tamaño: {Tamaño}");
        }
    }

    public class Utensilio : Producto
    {
        public string Material { get; set; }
        public string Color { get; set; }

        public Utensilio(string nombre, decimal precio, int cantidad, string material, string color)
            : base(nombre, precio, cantidad)
        {
            Material = material;
            Color = color;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Material: {Material}, Color: {Color}");
        }
    }
}

