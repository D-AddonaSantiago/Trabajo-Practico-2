using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    public class Circulo
    {
        private Punto Centro;
        private double Radio;

        public Circulo(Punto pCentro, double pRadio)
        {
            this.Centro = pCentro;
            this.Radio = pRadio;
        }

        public Circulo(double pX, double pY, double pRadio)
        {
            this.Centro = new Punto(pX, pY);
            this.Radio = pRadio;
        }

        public Punto GetCentro ()
        {
            return (this.Centro);
        }

        public double GetRadio()
        {
            return (this.Radio);
        }

        public double GetArea()
        {
            return (Math.PI * (Math.Pow(this.Radio, 2)));
        }

        public double GetPer()
        {
            return (2 * Math.PI * this.Radio);
        }
    }
}
