using System;
using Xunit;

namespace Ejercicio4.Test
{
    public class Mutiplicacion
    {
        [Fact]
        public void Mutiplicacion_OK()
        {
            // Arrange
            Complejo complejo = new Complejo(2, 2);
            Complejo complejo2 = new Complejo(4, 20);

            // Act 
            Complejo resultado = complejo.MultiplicarPor(complejo2);

            // Assert
            Assert.Equal(-32, resultado.Real);
            Assert.Equal(48, resultado.Imaginario);
        }

        [Fact]
        public void Mutiplicacion_OK2()
        {
            // Arrange
            Complejo complejo = new Complejo(2, 25);
            Complejo complejo2 = new Complejo(4, 20);

            // Act 
            Complejo resultado = complejo.MultiplicarPor(complejo2);

            // Assert
            Assert.Equal(-492, resultado.Real);
            Assert.Equal(140, resultado.Imaginario);
        }
    }
}