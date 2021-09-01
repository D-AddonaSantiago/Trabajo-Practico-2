using System;
using Ejercicio1;
using Xunit;

namespace Ejercicio1Test
{
    public class UnitTest1
    {
        [Fact]
        public void Area_HayppyPath_OK()
        {
            // PUEDO ACCEDER SOLO SI ES PUBLICA !!
            //Agregue, preparar el codigo para ser probado
            //Agrego la dependenciaa de EJ1
            Circulo circulo1 = new Circulo(0, 0, 10);

            //Act
            //Ejecutamos las acciones que queremos probar
            var resultadorArea = circulo1.GetArea();

            //Assert Vereficacion

            Assert.Equal(123, resultadorArea, 2); //Verifica la igualdad entre dos valores, quiero comporbar un resultado con el valor 123
            // el numero 2 me indica el grado de igualdad, 2 punto flotantes..

            //Puedo hacer otras pruebas borde.. es decir varios test
        }

        [Fact]
        public void Area_HappyPath2_OK()
        {
            Circulo circulo1 = new Ejercicio1.Circulo(0, 0, 1);

            var resultadorArea = circulo1.GetArea();

            //Assert

            Assert.Equal(3.14, resultadorArea, 2);
        }
    }
}
