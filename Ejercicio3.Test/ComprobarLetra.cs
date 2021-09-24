using System;
using Xunit;
using Ejercicio3;

namespace Ejercicio3.Test
{
    public class ComprobarLetra
    {
        [Fact]
        public void CompruebaLetra_OK()
        {
            FachadaPartida sarasa = new FachadaPartida();
            Jugador elJugador = new Jugador("asd");

            sarasa.IniciarPartida(elJugador, 10);
            bool a = sarasa.ComprobarLetra('a');
            bool e = sarasa.ComprobarLetra('e');
            bool i = sarasa.ComprobarLetra('i');
            bool o = sarasa.ComprobarLetra('o');
            bool u = sarasa.ComprobarLetra('u');

            
            Assert.True(a || e || i || o || u);
        }
    }
}
