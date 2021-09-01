using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class FacadePunto
    {
        public static double ManejoPuntos(double px1, double py1, double px2, double py2)
        {
            Punto p1 = new Punto(px1, py1);

            Punto p2 = new Punto(px2, py2);                                       

            return Math.Round(p1.DistanciaHasta(p2), 2);
        }
    }
}
