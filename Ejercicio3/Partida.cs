using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    public class Partida
    {
        private int iError, iVida;
        private DateTime iFechaInicio;
        private DateTime? iHoraFin;
        private Palabra iPalabra;
        private Jugador ijugador;

        public Partida(Palabra pPalabra, Jugador pJugador)
        {

            new Partida(pPalabra, pJugador, 10); 

        }

        public Partida(Palabra pPalabra, Jugador pJugador, int pVida)
        {
            this.iFechaInicio = DateTime.Now;
            this.ijugador = pJugador;
            this.iPalabra = pPalabra;
            this.iVida = pVida;
            this.iError = 0;
            this.iHoraFin = DateTime.Now;
        }

        public bool Resultado()
        {
            if (iError == iVida)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

   

        public int Errores
        {
            get { return this.iError; }
            set { this.iError = value; }
        }

        public DateTime HoraFin
        {
            get { return (DateTime)this.iHoraFin; }
            set { this.iHoraFin = value; }
        }

        public double Duracion()
        {
            return ((DateTime)this.iHoraFin - this.iFechaInicio).TotalSeconds;
        }

    }
}
