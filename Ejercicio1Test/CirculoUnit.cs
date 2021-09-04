using System;
using Ejercicio1;
using Xunit;

namespace Ejercicio1_Test
{
    public class CirculoUnit
    {
        [Fact]
        public void Area_HayppyPath_OK()
        {
            //Arrange (preparar todo para hacer la ejecución del test)
            Circulo circulo = new Circulo(0, 0, 15);

            //Act (Ejecutar el test)
            var resultadoArea = circulo.GetArea();

            //Assert (Hacer verificación)
            Assert.Equal(706.86, resultadoArea, 2);
        }

        [Fact]
        public void Area_HayppyPath2_OK()
        {
            //Arrange
            Circulo circulo = new Circulo(0, 0, 1);

            //Act
            var resultadoArea = circulo.GetArea();

            //Assert
            Assert.Equal(3.14, resultadoArea, 2);
        }

        [Fact]
        public void Area_HayppyPath3_OK()
        {
            //Arrange
            Circulo circulo = new Circulo(0, 0, 30);

            //Act
            var resultadoArea = circulo.GetArea();

            //Assert
            Assert.Equal(2827.43, resultadoArea, 2);
        }

        [Fact]
        public void Per_HayppyPath_OK()
        {
            //Arrange
            Circulo circulo = new Circulo(0, 0, 15);

            //Act
            var resultadoArea = circulo.GetPer();

            //Assert
            Assert.Equal(94.25, resultadoArea, 2);
        }

        [Fact]
        public void Per_HayppyPath2_OK()
        {
            //Arrange
            Circulo circulo = new Circulo(0, 0, 1);

            //Act
            var resultadoArea = circulo.GetPer();

            //Assert
            Assert.Equal(6.28, resultadoArea, 2);
        }

        [Fact]
        public void Per_HayppyPath3_OK()
        {
            //Arrange
            Circulo circulo = new Circulo(0, 0, 30);

            //Act
            var resultadoArea = circulo.GetPer();

            //Assert
            Assert.Equal(188.50, resultadoArea, 2);
        }
    }
}
