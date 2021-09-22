using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    public class Complejo
    {
        private double iReal;
        private double iImaginario;
        public Complejo(double pReal, double pImaginario)
        {
            this.iReal = pReal;
            this.iImaginario = pImaginario;
        }

        public double Real
        {
            get { return this.iReal; }
        }


        public double Imaginario
        {
            get { return this.iImaginario; }
        }

        public double ArgumentoEnRadianes
        {
            get { return ArgumentoEnGrados * (Math.PI) / 180; }
        }

        public double ArgumentoEnGrados
        {
            get { return Math.Atan2(this.iImaginario, this.iReal) * 180 / (Math.PI); }
        }

        public Complejo Conjugado
        {
            get { return new Complejo(this.Real, -this.Imaginario); ; }
        }

        public double Magnitud
        {
            get { return Math.Sqrt(this.iReal * this.iReal + this.iImaginario * this.iImaginario); }
        }

        public bool EsReal() => (this.iImaginario == 0) ? true : false;

        public bool EsImaginario() => (this.iImaginario != 0) ? true : false;

        public bool EsIgual(Complejo pOtroComplejo)
        {
            Complejo complejo = new Complejo(this.iReal, this.iImaginario);
            return complejo.Equals(pOtroComplejo);
        }

        public bool EsIgual(double pReal, double pImaginario)
        {
            Complejo complejo = new Complejo(this.iReal, this.iImaginario);
            System.Numerics.Complex complejo1 = new System.Numerics.Complex(pReal, pImaginario);
            return complejo.Equals(complejo1);
        }

        public Complejo Sumar(Complejo pOtroComplejo)
        {
            double x = this.iReal + pOtroComplejo.Real;
            double y = this.iImaginario + pOtroComplejo.Imaginario;
            return new Complejo(x, y);
        }

        public Complejo Restar(Complejo pOtroComplejo)
        {
            double x = this.iReal - pOtroComplejo.Real;
            double y = this.iImaginario - pOtroComplejo.Imaginario;
            return new Complejo(x, y);
        }

        public Complejo MultiplicarPor(Complejo pOtroComplejo)
        {
            //The multiplication of a complex number, a +bi, and a second complex number, c + di, takes the following form:
            //(ac - bd) + (ad + bc)i
            double real = (this.iReal * pOtroComplejo.Real) - (this.iImaginario * pOtroComplejo.Imaginario);
            double imaginario = (this.iReal * pOtroComplejo.Imaginario + this.iImaginario * pOtroComplejo.Real);
            return new Complejo(real, imaginario);
        }
        public Complejo DividirPor(Complejo pOtroComplejo)
        {
            //The division of a complex number, a +bi, by a second complex number, number, c + di, takes the following form:
            // ((ac + bd) / (c2 + d2)) + ((bc - ad) / (c2 + d2)i

            // El control de la division por 0 se hace antes de llamar al metodo??
            double real = (this.iReal * pOtroComplejo.Real + this.iImaginario * pOtroComplejo.Imaginario) / ((Math.Pow(pOtroComplejo.Real, 2)) + Math.Pow(pOtroComplejo.Imaginario, 2));
            double imaginario = (this.iImaginario * pOtroComplejo.Real - this.iReal * pOtroComplejo.Imaginario) / ((Math.Pow(pOtroComplejo.Real, 2)) + Math.Pow(pOtroComplejo.Imaginario, 2));
            return new Complejo(real, imaginario);


        }


    }
}
