using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    public class Moneda
    {
        private string iCodigoISO;
        private string iNombre;
        private string iSimbolo;

        public Moneda (string pCodigoISO, string pNombre, string pSimbolo)
        {
            this.iCodigoISO = pCodigoISO;
            this.iNombre = pNombre;
            this.iSimbolo = pSimbolo;
        }

        public string CodigoISOCuenta 
        {
            get {return this.iCodigoISO; }
            private set {this.iCodigoISO = value; } 
        }

        public string NombreCuenta
        {
            get { return this.iNombre; }
            private set { this.iNombre = value; } 
        }

        public string SimboloCuenta 
        {
            get {return this.iSimbolo; }
            private set {this.iSimbolo = value; } 
        }
    }
}
