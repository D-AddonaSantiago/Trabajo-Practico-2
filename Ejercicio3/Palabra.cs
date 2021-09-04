using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    public class Palabra
    {
        private int iID;
        private string iCadena;
        private char[] iArregloLetras;

        public Palabra(int pID, string pCadena)
        {
            this.iID = pID;
            this.iCadena = pCadena;
            this.iArregloLetras = Letras(pCadena);
        }

        public int ID
        {
            get { return this.iID; }
            set { this.iID = value; }
        }

        public string Cadena
        {
            get { return this.iCadena; }
            set { this.iCadena = value; }
        }

        public char[] ArregloLetras
        {
            get { return this.iArregloLetras; }
            set { this.iArregloLetras = value; }
        }

        public char[] Letras(string pCadena)
        {
            return pCadena.ToCharArray();
        }
    }
}
