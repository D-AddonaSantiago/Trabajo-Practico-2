using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    public class Partida
    {
        private int iID, iError, iVida;
        private DateTime iFechaInicio;
        private DateTime? iHoraFin;
        private Palabra iPalabra;
        private Jugador ijugador;

        public Partida(Palabra pPalabra, Jugador pJugador)
        {
            this.iFechaInicio = DateTime.Now;
            this.ijugador = pJugador;
            this.iPalabra = pPalabra;
            this.iVida = 10;
            this.iError = 0;
            this.iHoraFin = DateTime.Now;
        }

        public Partida(int pID, Palabra pPalabra, Jugador pJugador, int pVida)
        {
            this.iID = pID;
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

        public int ID
        {
            get { return this.iID; }
            set { this.iID = value; }
        }

        public int Errores
        {
            get { return this.iError; }
            set { this.iError = value; }
        }

        public DateTime HoraFin
        {
            get { return this.iHoraFin; }
            set { this.iHoraFin = value; }
        }

        public double Duracion()
        {
            return (this.iHoraFin - this.iFechaInicio).TotalSeconds;
        }

    }
}
