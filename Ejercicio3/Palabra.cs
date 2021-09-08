﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    public class Palabra
    {
        private string[] baseDeDatosDePalabras;
         
        public Palabra()
        {
            this.baseDeDatosDePalabras = new string[] { "Adaptacion", "Agudo", "Antibiotico", "Artritis", "Ataxia", "Atrofia","Circulacion","Cirugía","Conducta","Contractura",
                                                            "Cronico", "Cuadriplejia", "Choquezuela", "Diagnostico", "Diplejia", "Distrofia","Dosis","Espasticidad","Espina","Estimulacion",
                                                            "Evaluacion", "Fisico", "Fisioterapeuta", "Hemiplejia", "Herencia", "Inflamacion","Paraplejia","Protesis","Toxico","Virus"};
        } 
        
        public string[] BaseDeDatos
        {
            get { return this.baseDeDatosDePalabras; }
        }

    }
}
