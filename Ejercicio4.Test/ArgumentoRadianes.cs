using System;
using Xunit;

namespace EJ4.Test
{
    public class ArgumentoRadianes
    {
        [Fact]
        public void Radianes_OK()
        {
            // Arrange
            Complejo complejo = new Complejo(2, 2);

            // Act 
            var radianes = complejo.ArgumentoEnRadianes;

            // Assert
            Assert.Equal(0.785, radianes, 3);
        }

        [Fact]
        public void Radianes_OK2()
        {
            // Arrange
            Complejo complejo = new Complejo(2, 20);

            // Act 
            var radianes = complejo.ArgumentoEnRadianes;

            // Assert
            Assert.Equal(1.471, radianes, 2);
        }
    }
}
