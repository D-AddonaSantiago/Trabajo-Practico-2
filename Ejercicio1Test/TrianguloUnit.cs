using System;
using Ejercicio1;
using Xunit;

namespace Ejercicio1_Test
{
    public class TrianguloUnit
    {
        [Fact]
        public void Area_HayppyPath_OK()
        {
            //Arrange
            Punto p1, p2, p3;
            p1 = new Punto(2, 2);
            p2 = new Punto(5, 4);
            p3 = new Punto(1, 3);

            Triangulo triangulo = new Triangulo(p1, p2, p3);

            //Act
            var resultadoArea = triangulo.GetArea();

            //Assert
            Assert.Equal(2.50, resultadoArea, 2);
        }

        [Fact]
        public void Area_HayppyPath2_OK()
        {
            //Arrange
            Punto p1, p2, p3;
            p1 = new Punto(6, 2);
            p2 = new Punto(5, 10);
            p3 = new Punto(20, 14);

            Triangulo triangulo = new Triangulo(p1, p2, p3);

            //Act
            var resultadoArea = triangulo.GetArea();

            //Assert
            Assert.Equal(62.00, resultadoArea, 2);
        }

        [Fact]
        public void Area_HayppyPath3_OK()
        {
            //Arrange
            Punto p1, p2, p3;
            p1 = new Punto(16, 9);
            p2 = new Punto(7, 3);
            p3 = new Punto(6, 4);

            Triangulo triangulo = new Triangulo(p1, p2, p3);

            //Act
            var resultadoArea = triangulo.GetArea();

            //Assert
            Assert.Equal(7.50, resultadoArea, 2);
        }

        [Fact]
        public void Per_HayppyPath_OK()
        {
            //Arrange
            Punto p1, p2, p3;
            p1 = new Punto(16, 9);
            p2 = new Punto(7, 3);
            p3 = new Punto(6, 4);

            Triangulo triangulo = new Triangulo(p1, p2, p3);

            //Act
            var resultadoArea = triangulo.GetPerimetro();

            //Assert
            Assert.Equal(23.41, resultadoArea, 2);
        }

        [Fact]
        public void Per_HayppyPath2_OK()
        {
            //Arrange
            Punto p1, p2, p3;
            p1 = new Punto(5, 9);
            p2 = new Punto(7, 14);
            p3 = new Punto(2, 4);

            Triangulo triangulo = new Triangulo(p1, p2, p3);

            //Act
            var resultadoArea = triangulo.GetPerimetro();

            //Assert
            Assert.Equal(22.40, resultadoArea, 2);
        }

        [Fact]
        public void Per_HayppyPath3_OK()
        {
            //Arrange
            Punto p1, p2, p3;
            p1 = new Punto(0, 0);
            p2 = new Punto(2, 2);
            p3 = new Punto(3, 4);

            Triangulo triangulo = new Triangulo(p1, p2, p3);

            //Act
            var resultadoArea = triangulo.GetPerimetro();

            //Assert
            Assert.Equal(10.06, resultadoArea, 2);
        }
    }
}
