using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    public static class BaseDeDatos
    {
         static string[] vectorPalabras = new string[] { "adaptacion", "agudo", "antibiotico", "artritis", "ataxia", "atrofia","circulacion","cirugia","conducta","contractura",
                                                            "cronico", "cuadriplejia", "choquezuela", "diagnostico", "diplejia", "distrofia","dosis","espasticidad","espina","estimulacion",
                                                            "evaluacion", "fisico", "fisioterapeuta", "hemiplejia", "herencia", "inflamacion","paraplejia","protesis","toxico","virus"};

        public static string[] GetBaseDedatos
        {
            get { return vectorPalabras; }
        }

    }
}
