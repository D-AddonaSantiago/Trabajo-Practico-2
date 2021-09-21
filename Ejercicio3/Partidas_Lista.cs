using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Partidas_Lista
    {
        private List<Partida> iListaGanadas = new List<Partida>();

        public void AgregarALista(Partida x)
        {
            int i = 0;
            if (this.iListaGanadas.Count == 0)
                this.iListaGanadas.Add(x);
            else
            {
                while (this.iListaGanadas.Count > i && this.iListaGanadas[i].Duracion() < x.Duracion()) 
                {
                    i++;
                }
                this.iListaGanadas.Insert(i,x);
            }
        }


        public List<Partida> ListaPartidas
        {
            get { return this.iListaGanadas; }
        }
}
}
