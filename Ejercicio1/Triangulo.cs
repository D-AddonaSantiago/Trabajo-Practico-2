using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    public class Triangulo
    {
        private Punto p1, p2, p3;           //Componentes de un triangulo

        public Triangulo(Punto pt1, Punto pt2, Punto pt3)           //Contructor de un Triangulo
        {
            this.p1 = pt1;
            this.p2 = pt2;
            this.p3 = pt3;
        }

        public Punto GetP1()            //Obtencion del primer punto
        {
            return (this.p1);
        }

        public Punto GetP2()            //Obtencion del segundo punto
        {
            return (this.p2);
        }

        public Punto GetP3()            //Obtencion del tercer punto
        {
            return (this.p3);
        }

        public double GetArea()         //Utilizando la formula de Heron a partir de sus lados podemos calcular su Area
        {
            double L1 = this.p1.DistanciaHasta(this.p2);
            double L2 = this.p2.DistanciaHasta(this.p3);
            double L3 = this.p3.DistanciaHasta(this.p1);
            double semiPer = ((L1 + L2 + L3) / 2);
            return (Math.Sqrt(semiPer * (semiPer - L1) * (semiPer - L2) * (semiPer - L3)));
        }

        public double GetPerimetro()
        {
            return (this.p1.DistanciaHasta(this.p2) + (this.p2.DistanciaHasta(this.p3)) + (this.p3.DistanciaHasta(this.p1)));
        }
    }
}
