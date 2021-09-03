using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    static public class CrearCuenta_Pantalla
    {
        static public void CreaCuentaPantalla()
        {
            string nomTit, numDNI;
            Console.Clear();
            Console.WriteLine("        - CREAR CUENTA -        \n" +
                              "================================\n");
            Console.WriteLine(" Ingrese:");
            Console.Write(" Nombre del Titular: ");
            nomTit = Console.ReadLine();
            Console.Write(" Número de documénto: ");
            numDNI = Console.ReadLine();
            if (GestionCuenta_Facade.CrearNuevaCuenta(nomTit, numDNI))
            {
                Console.WriteLine("\n        Cuenta creada exitosamente!        ");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("                   Error!\n        Ya existe una cuenta asociada al DNI        \n");
                Console.ReadKey();
            }
        }
    }
}
