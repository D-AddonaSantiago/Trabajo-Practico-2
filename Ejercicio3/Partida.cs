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
        private string iPalabra;
        private Jugador ijugador;
        private bool iGano;

        public Partida(string pPalabra, Jugador pJugador, int pVida)
        {
            this.iFechaInicio = DateTime.Now;
            this.ijugador = pJugador;
            this.iPalabra = pPalabra;
            this.iVida = pVida;
            this.iError = 0;
            this.iHoraFin = DateTime.Now;
            this.iGano = false;
        }

        public bool Gano
        {
            get { return this.iGano; }
            set { this.iGano = value; }
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
    }
}
