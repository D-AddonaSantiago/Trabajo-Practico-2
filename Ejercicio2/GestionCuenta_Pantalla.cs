using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    public class GestionCuenta_Pantalla
    {
        static public void IngresarBancaPantalla()
        {
            Console.Clear();
            Console.Write($"        - INGRESAR CUENTA -\n" +
                          $"====================================\n" +
                          $" Ingrese DNI: ");
            string tDNI = Console.ReadLine();
            if (GestionCuenta_Facade.ExisteCuenta(tDNI))
            {
                GestionCuentaPantalla(tDNI);
            }
            else
            {
                Console.Clear();
                Console.Write($"\n\n    No existe una cuenta con ese dato");
                Console.ReadKey();
            }
        }

        static public void GestionCuentaPantalla(string tDNI)
        {
            int op = 1;
            while (op != 0)
            {
                Console.Clear();
                Console.Write($"        - GESTIONAR CUENTA -        \n" +
                              $"====================================\n" +
                              $" 1- Cuenta en Pesos \n" +
                              $" 2- Cuenta en Dolares \n" +
                              $" 0- Salir\n\n");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 0:
                        break;
                    case 1:
                        GestionCuentaPesos_Pantalla.CtaPesosPant(tDNI);
                        break;
                    case 2:
                        GestionCuentaDolares_Pantalla.CtaDolaresPant(tDNI);
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }
    }
}
