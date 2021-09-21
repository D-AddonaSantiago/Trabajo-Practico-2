using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    public class Palabra
    {
        private string[] iDBPalabras;       //Base de datos de Palabras(Data Base Palabras)
         
        public Palabra()
        {
            this.iDBPalabras = new string[] { "adaptacion"/*, "agudo", "antibiotico", "artritis", "ataxia", "atrofia","circulacion","cirugia","conducta","contractura",
                                                            "cronico", "cuadriplejia", "choquezuela", "diagnostico", "diplejia", "distrofia","dosis","espasticidad","espina","estimulacion",
                                                            "evaluacion", "fisico", "fisioterapeuta", "hemiplejia", "herencia", "inflamacion","paraplejia","protesis","toxico","virus"*/};
        } 
        
        public string[] GetBaseDeDatos
        {
            get { return this.iDBPalabras; }
        }

    }
}
