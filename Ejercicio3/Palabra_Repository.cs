using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Palabra_Repository
    {
        private Palabra[] conjPalabras;

        public string[] palabra = new string[] { "Adaptacion", "Agudo", "Antibiotico", "Artritis", "Ataxia", "Atrofia","Circulacion","Cirugía","Conducta","Contractura",
                                                            "Cronico", "Cuadriplejia", "Choquezuela", "Diagnostico", "Diplejia", "Distrofia","Dosis","Espasticidad","Espina","Estimulacion",
                                                            "Evaluacion", "Fisico", "Fisioterapeuta", "Hemiplejia", "Herencia", "Inflamacion","Paraplejia","Protesis","Toxico","Virus"};

        public Palabra[] Inicio(string[] pCadenas)
        {
            int i = 0;
            conjPalabras = new Palabra[30];
            foreach (string palabra in pCadenas)
            {
                conjPalabras[i] = new Palabra(i, palabra);
                i++;
            }
            return conjPalabras;
        }

        public Palabra Obtener(int pID)
        {
            return conjPalabras[pID];
        }
    }
}
