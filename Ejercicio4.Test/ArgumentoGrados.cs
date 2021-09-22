using System;
using Xunit;

namespace EJ4.Test
{
    public class ArgumentoGrados
    {
        [Fact]
        public void Grados_OK()
        {
            // Arrange
            Complejo complejo = new Complejo(2, 2);

            // Act 
            var grados = complejo.ArgumentoEnGrados;

            // Assert
            Assert.Equal(45, grados, 2);
        }

        [Fact]
        public void Grados_OK2()
        {
            // Arrange
            Complejo complejo = new Complejo(2, 20);

            // Act 
            var grados = complejo.ArgumentoEnGrados;

            // Assert
            Assert.Equal(84.29, grados, 2);
        }
    }
}
