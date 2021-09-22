using System;
using Ejercicio2;
using Xunit;

namespace Ejercicio2_Test
{
    public class Saldo
    {
        [Fact]
        public void ComprobarSaldoDolares_OK()
        {
            GestionCuenta_Facade.CrearNuevaCuenta("asd", "123");

            GestionCuenta_Facade.AcreditarDolares("123", 200.0);


            var resultado = GestionCuenta_Facade.ConsultarDolares("123");


            Assert.Equal(200, resultado);
        }


        [Fact]
        public void ComprobarSaldoPesos_OK()
        {
            GestionCuenta_Facade.CrearNuevaCuenta("asd", "123");

            GestionCuenta_Facade.AcreditarPesos("123", 200.0);


            var resultado = GestionCuenta_Facade.ConsultarPesos("123");


            Assert.Equal(200, resultado);
        }
    }
}
