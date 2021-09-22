using System;
using Xunit;

namespace EJ4.Test
{
    public class Division
    {
        [Fact]
        public void Division_OK()
        {
            // Arrange
            Complejo complejo = new Complejo(2, 2);
            Complejo complejo2 = new Complejo(4, 20);

            // Act 
            Complejo resultado = complejo.DividirPor(complejo2);

            // Assert
            Assert.Equal(0.115, resultado.Real, 3);
            Assert.Equal(-0.077, resultado.Imaginario, 3);
        }

        [Fact]
        public void Division_OK2()
        {
            // Arrange
            Complejo complejo = new Complejo(2, 25);
            Complejo complejo2 = new Complejo(4, 20);

            // Act 
            Complejo resultado = complejo.DividirPor(complejo2);

            // Assert
            Assert.Equal(1.221, resultado.Real, 3);
            Assert.Equal(0.144, resultado.Imaginario, 3);
        }
    }
}
