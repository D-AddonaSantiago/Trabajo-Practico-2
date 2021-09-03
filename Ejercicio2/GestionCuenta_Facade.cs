using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    static public class GestionCuenta_Facade
    {
        static public bool ExisteCuenta(string iDNI)
        {
            if (Banca_Repository.Obtener(iDNI) == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        static public double ConsultarPesos(string tDNI)
        {
            Banca miBanca = Banca_Repository.Obtener(tDNI);
            return miBanca.CuentaPesos().Saldo;
        }

        static public double ConsultarDolares(string tDNI)
        {
            Banca miBanca = Banca_Repository.Obtener(tDNI);
            return miBanca.CuentaDolares().Saldo;
        }

        static public  bool DebitarPesos(string tDNI, double pPesos)
        {
            Banca miBanca = Banca_Repository.Obtener(tDNI);
            if (miBanca.CuentaPesos().Saldo >= pPesos)
            {
                miBanca.CuentaPesos().DebitarSaldo(pPesos);
                return true;
            }
            else
            {
                return false;
            }
        }

        static public bool DebitarDolares(string tDNI, double pDolares)
        {
            Banca miBanca = Banca_Repository.Obtener(tDNI);
            if (miBanca.CuentaPesos().Saldo >= pDolares)
            {
                miBanca.CuentaDolares().DebitarSaldo(pDolares);
                return true;
            }
            else
            {
                return false;
            }
        }

        static public void AcreditarPesos(string tDNI, double pPesos)
        {
            Banca miBanca = Banca_Repository.Obtener(tDNI);
            miBanca.CuentaPesos().AcreditarSaldo(pPesos);
        }

        static public void AcreditarDolares(string tDNI, double pDolares)
        {
            Banca miBanca = Banca_Repository.Obtener(tDNI);
            miBanca.CuentaDolares().AcreditarSaldo(pDolares);
        }

        static public bool ComprarDolares(string tDNI, double pDolares)
        {
            Banca miBanca = Banca_Repository.Obtener(tDNI);
            if (pDolares * Banca_Repository.DolarActual <= miBanca.CuentaPesos().Saldo)
            {
                miBanca.CuentaPesos().DebitarSaldo(pDolares * Banca_Repository.DolarActual);
                miBanca.CuentaDolares().AcreditarSaldo(pDolares);
                return true;
            }
            else
            {
                return false;
            }
                
        }

        static public bool ComprarPesos(string tDNI, double pPesos)
        {
            Banca miBanca = Banca_Repository.Obtener(tDNI);
            if (pPesos / Banca_Repository.DolarActual <= miBanca.CuentaDolares().Saldo)
            {
                miBanca.CuentaDolares().DebitarSaldo(pPesos / Banca_Repository.DolarActual);
                miBanca.CuentaPesos().AcreditarSaldo(pPesos);
                return true;
            }
            else
            {
                return false;
            }

        }

        static public bool CrearNuevaCuenta(string nomTit, string numDNI)
        {
            Banca banca = new Banca(numDNI, nomTit);
            if (Banca_Repository.Obtener(numDNI) == null)
            {
                Banca_Repository.Agregar(banca);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
