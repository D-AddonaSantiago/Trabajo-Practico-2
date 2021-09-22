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
            Partida_Facade sarasa = new Partida_Facade();
            sarasa.IniciarPartida();
            bool a = sarasa.ComprobarLetra('a');
            bool e = sarasa.ComprobarLetra('e');
            bool i = sarasa.ComprobarLetra('i');
            bool o = sarasa.ComprobarLetra('o');
            bool u = sarasa.ComprobarLetra('u');

            
            Assert.True(a || e || i || o || u);
        }
    }
}
