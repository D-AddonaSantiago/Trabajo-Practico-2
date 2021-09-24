using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    public class Pantalla
    {
        FachadaPartida fachadaPartida = new FachadaPartida();
        

        public void PantallaPrincipal()
        {
            int op = -1;
            while (op !=0)
            {
                Console.Clear();
                Console.WriteLine("----------------- AHORCADO -----------------");
                Console.WriteLine("1 - Partida Rapida ");
                Console.WriteLine("2 - Partida Personalizada ");
                Console.WriteLine("3 - Partidas con Mejor tiempo ");
                Console.WriteLine("0 - Salir ");
                Console.Write("Ingrese Opcion: ");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    default: Console.WriteLine("ERROR, ingrese una opcion valida"); break;
                    case 1: PartidaRapida(); break;
                    case 2: PartidaPersonalisada(); break;
                    case 3: PartidaMejorTiempo();  break;
                    case 0: break;
                }
            }

        }

        public void PartidaRapida()
        {
            Console.Clear();
            Console.Write("Ingrese Nombre: ");
            string nombre = Console.ReadLine();
            Jugador jugador = new Jugador(nombre);
            fachadaPartida.IniciarPartida(jugador);
            MostrarJuego();
        }

        public void PartidaPersonalisada()
        {
            Console.Clear();
            Console.Write("Ingrese Nombre: ");
            string nombre = Console.ReadLine();
            Jugador jugador = new Jugador(nombre);
            Console.Write("Cantidad de Vidas: ");
            try
            {
                int vida = int.Parse(Console.ReadLine());
                fachadaPartida.IniciarPartida(jugador, vida);
                MostrarJuego();
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
                Console.ReadKey();
            }

        }
        public void MostrarJuego()
        {
            while (!fachadaPartida.SinVidas() && !fachadaPartida.Victoria())
            {
                Console.Clear();
                Console.WriteLine(string.Join(" ", fachadaPartida.VectorVisual));
                Console.WriteLine($"Intentos Restantes: {fachadaPartida.DevolverVidaRestante()}"); 
                Console.Write("Ingrese Intento: ");
                try
                {
                    char letra = char.Parse(Console.ReadLine());
                    fachadaPartida.ComprobarLetra(letra);
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                    Console.ReadKey();
                }

            }

            if (fachadaPartida.Victoria())
            {
                Console.Clear();
                Console.WriteLine(string.Join(" ", fachadaPartida.VectorVisual));
                Console.WriteLine("Ganaste!"); 
                Console.WriteLine($"Tiempo: {fachadaPartida.DuracionPartida()}"); Console.ReadKey();
                fachadaPartida.GuardarPartidaLista();
            }
            if (fachadaPartida.SinVidas())
            {
                Console.Clear();
                Console.WriteLine(string.Join(" ", fachadaPartida.VectorVisual));
                Console.WriteLine("Pertdiste"); Console.ReadKey();
            }
        }

        public void PartidaMejorTiempo()
        {
            List<Partida> mejores5 = fachadaPartida.DevolverMejoresCincoPartidas();
            Console.Clear();
            Console.WriteLine("----------- Partidas con mejor tiempo -----------");
            if (mejores5.Count !=0)
            {
                for (int i = 0; i < mejores5.Count; i++)
                {
                    Console.WriteLine($"Nombre {mejores5[i].Jugador.Nombre}, Duracion: {mejores5[i].DevolverDuracion()}");
                }
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Lista de partidas vacia");
                Console.ReadKey();

            }

        }
    }
}
