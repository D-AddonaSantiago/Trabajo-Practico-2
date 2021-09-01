using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class FacadeTriangulo
    {
        public static double AreaTriangulo(double px1, double py1, double px2, double py2, double px3, double py3)
        {
            Punto p1 = new Punto(px1, py2);
            Punto p2 = new Punto(px2, py2);
            Punto p3 = new Punto(px3, py3);
            Triangulo tri = new Triangulo(p1, p2, p3);

            return Math.Round(tri.GetArea(), 2);
        }

        public static double PerimTriangulo(double px1, double py1, double px2, double py2, double px3, double py3)
        {
            Punto p1 = new Punto(px1, py2);
            Punto p2 = new Punto(px2, py2);
            Punto p3 = new Punto(px3, py3);
            Triangulo tri = new Triangulo(p1, p2, p3);

            return Math.Round(tri.GetPerimetro(), 2);
        }

    }
}
