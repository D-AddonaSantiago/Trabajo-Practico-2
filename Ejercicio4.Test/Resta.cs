using System;
using Xunit;

namespace EJ4.Test
{
    public class Resta
    {
        [Fact]
        public void Resta_OK()
        {
            // Arrange
            Complejo complejo = new Complejo(2, 2);
            Complejo complejo2 = new Complejo(4, 20);

            // Act 
            Complejo resta = complejo.Restar(complejo2);

            // Assert
            Assert.Equal(-2, resta.Real);
            Assert.Equal(-18, resta.Imaginario);
        }

        [Fact]
        public void Resta_OK2()
        {
            // Arrange
            Complejo complejo = new Complejo(2, 25);
            Complejo complejo2 = new Complejo(4, 20);

            // Act 
            Complejo resta = complejo.Restar(complejo2);

            // Assert
            Assert.Equal(-2, resta.Real);
            Assert.Equal(5, resta.Imaginario);
        }
    }
}