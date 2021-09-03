using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    static public class Banca_Repository
    {
        static private Banca[] conjBanca;
        static private double iDolarActual = 97.71;

        static public Banca Obtener(string pNumero)
        {
            int i = 0;
            if (conjBanca == null)
            {
                return null;
            }
            else
            {
                while (conjBanca.Length <= i && pNumero != conjBanca[i].NumeroBanca)
                {
                    i++;
                }
                if (pNumero == conjBanca[i].NumeroBanca)
                {
                    return conjBanca[i];
                }
                else
                {
                    return null;
                }
            }
            
        }

        static public void Agregar(Banca pBanca)
        {
            if (conjBanca == null)
            {
                conjBanca = new Banca[100];
                conjBanca[0] = pBanca;
            }
            else
            {
                conjBanca.Append(pBanca);
            }
        }

        static public double DolarActual
        {
            get{ return iDolarActual; }
            set{ iDolarActual = value; }
        }
    }
}
