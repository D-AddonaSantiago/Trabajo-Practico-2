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

        private Palabra DevuelvePalabraAleatoria()
        {
            Random numero = new Random();
            int numeroAleatorio = numero.Next(0, 29);

            Palabra_Repository pRepos = new Palabra_Repository();
            
            return pRepos.Obtener(numeroAleatorio);
          
        }
    }
}
