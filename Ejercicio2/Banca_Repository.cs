using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    public class Banca_Repository
    {
        private static Banca[] conjBanca = { };
        private static double DolarActual = 97.71;

        public static Banca Obtener(string pNumero)
        {
            int i = 0;
            while (pNumero != conjBanca[i].NumeroBanca)
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

        public static void Agregar(Banca pBanca)
        {
            conjBanca[conjBanca.Length + 1] = pBanca;
        }

        public static DolarActual
        {
            get{return this.DolarActual}
            set{}
        }
    }
}
