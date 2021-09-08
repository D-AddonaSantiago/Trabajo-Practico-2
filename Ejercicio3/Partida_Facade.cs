using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    public class Partida_Facade
    {
        public void InciarPartida(Jugador pjugador)
        {
            

             

        } 

        public char[] DevuelvePalabraAleatoria()
        {
            Random numero = new Random();
            int numeroAleatorio = numero.Next(0, Palabra_Repository.CantPalabras());
            return Palabra_Repository.Obtener(numeroAleatorio).ToCharArray();
        }
    }
}
