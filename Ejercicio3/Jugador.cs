using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    public class Jugador
    {
        private string iNombre;
        private int iGanadas, iPerdidas;

        public Jugador(string pNombre)
        {
            this.iNombre = pNombre;
            this.iGanadas = 0;
            this.iPerdidas = 0;
        }

        public string Nombre
        {
            get { return this.iNombre; }
         //   set { this.iNombre = value; }
        }
        public int Ganadas
        {
            get { return this.iGanadas; }
            set { this.iGanadas = value; }
        }

        public int Perdidas
        {
            get { return this.iPerdidas; }
            set { this.iPerdidas = value; }
        }
    }
}
