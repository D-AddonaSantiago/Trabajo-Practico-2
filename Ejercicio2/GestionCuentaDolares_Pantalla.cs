using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    static public class GestionCuentaDolares_Pantalla
    {
        static public void CtaDolaresPant(string tDNI)
        {
            bool salir = false;
            while (!salir)
            {
                Console.Clear();
                Console.Write($"         - CUENTA DOLARES -        \n" +
                              $"==================================\n" +
                              $" 1- Consultar\n" +
                              $" 2- Acreditar\n" +
                              $" 3- Debitar\n" +
                              $" 4- Comprar Pesos\n" +
                              $" 0- Salir\n\n");
                int op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        {
                            ConsultarCtaDolares(tDNI);
                            break;
                        }
                    case 2:
                        {
                            AcreditarCtaDolares(tDNI);
                            break;
                        }
                    case 3:
                        {
                            DebitarCtaDolares(tDNI);
                            break;
                        }
                    case 4:
                        {
                            CompraDePesos(tDNI);
                            break;
                        }
                    case 0:
                        { 
                            salir = true;
                            return;
                        }
                    default:
                        break;
                }
            }
        }

        static public void ConsultarCtaDolares(string tDNI)
        {
            Console.Clear();
            Console.Write($"\n\n    El saldo actual es de: " +
                          $"{Math.Round(GestionCuenta_Facade.ConsultarDolares(tDNI), 2)}");
            Console.ReadKey();
        }

        static public void DebitarCtaDolares(string tDNI)
        {
            Console.Clear();
            Console.Write($"        - DEBITAR DOLARES -        \n" +
                          $" Ingrese monto a pagar: ");
            double pago = double.Parse(Console.ReadLine());
            if (GestionCuenta_Facade.DebitarDolares(tDNI, pago))
            {
                Console.Write("\n\n    Debitación completada!\n");
                Console.ReadKey();
            }
            else
            {
                Console.Write("\n\n    Saldo insuficiente!\n");
                Console.ReadKey();
            }

        }

        static public void AcreditarCtaDolares(string tDNI)
        {
            Console.Clear();
            Console.Write($"        - ACREDITAR DOLARES -        \n" +
                $"==================================\n" +
                $" Ingrese monto a acreditar: ");
            double acredit = double.Parse(Console.ReadLine());
            GestionCuenta_Facade.AcreditarDolares(tDNI, acredit);
            Console.Write("\n   Acreditación Exitosa \n");
            Console.ReadKey();
        }

        static public void CompraDePesos(string tDNI)
        {
            Console.Clear();
            Console.Write($"        - COMPRAR PESOS - \n" +
                          $"Ingrese Pesos a comprar: ");
            double compra = double.Parse(Console.ReadLine());
            Console.Clear();
            Console.Write($"        - COMPRAR PESOS - \n" +
                          $"  Confirmar compra de:{Math.Round(compra, 2)} Pesos\n" +
                          $"  Total en Dolares: {Math.Round(compra / Banca_Repository.DolarActual, 2)}\n\n");

            Console.Write($" 1- Confirmar\n" +
                          $" 2- Cancelar\n");
            int op = int.Parse(Console.ReadLine());
            if (op == 1)
            {
                if (GestionCuenta_Facade.ComprarPesos(tDNI, compra))
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
