using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    static class Partida_Pantalla
    {
        private static Partida_Facade partidaEnJuego = new Partida_Facade();


        public static void PantallaInicioPartida()
        {
            Console.Clear();
            Console.Write($"        AHORCADO        \n" +
                          $"========================\n" +
                          $"Nombre: ");
            string nombre = Console.ReadLine();
            partidaEnJuego.NuevoJugador(nombre);
            partidaEnJuego.IniciarPartida();
            PantallaJugando();
        }


        public static void PantallaJugando()
        {
            bool perdio = false, gano = false;                          //Condiciones de salida
            do
            {
                Console.Clear();
                Console.WriteLine($"        AHORCADO        \n" +
                                  $"========================\n");
                foreach (char x in partidaEnJuego.VectorVisual)
                {
                    Console.Write(x + " ");                     //Muestra las letras adivinadas y "_" si no adivino.
                }
                Console.WriteLine("\nVidas restantes: "+ partidaEnJuego.VidasRestantes());
                Console.WriteLine($"\n\nLetra: ");
                char letra = char.Parse(Console.ReadLine());
                if (!partidaEnJuego.ComprobarLetra(letra))              //Si la letra no esta se aumentan los errores y devuelve false
                    perdio = partidaEnJuego.SinVidas();                 // Comprueba si perdio
                else
                    gano = partidaEnJuego.Victoria();                   //En caso contrario comprueba si gano
            } while (!perdio && !gano);

            Console.Clear();
            if (gano)
            {
                
                Console.WriteLine($"========================\n" +
                                  $"         GANASTE        \n" +
                                  $"========================\n");
                foreach (char x in partidaEnJuego.VectorVisual)
                {
                    Console.Write(x + " ");
                }
                Console.Write("\n" + partidaEnJuego.TerminarPartidaGanada());
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"========================\n" +
                                  $"        PERDISTE        \n" +
                                  $"========================\n");
                foreach (char x in partidaEnJuego.VectorVisual)
                {
                    Console.Write("\n " + x + " ");
                }
                Console.Write("\n" + partidaEnJuego.TerminarPartidaPerdida());
                Console.ReadKey();
            }
        }


        public static void PantallaCambioVidas()
        {
            Console.Clear();
            Console.WriteLine($"        AHORCADO        \n" +
                              $"========================\n");
            Console.Write("Numero de vidas: ");
            int vidas = int.Parse(Console.ReadLine());
            partidaEnJuego.Vida = vidas;
        }

        public static void PantallaMejoresTiempos()
        {
            Console.Clear();
            Console.WriteLine($"        AHORCADO        \n" +
                              $"========================\n" +
                              $" 5 Mejores Tiempos");
            for (int i = 0; i < partidaEnJuego.DevolverMejoresCincoPartidas().Count && i < 5; i++)
            {
                Console.WriteLine("Nombre: " + partidaEnJuego.DevolverMejoresCincoPartidas()[i].Jugador);
                Console.WriteLine("Tiempo: " + partidaEnJuego.DevolverMejoresCincoPartidas()[i].DuracionString());
            }
            Console.ReadKey();
        }
    }
}
