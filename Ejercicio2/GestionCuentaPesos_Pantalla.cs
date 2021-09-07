using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    static public class GestionCuentaPesos_Pantalla
    {
        static public void CtaPesosPant(string tDNI)
        {
            int op = 1;
            while (op != 0)
            {
                Console.Clear();
                Console.Write($"         - CUENTA PESOS -        \n" +
                              $"==================================\n" +
                              $" 1- Consultar\n" +
                              $" 2- Acreditar\n" +
                              $" 3- Debitar\n" +
                              $" 4- Comprar Dolares\n" +
                              $" 0- Salir\n\n");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 0:
                        break;
                    case 1:
                        ConsultarCtaPesos(tDNI);
                        break;
                    case 2:
                        AcreditarCtaPesos(tDNI);
                        break;
                    case 3:
                        DebitarCtaPesos(tDNI);
                        break;
                    case 4:
                        ComprarDolares(tDNI);
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }

        static public void ConsultarCtaPesos(string tDNI)
        {
            Console.Clear();
            Console.Write($"\n\n    El saldo actuar es de: " +
                          $"{Math.Round(GestionCuenta_Facade.ConsultarPesos(tDNI), 2)}");
            Console.ReadKey();
        }

        static public void DebitarCtaPesos(string tDNI)
        {
            Console.Clear();
            Console.Write($"        - DEBITAR PESOS -        \n" +
                          $"Ingrese monto a pagar: ");
            double pago = double.Parse(Console.ReadLine());
            if (GestionCuenta_Facade.DebitarPesos(tDNI, Math.Round(pago, 2)))
            {
                Console.Write("\n\n    Debitación completada!");
                Console.ReadKey();
            }
            else
            {
                Console.Write("\n\n    Saldo insuficiente!");
                Console.ReadKey();
            }

        }

        static public void AcreditarCtaPesos(string tDNI)
        {
            Console.Clear();
            Console.Write($"        - ACREDITAR PESOS -        \n" +
                          $"==================================\n" +
                          $"Ingrese monto a acreditar: ");
            double debit = double.Parse(Console.ReadLine());
            GestionCuenta_Facade.AcreditarPesos(tDNI, debit);
            Console.Write("\n\n    Acreditación completada!");
            Console.ReadKey();
        }

        static public void ComprarDolares(string tDNI)
        {
            Console.Clear();
            Console.Write($"        - COMPRAR DOLARES - \n" +
                          $"==================================\n" +
                          $"Ingrese Dolares a comprar: ");
            double compra = double.Parse(Console.ReadLine());
            Console.Clear();
            Console.Write($"        - COMPRAR DOLARES - \n" +
                          $"==================================\n" +
                          $"  Confirmar compra de: {compra} Dolares" +
                          $"  Total en pesos: {Math.Round(compra * Banca_Repository.DolarActual, 2)}\n\n");

            Console.Write($" 1- Confirmar\n" +
                $" 2- Cancelar\n\n");
            int op = int.Parse(Console.ReadLine());
            if (op == 1)
            {
                if (GestionCuenta_Facade.ComprarDolares(tDNI, compra))
                {
                    Console.Clear();
                    Console.WriteLine("\n\n        - Compra realizada con Éxito! - ");
                    Console.ReadKey();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine($"\n\n        - Fondos insuficientes - ");
                    Console.ReadKey();
                }
            }
        }
    }
}
