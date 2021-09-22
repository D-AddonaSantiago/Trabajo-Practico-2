using System;
using Xunit;
using Ejercicio3;

namespace Ejercicio3.Test
{
    public class ObtenerPalabra
    {
        [Fact]
        public void ObtenerPalabra1_OK()
        {
            string laPalabra = Palabra_Repository.Obtener(0);

            Assert.Equal("adaptacion", laPalabra);
        }

        [Fact]
        public void ObtenerPalabra2_OK()
        {
            string laPalabra = Palabra_Repository.Obtener(5);

            Assert.Equal("atrofia", laPalabra);
        }

        [Fact]
        public void ObtenerPalabra3_OK()
        {
            string laPalabra = Palabra_Repository.Obtener(15);

            Assert.NotEqual("virus", laPalabra);
        }
    }
}
