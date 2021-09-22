using System;
using Xunit;

namespace EJ4.Test
{
    public class Suma
    {
        [Fact]
        public void Suma_OK()
        {
            // Arrange
            Complejo complejo = new Complejo(2, 2);
            Complejo complejo2 = new Complejo(4, 20);

            // Act 
            Complejo suma = complejo.Sumar(complejo2);

            // Assert
            Assert.Equal(6, suma.Real);
            Assert.Equal(22, suma.Imaginario);
        }

        [Fact]
        public void Suma_OK2()
        {
            // Arrange
            Complejo complejo = new Complejo(2, 20);
            Complejo complejo2 = new Complejo(4, 20);

            // Act 
            Complejo suma = complejo.Sumar(complejo2);

            // Assert
            Assert.Equal(6, suma.Real);
            Assert.Equal(40, suma.Imaginario);
        }
    }
}