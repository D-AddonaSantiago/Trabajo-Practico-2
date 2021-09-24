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
            Repositorio elRepo = new Repositorio();
            string laPalabra = elRepo.DevuelvePalabra(0);

            Assert.Equal("adaptacion", laPalabra);
        }

        [Fact]
        public void ObtenerPalabra2_OK()
        {
            Repositorio elRepo = new Repositorio();
            string laPalabra = elRepo.DevuelvePalabra(5);

            Assert.Equal("atrofia", laPalabra);
        }

        [Fact]
        public void ObtenerPalabra3_OK()
        {
            Repositorio elRepo = new Repositorio();
            string laPalabra = elRepo.DevuelvePalabra(15);

            Assert.NotEqual("virus", laPalabra);
        }
    }
}
