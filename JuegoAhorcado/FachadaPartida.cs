using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoAhorcado
{
    public class FachadaPartida
    {
        Repositorio repositorio = new Repositorio();
        Partida partida;
        char[] vectorLetras,vectorVisual;
        Lista listaPartidas = new Lista();


        public char[] VectorVisual
        {
            get { return this.vectorVisual; }
        }
        public void IniciarPartida(Jugador pJugador, int pvida)
        {
            partida = new Partida(pJugador, BuscarPalabra(), pvida);
            vectorLetras = partida.Palabra.ToCharArray();
            CrearVectorVisual(vectorLetras.Length);
        }

        public void IniciarPartida(Jugador pJugador)
        {
            IniciarPartida(pJugador, 10);
        }


        public bool ComprobarLetra(char pLetra)
        {
            bool local = false;

            for (int i = 0; i < vectorLetras.Length; i++)
            {
                if (vectorLetras[i] == pLetra)
                {
                    vectorLetras[i] = '+';
                    vectorVisual[i] = pLetra;
                    local = true;
                }
            }

            if (local)
            {
                return true; 
            }
            else
            {
                partida.Error++;
                return false;
            }
        }

        public int DevolverVidaRestante() => partida.Vida - partida.Error;

        public char[] CrearVectorVisual(int ptamaño)
        {
            vectorVisual = new char[ptamaño];
            for (int i = 0; i < ptamaño; i++)
            {
                vectorVisual[i] = '_';
            }
            return vectorVisual;
        } 

        public string BuscarPalabra()
        {
            Random numero = new Random();
            int numeroAleatorio = numero.Next(0, repositorio.DevuelveTamaño());
            return repositorio.DevuelvePalabra(numeroAleatorio);
        }

        public bool SinVidas() => partida.Error == partida.Vida;


        public bool Victoria()
        {
            bool local = true ;

            foreach (char i in vectorLetras)
            {
                if ( i != '+')
                {
                    local= false; 
                }
            }
            return local;
        }


        public string DuracionPartida()
        {
            partida.Horafin = DateTime.Now; // Aca sobre escribo el valor seteado al principio
            return partida.DevolverDuracion();
        } 

        public void SumarError()
        {
            partida.Error++;
        }

        public void GuardarPartidaLista()
        {
            listaPartidas.AgregarALista(partida);
        }

        public List<Partida> DevolverMejoresCincoPartidas()
        {
            List<Partida> temp = new List<Partida>();
            if (listaPartidas.Ganadores.Count >= 5)
            {
                temp = listaPartidas.Ganadores.GetRange(0, 5);
            }
            else
            {
                temp = listaPartidas.Ganadores.GetRange(0, listaPartidas.Ganadores.Count);
            }
            return temp;
        }


    }
}
