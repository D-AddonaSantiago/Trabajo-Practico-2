using System;
using System.IO;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                char condicion;
                do
                {
                    Console.Clear();
                    Console.WriteLine($"        AHORCADO        \n" +
                                      $"========================\n" +
                                      $" 1- Iniciar Juego\n" +
                                      $" 2- Cambiar intentos por palabra\n" +
                                      $" 3- Mejores tiempos\n" +
                                      $"\n" +
                                      $" 0- Salir\n");
                    condicion = char.Parse(Console.ReadLine());
                    switch (condicion)
                    {
                        case '1':
                            Partida_Pantalla.PantallaJugando();
                            break;
                        case '2':
                            Partida_Pantalla.PantallaCambioVidas();
                            break;
                        case '3':
                            Partida_Pantalla.PantallaMejoresTiempos();
                            break;
                        default:
                            break;
                    }
                } while (condicion != 0);
            }
            catch (ArgumentException)
            {
                Console.Clear();
                Console.WriteLine("Error en el tipo de dato");
                Console.ReadKey();
            }
        }
    }
}
