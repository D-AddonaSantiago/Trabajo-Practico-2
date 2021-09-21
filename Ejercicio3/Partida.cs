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
        private DateTime iHoraInicio, iHoraFin;
        private string iPalabra;
        private Jugador ijugador;
        private bool iGano;

        public Partida(string pPalabra, Jugador pJugador, int pVida)
        {
            this.iHoraInicio = DateTime.Now;
            this.ijugador = pJugador;
            this.iPalabra = pPalabra;
            this.iVida = pVida;
            this.iError = 0;
            this.iGano = false;
        }

        public string Palabra
        {
            get { return this.iPalabra; }
        }


        public void TiempoFin()
        {
            this.iHoraFin = DateTime.Now;
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

        public string Jugador
        {
            get { return this.ijugador.Nombre; }
            private set {; }
        }

        public TimeSpan Duracion()
        {
            return this.iHoraFin - this.iHoraInicio;
        }

        public string DuracionString()
        {
            TimeSpan i = Duracion();
            return (i.Minutes + ":" + i.Seconds);
        }
    }
}
