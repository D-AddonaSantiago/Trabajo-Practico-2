using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = 1;
            while(op != 0)
            {
                Console.Clear();
                Console.Write($"        - Operaciones Bancarias -        \n" +
                    $" 1- Crear cuenta bancaria \n" +
                    $" 2- Gestionar cuenta bancaria \n" +
                    $" 0- Salir \n");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        {
                            CrearCuenta_Pantalla.CreaCuentaPantalla();
                            break;
                        }
                    case 2:
                        {
                            //GestionCuentaPantalla();
                            break;
                        }
                    default:
                        break;
                }
            }
        }
    }
}
