using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoAhorcado
{
    class Repositorio
    {
       

        public string DevuelvePalabra(int pPos)
        {
            return BaseDeDatos.GetBaseDedatos[pPos];
        }

        public int DevuelveTamaño()
        {
            return BaseDeDatos.GetBaseDedatos.Length;
        }

    }
}
