using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    public class Punto
    {
        private double iX, iY;          //Componentes de un Punto

        public Punto(double px, double py)          //Contructor del Punto
        {
            this.iX = px;
            this.iY = py;
        }

        public double GetX()            //Obtencion del componente X del Punto
        {
            return (this.iX);
        }

        public double GetY()            //Obtencion del componente Y de un Punto
        {
            return (this.iY);
        }

        public double DistanciaHasta(Punto p)          //Obtencion de la distancia entre 2 puntos
        {
            double difx = this.iX - p.iX;
            double dify = this.iY - p.iY;
            return Math.Sqrt(Math.Pow(difx, 2) + Math.Pow(dify, 2));
        }
    }
}
