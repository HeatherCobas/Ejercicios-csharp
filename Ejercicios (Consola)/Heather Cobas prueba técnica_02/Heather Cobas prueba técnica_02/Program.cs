using System;
using System.Collections.Generic;
using System.Linq;

namespace Heather_Cobas_prueba_técnica_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Estudiantes By: Heather");
            Console.WriteLine();

            List<RegistroAcademico> registros = new List<RegistroAcademico>();

            while (true)
            {
                Console.WriteLine("\nMenú de Opciones:");
                Console.WriteLine("1. Agregar estudiante y registro académico");
                Console.WriteLine("2. Mostrar registros académicos");
                Console.WriteLine("3. Agregar nueva asignatura a un estudiante existente");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        AgregarEstudiante(registros);
                        break;
                    case 2:
                        MostrarRegistros(registros);
                        break;
                    case 3:
                        AgregarAsignaturaExistente(registros);
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
            }
        }

        static void AgregarEstudiante(List<RegistroAcademico> registros)
        {
            Console.Write("\nIngrese el nombre del estudiante: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese la edad del estudiante: ");
            int edad = int.Parse(Console.ReadLine());

            Estudiante estudiante = new Estudiante(nombre, edad);
            RegistroAcademico registro = new RegistroAcademico(estudiante);

            Console.WriteLine();
            Console.Write("¿Cuántas asignaturas desea agregar? ");
            int cantidadAsignaturas = int.Parse(Console.ReadLine());

            for (int i = 1; i <= cantidadAsignaturas; i++)
            {
                Console.Write($"\nIngrese el nombre de la asignatura {i}: ");
                string nombreAsignatura = Console.ReadLine();
                Console.Write($"Ingrese la calificación de {nombreAsignatura}: ");
                double calificacion = double.Parse(Console.ReadLine());

                registro.AgregarAsignatura(nombreAsignatura, calificacion);
            }

            registros.Add(registro);
            Console.WriteLine("\nEstudiante y asignaturas agregados con éxito.");
        }

        static void MostrarRegistros(List<RegistroAcademico> registros)
        {
            if (registros.Count == 0)
            {
                Console.WriteLine("\nNo hay registros académicos disponibles.");
            }
            else
            {
                foreach (var registro in registros)
                {
                    registro.MostrarRegistro();
                }
            }
        }

        static void AgregarAsignaturaExistente(List<RegistroAcademico> registros)
        {
            Console.Write("\nIngrese el nombre del estudiante al que desea agregar una asignatura: ");
            string nombreEstudiante = Console.ReadLine();

            RegistroAcademico registro = registros.Find(r => r.Estudiante.Nombre.Equals(nombreEstudiante, StringComparison.OrdinalIgnoreCase));

            if (registro == null)
            {
                string nombreSugerido = EncontrarNombreMasSimilar(nombreEstudiante, registros);
                if (!string.IsNullOrEmpty(nombreSugerido))
                {
                    Console.WriteLine($"\nNo se encontró el estudiante '{nombreEstudiante}'. ¿Quiso decir '{nombreSugerido}'? (si/no): ");
                    string respuesta = Console.ReadLine();
                    if (respuesta?.ToLower() == "si")
                    {
                        registro = registros.Find(r => r.Estudiante.Nombre.Equals(nombreSugerido, StringComparison.OrdinalIgnoreCase));

                        Console.WriteLine($"\nEstudiante '{nombreSugerido}' seleccionado.");
                        Console.Write("¿Desea agregar la asignatura a este estudiante? (si/no): ");
                        string confirmacion = Console.ReadLine();

                        if (confirmacion?.ToLower() != "si")
                        {
                            Console.WriteLine("Regresando al menú.");
                            return;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Regresando al menú.");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("\nNo se encontró ningún estudiante con un nombre similar. Regresando al menú.");
                    return;
                }
            }

            Console.Write("\nIngrese el nombre de la nueva asignatura: ");
            string nombreAsignatura = Console.ReadLine();

            if (registro.AsignaturaExiste(nombreAsignatura))
            {
                Console.WriteLine("\nLa asignatura ya está registrada para este estudiante.");
            }
            else
            {
                Console.Write("Ingrese la calificación de la nueva asignatura: ");
                double calificacion = double.Parse(Console.ReadLine());

                registro.AgregarAsignatura(nombreAsignatura, calificacion);
                Console.WriteLine("\nAsignatura agregada con éxito.");
            }
        }

        static string EncontrarNombreMasSimilar(string nombreIngresado, List<RegistroAcademico> registros)
        {
            string nombreMasSimilar = null;
            int menorDistancia = int.MaxValue;

            foreach (var registro in registros)
            {
                int distancia = CalcularDistanciaLevenshtein(nombreIngresado, registro.Estudiante.Nombre);
                if (distancia < menorDistancia)
                {
                    menorDistancia = distancia;
                    nombreMasSimilar = registro.Estudiante.Nombre;
                }
            }

            return menorDistancia <= 3 ? nombreMasSimilar : null;
        }

        static int CalcularDistanciaLevenshtein(string a, string b)
        {
            int[,] distancia = new int[a.Length + 1, b.Length + 1];

            for (int i = 0; i <= a.Length; i++)
                distancia[i, 0] = i;

            for (int j = 0; j <= b.Length; j++)
                distancia[0, j] = j;

            for (int i = 1; i <= a.Length; i++)
            {
                for (int j = 1; j <= b.Length; j++)
                {
                    int costo = (a[i - 1] == b[j - 1]) ? 0 : 1;
                    distancia[i, j] = Math.Min(Math.Min(
                        distancia[i - 1, j] + 1,
                        distancia[i, j - 1] + 1),
                        distancia[i - 1, j - 1] + costo);
                }
            }

            return distancia[a.Length, b.Length];
        }
    }

    class Estudiante
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public Estudiante(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }
    }

    class Asignatura
    {
        public string Nombre { get; set; }
        public double Calificacion { get; set; }

        public Asignatura(string nombre, double calificacion)
        {
            Nombre = nombre;
            Calificacion = calificacion;
        }
    }

    class RegistroAcademico
    {
        public Estudiante Estudiante { get; set; }
        private List<Asignatura> Asignaturas;

        public RegistroAcademico(Estudiante estudiante)
        {
            Estudiante = estudiante;
            Asignaturas = new List<Asignatura>();
        }

        public void AgregarAsignatura(string nombreAsignatura, double calificacion)
        {
            Asignaturas.Add(new Asignatura(nombreAsignatura, calificacion));
        }

        public bool AsignaturaExiste(string nombreAsignatura)
        {
            return Asignaturas.Exists(a => a.Nombre.Equals(nombreAsignatura, StringComparison.OrdinalIgnoreCase));
        }

        public void MostrarRegistro()
        {
            Console.WriteLine($"\nRegistro Académico de {Estudiante.Nombre}, Edad: {Estudiante.Edad}");
            foreach (var asignatura in Asignaturas)
            {
                Console.WriteLine($"Asignatura: {asignatura.Nombre}, Calificación: {asignatura.Calificacion}");
            }
            Console.WriteLine($"Promedio: {CalcularPromedio():F2}\n");
        }

        public double CalcularPromedio()
        {
            double suma = Asignaturas.Sum(a => a.Calificacion);
            return Asignaturas.Count > 0 ? suma / Asignaturas.Count : 0;
        }
    }
}