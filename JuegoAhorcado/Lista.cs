using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoAhorcado
{
    public class Lista
    {
         List<Partida> ganadores = new List<Partida>();

        public  void AgregarALista(Partida x)
        {
            int i = 0;
            if (ganadores.Count == 0)
                ganadores.Add(x);
            else
            {
                while (ganadores.Count > i && ganadores[i].Duracion()< x.Duracion()) 
                {
                    i++;
                }
                ganadores.Insert(i,x);
            }
        }

        public List<Partida> Ganadores
        {
            get { return this.ganadores; }
        }
    }
}
