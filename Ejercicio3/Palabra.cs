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
            this.iDBPalabras = new string[] { "Adaptacion", "Agudo", "Antibiotico", "Artritis", "Ataxia", "Atrofia","Circulacion","Cirugía","Conducta","Contractura",
                                                            "Cronico", "Cuadriplejia", "Choquezuela", "Diagnostico", "Diplejia", "Distrofia","Dosis","Espasticidad","Espina","Estimulacion",
                                                            "Evaluacion", "Fisico", "Fisioterapeuta", "Hemiplejia", "Herencia", "Inflamacion","Paraplejia","Protesis","Toxico","Virus"};
        } 
        
        public string[] GetBaseDeDatos
        {
            get { return this.iDBPalabras; }
        }

    }
}
