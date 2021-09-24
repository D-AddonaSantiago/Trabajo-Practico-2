using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    public class Partida
    {
        private Jugador iJugador;
        private string iPalabra;
        private DateTime iHoraInicio;
        private DateTime iHoraFin;
        private int iVida,iError;
        private bool iGano;
        private TimeSpan duracion; //Consultar, lo hago publico

        public Partida(Jugador pJugador, string pPalabra, int pVida)
        {
            this.iJugador = pJugador;
            this.iPalabra = pPalabra;
            this.iHoraInicio = DateTime.Now;
            this.iHoraFin = DateTime.Now;// no la uso, le doy un valor inicial, luego la sobre escribo 
            this.iVida = pVida;
            this.iGano = false;
            this.iError = 0;

        }

        public bool Gano
        {
            get { return this.iGano; }
            set { this.iGano = value; }
        }

        public int Error
        {
            get { return this.iError; }
            set { this.iError = value; }
        }
        public int Vida
        {
            get { return this.iVida; }
            set { this.iVida = value; }
        }
        public string Palabra
        {
            get { return this.iPalabra; }
        }

        public Jugador Jugador
        {
            get { return this.iJugador; }
        }

        public DateTime Horafin
        {
            get { return this.iHoraFin; }
            set { this.iHoraFin = value; }
        }
        public string DevolverDuracion()
        {
            //duracion = Convert.ToDateTime(this.iHoraFin - this.iHoraInicio).ToString(@"mm\m\ ss\s\ "); //Para guardar ordenado tengo que ver la forma de poder comparlos
            //Para guardar ordenado tengo que ver la forma de poder comparlos
            duracion = this.iHoraFin - this.iHoraInicio;
            return duracion.ToString(@"mm\m\ ss\s\ "); //Ver
           
        }

        public TimeSpan Duracion()
        {
            return duracion = this.iHoraFin - this.iHoraInicio;
        }


    }
}
