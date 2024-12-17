using System;
using System.Collections.Generic;
namespace Ejercicio_43
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista de Colores By:Heather");
            Console.WriteLine();

            List<string> list = new List<string>();


            list.Add("Rojo");
            list.Add("Amarillo");
            list.Add("Verde");
            list.Add("Azul");
            list.Add("Gris");
            list.Add("Naranja");


            foreach (var color in list)
            { Console.WriteLine("Color " + color); }


            Console.WriteLine("Insertar un objeto en un indice especifico");
            Console.WriteLine();
            list.Insert(2, "Negro");

            foreach (var color in list)
            { Console.WriteLine("Color " + color); }

            Console.WriteLine();
            Console.WriteLine("Determinar si se encuentra un objeto dentro de la lista");
            Console.WriteLine();

            var resul = list.Contains("Negro");

            if (resul)
            { Console.WriteLine("Si el elemento se encuentra en la lista..."); }

            else
            { Console.WriteLine("Si el elemento no se encuentra en la lista..."); }


            Console.WriteLine();
            Console.WriteLine("Ordenar los elementos de forma ascendente");
            Console.WriteLine();

            list.Sort();
            foreach (var color in list)
            { Console.WriteLine("Color " + color); }

            Console.WriteLine();
            Console.WriteLine("Ordenar los elementos de forma descendente");
            Console.WriteLine();

            list.Reverse();
            foreach (var color in list)
            { Console.WriteLine("Color " + color); }


            //Eliminar elementos de la lista

            Console.WriteLine("Eliminar elementos de la lista");
            Console.WriteLine();
            list.Remove("Rojo");

            foreach (var color in list)
            { Console.WriteLine("Color " + color); }

            Console.WriteLine("Eliminar elementos de la lista");
            Console.WriteLine();

            list.Remove("3");
            foreach (var color in list)
            { Console.WriteLine("Color " + color); }


            Console.WriteLine("Determine la cantidad de elementos en la lista...");
            Console.WriteLine();
            Console.WriteLine("Cantidad de elementos: " + list.Count);
            Console.WriteLine();

            Console.WriteLine("Limpiar la lista.");

            Console.WriteLine();
            Console.WriteLine("Cantidad inicial de la lista." + list.Capacity);



            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();

        }
    }
}