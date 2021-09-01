using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    public class Cuenta
    {
        private double iSaldo;
        private Moneda iMoneda;

        public double Saldo
        {
            get { return iSaldo; }
            private set {iSaldo = value; }
        }

        public Cuenta(Moneda pMoneda)
        {
            this.iMoneda = pMoneda;
            this.iSaldo = 0;
        }

        public Cuenta(double pSaldoInicial, Moneda pMoneda)
        {
            this.iSaldo = pSaldoInicial;
            this.iMoneda = pMoneda;
        }

        public void AcreditarSaldo(double pSaldo) 
        {
            this.iSaldo += pSaldo;
        }

        public bool DebitarSaldo(double pSaldo)
        {
            if (iSaldo >= pSaldo)
            {
                iSaldo -= pSaldo;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
