using System;
using Ejercicio1;
using Xunit;

namespace Ejercicio1_Test
{
    public class PuntoUnit
    {
        [Fact]
        public void Dist_HayppyPath_OK()
        {
            //Arrange
            Punto p1 = new Punto(1, 2);
            Punto p2 = new Punto(3, 5);

            //Act
            var resultadoDist = p1.DistanciaHasta(p2);

            //Assert
            Assert.Equal(3.61, resultadoDist, 2);
        }

        [Fact]
        public void Dist_HayppyPath2_OK()
        {
            //Arrange
            Punto p1 = new Punto(5, 4);
            Punto p2 = new Punto(1, 1);

            //Act
            var resultadoDist = p1.DistanciaHasta(p2);

            //Assert
            Assert.Equal(5, resultadoDist, 2);
        }

        [Fact]
        public void Dist_HayppyPath3_OK()
        {
            //Arrange
            Punto p1 = new Punto(4, 2);
            Punto p2 = new Punto(12, 51);

            //Act
            var resultadoDist = p1.DistanciaHasta(p2);

            //Assert
            Assert.Equal(49.65, resultadoDist, 2);
        }
    }
}
