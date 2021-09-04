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
        double iA, iB, iC;

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
            double semiPer = (GetPerimetro() / 2);
            return Math.Sqrt(semiPer * (semiPer - iA) * (semiPer - iB) * (semiPer - iC));
        }

        public double GetPerimetro()
        {
            iA = this.p1.DistanciaHasta(this.p2);
            iB = this.p2.DistanciaHasta(this.p3);
            iC = this.p3.DistanciaHasta(this.p1);
            return (iA + iB + iC);
        }
    }
}
