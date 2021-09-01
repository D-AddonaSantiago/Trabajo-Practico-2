using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class CrearCuenta_Facade
    {        
        public static bool CrearNuevaCuenta(string nomTit, string numDNI)
        {
            Banca banca = new Banca(numDNI, nomTit);
            if (Banca_Repository.ExisteBanca(numDNI))
                return false;
            else
            {
                Banca_Repository.Agregar(banca);
                return true;
            }
        }


    }
}
