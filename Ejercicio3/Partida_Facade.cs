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

        char[] vectorLetras, vectorVisual;

        Partida partidaActual;

        public void InciarPartida(Jugador pJugador)
        {
            partidaActual = new Partida(DevuelvePalabraAleatoria(), pJugador, Vida);
            vectorLetras = partidaActual.Palabra.ToCharArray();
            CrearVectorVisual(vectorLetras.Length);
        } 

        public int Vida
        {
            get { return iVida; }
            set { this.iVida = value; }
        }

        public bool ComprobarLetra(char pLetra)
        {
            bool temp = false;
            for (int i = 0; i < vectorLetras.Length; i++)
            {
                if (vectorLetras[i] == pLetra)
                {
                    vectorLetras[i] = '_';
                    vectorVisual[i] = pLetra;
                    temp = true;
                }
            }
            if (temp)
            {
                return true;
            }
            else
            {
                partidaActual.Errores++;
                return false;
            }
        }

        public bool SinVidas()
        {
            return (iVida == partidaActual.Errores) ? true: false;
        }

        public bool Victoria()
        {
            bool temp = true;
            foreach (char i in vectorLetras)
            {
                if (i != '+')
                    temp = false;
            }
            return (temp) ? true : false;
        }

        public void CrearVectorVisual(int pTamaño)
        {
            vectorVisual = new char[pTamaño];
            for (int i = 0; i < pTamaño; i++)
            {
                vectorVisual[i] = '_';
            }
        }

        public string DevuelvePalabraAleatoria()
        {
            Random numero = new Random();
            int numeroAleatorio = numero.Next(0, Palabra_Repository.CantPalabras());
            return Palabra_Repository.Obtener(numeroAleatorio);
        }
    }
}
