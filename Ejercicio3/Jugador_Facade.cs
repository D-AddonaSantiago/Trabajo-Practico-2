using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    public class Jugador_Facade
    {
        public void CrearJugador(string pNombre)
        {
            Jugador jugador = new Jugador(pNombre); 

        }

    }
}
