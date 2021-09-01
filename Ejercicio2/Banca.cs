using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    public class Banca

    {
        private string iNumero;
        private string iTitular;
        private Cuenta CuentaEnPesos;
        private Cuenta CuentaEnDolares;

        public Banca (string pNumero, string pTitular)
        {
            this.iNumero = pNumero;
            this.iTitular = pTitular;
            this.CuentaEnPesos = new Cuenta(new Moneda("ARS", "Pesos", "$"));
            this.CuentaEnDolares = new Cuenta(new Moneda("USD", "Dolares", "U$S"));
        }

        public Cuenta CuentaPesos()
        {
            return this.CuentaEnPesos;
        }

        public Cuenta CuentaDolares()
        {
            return this.CuentaEnDolares;
        }

        public string NumeroBanca
        {
            get { return this.iNumero;  }
            set { this.iNumero = value; }
        }

        public string TitularBanca
        {
            get { return this.iTitular; }
            set { this.iTitular = value; }
        }
    }
}
