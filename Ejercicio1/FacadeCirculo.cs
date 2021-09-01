using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class FacadeCirculo
    {
        public static double AreaCirculo(double px, double py, double radio)
        {
            Circulo circ = new Circulo(px,py,radio);

            return Math.Round(circ.GetArea(),2);
        }

        public static double PerimCirculo(double px, double py, double radio)
        {
            Circulo circ = new Circulo(px, py, radio);

            return Math.Round(circ.GetPer(),2);
        }
    }
}
