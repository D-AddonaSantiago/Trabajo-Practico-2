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

        public void InciarPartida(Jugador pJugador)
        {
            Partida partidaActual = new Partida(DevuelvePalabraAleatoria(), pJugador, Vida);
        } 

        public int Vida
        {
            get { return iVida; }
            set { this.iVida = value; }
        }



        public string DevuelvePalabraAleatoria()
        {
            Random numero = new Random();
            int numeroAleatorio = numero.Next(0, Palabra_Repository.CantPalabras());
            return Palabra_Repository.Obtener(numeroAleatorio);
        }
    }
}
