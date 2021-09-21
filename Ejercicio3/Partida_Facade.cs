using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    public class Partida_Facade
    {
        int iVida = 10;

        char[] ivectorLetras, ivectorVisual;

        Partida ipartidaActual;

        Jugador ijugadorActual;

        Partidas_Lista iListaPartidas = new Partidas_Lista();


        public void NuevoJugador(string pJugador)
        {
             ijugadorActual = new Jugador(pJugador);
        }


        public void IniciarPartida()
        {
            ipartidaActual = new Partida(DevuelvePalabraAleatoria(), ijugadorActual, Vida);
            ivectorLetras = ipartidaActual.Palabra.ToCharArray();
            CrearVectorVisual(ivectorLetras.Length);
        } 


        public char[] VectorVisual
        {
            get { return this.ivectorVisual; }
        }


        public void AumentaVida()
        {
            iVida++;
        }


        public int Vida
        {
            get { return iVida; }
            set { iVida = value; }
        }


        public bool ComprobarLetra(char pLetra)
        {
            bool temp = false;
            for (int i = 0; i < ivectorLetras.Length; i++)
            {
                if (ivectorLetras[i] == pLetra)
                {
                    ivectorLetras[i] = '+';
                    ivectorVisual[i] = pLetra;
                    temp = true;
                }
            }
            if (temp)
            {
                return true;
            }
            else
            {
                ipartidaActual.Errores++;
                return false;
            }
        }


        public bool SinVidas()
        {
            return (iVida == ipartidaActual.Errores) ? true: false;
        }


        public bool Victoria()
        {
            bool temp = true;
            foreach (char i in ivectorLetras)
            {
                if (i != '+')
                    temp = false;
            }
            if (temp)
            {
                iListaPartidas.AgregarALista(ipartidaActual);
            }
            return temp;
        }


        public void CrearVectorVisual(int pTamaño)
        {
            ivectorVisual = new char[pTamaño];
            for (int i = 0; i < pTamaño; i++)
            {
                ivectorVisual[i] = '_';
            }
        }


        public int VidasRestantes()
        {
            return iVida - ipartidaActual.Errores;
        }


        public string TerminarPartidaGanada()
        {
            ipartidaActual.Gano = true;
            ipartidaActual.TiempoFin();
            return Duracion();
        }


        public string TerminarPartidaPerdida()
        {
            ipartidaActual.Gano = false;
            ipartidaActual.TiempoFin();
            return Duracion();
        }


        public double DuracionSegundos()
        {
            return ipartidaActual.Duracion().TotalSeconds;
        }


        public string Duracion()
        {
            TimeSpan i = ipartidaActual.Duracion();
            return (i.Minutes + ":" + i.Seconds);
        }


        public string DevuelvePalabraAleatoria()
        {
            Random numero = new Random();
            int numeroAleatorio = numero.Next(0, Palabra_Repository.CantPalabras());
            return Palabra_Repository.Obtener(numeroAleatorio);
        }


        public List<Partida> DevolverMejoresCincoPartidas()
        {
            List<Partida> temp = new List<Partida>();
            if (iListaPartidas.ListaPartidas.Count >= 5)
            {
                temp = iListaPartidas.ListaPartidas.GetRange(0, 5);
            }
            else
            {
                temp = iListaPartidas.ListaPartidas.GetRange(0, iListaPartidas.ListaPartidas.Count);
            }
            return temp;
        }
    }
}
