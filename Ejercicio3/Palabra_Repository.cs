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

        public string[] pabra = new string[] { "Adaptación", "Agudo", "Antibiótico", "Artritis", "Ataxia", "Atrofia","Circulación","Cirugía","Conducta","Contractura",
                                                            "Crónico", "Cuadriplejia", "Choquezuela", "Diagnóstico", "Diplejía", "Distrofia","Dosis","Espasticidad","Espina","Estimulación",
                                                            "Evaluación", "Físico", "Fisioterapeuta", "Hemiplejia", "Herencia", "Inflamación","Paraplejía","Prótesis","Tóxico","Virus"};

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
