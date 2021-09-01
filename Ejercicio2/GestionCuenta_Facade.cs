using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    public class GestionCuenta_Facade
    {
        public static double ConsultarPesos(Banca miBanca)
        {
            return miBanca.CuentaPesos().Saldo;
        }

        public static double ConsultarDolares(Banca miBanca)
        {
            return miBanca.CuentaDolares().Saldo;
        }

        public bool AcreditarPesos(Banca miBanca, double pPesos)
        {
            if (miBanca.CuentaPesos().Saldo >= pPesos)
            {
                miBanca.CuentaPesos().AcreditarSaldo(pPesos);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AcreditarDolares(Banca miBanca, double pDolares)
        {
            if (miBanca.CuentaPesos().Saldo >= pDolares)
            {
                miBanca.CuentaDolares().AcreditarSaldo(pDolares);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void DebitarPesos(Banca miBanca, double pPesos)
        {
            miBanca.CuentaPesos().DebitarSaldo(pPesos);
        }

        public void DebitarDolares(Banca miBanca, double pDolares)
        {
            miBanca.CuentaDolares().DebitarSaldo(pDolares);
        }

        public bool ComprarDolares(Banca miBanca, double pDolares)
        {
            miBanca.CuentaPesos().AcreditarSaldo(pDolares.)
            miBanca.CuentaDolares().DebitarSaldo(pDolares);
        }
    }
}
