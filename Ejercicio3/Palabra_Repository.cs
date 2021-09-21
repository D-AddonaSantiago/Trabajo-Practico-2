using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Palabra_Repository
    {
        static Palabra nPalabra = new Palabra();

        static public string Obtener(int pPos)
        {
            return nPalabra.GetBaseDeDatos[pPos];
        }

        static public int CantPalabras()
        {
            return nPalabra.GetBaseDeDatos.Length;
        }
    }
}
