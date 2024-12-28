using System;
using System.Collections.Generic;

namespace Ejercicio_41
{
    internal class Program
    {
        static Dictionary<string, double> CiudadesTaxi = new Dictionary<string, double>
        {
            {"Santo Domingo Centro", 10},
            {"Santo Domingo Este", 15},
            {"Santo Domingo Oeste", 12},
            {"Boca Chica", 20},
            {"Juan Dolio", 35}
        };

        static Dictionary<string, double> CiudadesBusInterurbano = new Dictionary<string, double>
        {
            {"Santiago", 150},
            {"Puerto Plata", 250},
            {"La Vega", 130},
            {"San Cristóbal", 50},
            {"San Pedro de Macorís", 90},
            {"Samaná", 220}
        };

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Sistema de Boletos de Transporte By: Heather Cobas");
                Console.WriteLine("====================================================");
                Console.WriteLine("\nSeleccione el tipo de transporte:");
                Console.WriteLine("1. Taxi");
                Console.WriteLine("2. Metro");
                Console.WriteLine("3. Teleférico");
                Console.WriteLine("4. Bus Urbano");
                Console.WriteLine("5. Bus Interurbano");
                Console.WriteLine("6. Salir");
                Console.Write("\nIngrese su opción: ");

                int opcion = Convert.ToInt32(Console.ReadLine());

                if (opcion == 6) break;

                Boleto boleto = null;

                switch (opcion)
                {
                    case 1:
                        boleto = GenerarBoletoTaxi();
                        break;
                    case 2:
                        boleto = GenerarBoletoMetro();
                        break;
                    case 3:
                        boleto = GenerarBoletoTeleferico();
                        break;
                    case 4:
                        boleto = GenerarBoletoBusUrbano();
                        break;
                    case 5:
                        boleto = GenerarBoletoBusInterurbano();
                        break;
                    default:
                        Console.WriteLine("Opción inválida.");
                        continue;
                }

                boleto?.MostrarBoleto();

                Console.WriteLine("\nPresione cualquier tecla para continuar...");
                Console.ReadKey();
            }
        }

        static Taxi GenerarBoletoTaxi()
        {
            Console.WriteLine("\nDestinos de Taxi:");
            int i = 1;
            foreach (var ciudad in CiudadesTaxi)
            {
                Console.WriteLine($"{i}. {ciudad.Key} ({ciudad.Value} km)");
                i++;
            }
            Console.Write("\nSeleccione el destino (número): ");
            int seleccion = Convert.ToInt32(Console.ReadLine()) - 1;

            var destinoSeleccionado = new List<string>(CiudadesTaxi.Keys)[seleccion];
            var distancia = CiudadesTaxi[destinoSeleccionado];

            return new Taxi
            {
                Destino = destinoSeleccionado,
                Distancia = distancia
            };
        }

        static Metro GenerarBoletoMetro()
        {
            return new Metro
            {
                Compañía = "Metro de Santo Domingo",
                Línea = "Línea 1"
            };
        }

        static Teleferico GenerarBoletoTeleferico()
        {
            return new Teleferico
            {
                Compañía = "Teleférico de Santo Domingo",
                Línea = "Línea Central",
                Tiempo = 30
            };
        }

        static BusUrbano GenerarBoletoBusUrbano()
        {
            return new BusUrbano
            {
                Corredor = "Corredor Línea OMSA"
            };
        }

        static BusInterurbano GenerarBoletoBusInterurbano()
        {
            Console.WriteLine("\nDestinos de Bus Interurbano:");
            int i = 1;
            foreach (var ciudad in CiudadesBusInterurbano)
            {
                Console.WriteLine($"{i}. {ciudad.Key} ({ciudad.Value} km)");
                i++;
            }
            Console.Write("\nSeleccione el destino (número): ");
            int seleccion = Convert.ToInt32(Console.ReadLine()) - 1;

            var destinoSeleccionado = new List<string>(CiudadesBusInterurbano.Keys)[seleccion];
            var distancia = CiudadesBusInterurbano[destinoSeleccionado];

            return new BusInterurbano
            {
                Destino = destinoSeleccionado,
                Compañía = "Caribe Tours",
                Distancia = distancia,
                Tiempo = distancia / 60.0
            };
        }

        abstract class Boleto
        {
            public string Destino { get; set; }
            public double Tiempo { get; set; }
            public double Distancia { get; set; }

            public abstract double CalcularCosto();
            public abstract void MostrarBoleto();
        }

        class Taxi : Boleto
        {
            public override double CalcularCosto()
            {
                double tarifaBase = 250;
                double tarifaPorKm = 25;
                return tarifaBase + Distancia * tarifaPorKm;
            }

            public override void MostrarBoleto()
            {
                Console.WriteLine("Boleto de Taxi:");
                Console.WriteLine($"Destino: {Destino}");
                Console.WriteLine($"Distancia: {Distancia} km");
                Console.WriteLine($"Costo: RD${CalcularCosto():0.00}");
                Console.WriteLine("-----------------------------");
            }
        }

        class Metro : Boleto
        {
            public string Compañía { get; set; }
            public string Línea { get; set; }

            public override double CalcularCosto()
            {
                return 35;
            }

            public override void MostrarBoleto()
            {
                Console.WriteLine("Boleto de Metro:");
                Console.WriteLine($"Compañía: {Compañía}");
                Console.WriteLine($"Línea: {Línea}");
                Console.WriteLine($"Costo: RD${CalcularCosto():0.00}");
                Console.WriteLine("-----------------------------");
            }
        }

        class Teleferico : Boleto
        {
            public string Compañía { get; set; }
            public string Línea { get; set; }

            public override double CalcularCosto()
            {
                double tarifaBase = 100;
                return tarifaBase + Tiempo * 2;
            }

            public override void MostrarBoleto()
            {
                Console.WriteLine("Boleto de Teleférico:");
                Console.WriteLine($"Compañía: {Compañía}");
                Console.WriteLine($"Línea: {Línea}");
                Console.WriteLine($"Tiempo estimado: {Tiempo} minutos");
                Console.WriteLine($"Costo: RD${CalcularCosto():0.00}");
                Console.WriteLine("-----------------------------");
            }
        }

        class BusUrbano : Boleto
        {
            public string Corredor { get; set; }

            public override double CalcularCosto()
            {
                return 35;
            }

            public override void MostrarBoleto()
            {
                Console.WriteLine("Boleto de Bus Urbano:");
                Console.WriteLine($"Corredor: {Corredor}");
                Console.WriteLine($"Costo: RD${CalcularCosto():0.00}");
                Console.WriteLine("-----------------------------");
            }
        }

        class BusInterurbano : Boleto
        {
            public string Compañía { get; set; }

            public override double CalcularCosto()
            {
                double tarifaBase = 50;
                double tarifaPorKm = 5;
                return tarifaBase + Distancia * tarifaPorKm;
            }

            public override void MostrarBoleto()
            {
                Console.WriteLine("Boleto de Bus Interurbano:");
                Console.WriteLine($"Destino: {Destino}");
                Console.WriteLine($"Compañía: {Compañía}");
                Console.WriteLine($"Distancia: {Distancia} km");
                Console.WriteLine($"Tiempo estimado: {Tiempo:0.00} horas");
                Console.WriteLine($"Costo: RD${CalcularCosto():0.00}");
                Console.WriteLine("-----------------------------");
            }
        }
    }
}