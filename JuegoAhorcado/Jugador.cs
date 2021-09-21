using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoAhorcado
{
    public class Jugador
    {
        private string iNombre;

        public Jugador(string pNombre)
        {
            this.iNombre = pNombre;
        }
        public string Nombre
        {
            get { return this.iNombre; }
        }


    }
}
