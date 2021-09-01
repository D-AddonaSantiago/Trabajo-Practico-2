using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class CrearCuenta_Pantalla
    {
        public static void CreaCuentaPantalla()
        {
            string nomTit, numDNI;
            Console.WriteLine("        - Creación de Cuenta -        ");
            Console.WriteLine(" Ingrese:");
            Console.Write("Nombre del Titular: ");
            nomTit = Console.ReadLine();
            Console.Write("Número de documénto: ");
            numDNI = Console.ReadLine();
            if (CrearCuenta_Facade.CrearNuevaCuenta(nomTit, numDNI))
            {
                Console.WriteLine("        Cuenta creada exitosamente!        ");
            }
            else
            {
                Console.WriteLine("                   Error!\n        Ya existe una cuenta asociada al DNI        ");
            }
        }
    }
}
