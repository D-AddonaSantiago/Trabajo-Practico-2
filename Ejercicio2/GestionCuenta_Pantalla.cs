using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class GestionCuenta_Pantalla
    {
        public void IngresarBancaPantalla()
        {
            Console.Clear();
            Console.Write($"        - Ingreso de Cuenta -\n" +
                          $"Ingrese DNI: ");
            string tDNI = Console.ReadLine();
            Banca miBanca = Banca_Repository.Obtener(tDNI);
            if (miBanca != null)
            {
                GestionCuentaPantalla(miBanca);
            }
            else
            {
                Console.Clear();
                Console.Write($"\n\n    No existe una cuenta con ese dato");
            }
        }
        public void GestionCuentaPantalla(Banca miBanca)
        {
            Console.Clear();
            Console.Write($"        - Gestion Cuenta -        \n" +
                          $" 1- Cuenta en Pesos \n" +
                          $" 2- Cuenta en Dolares \n" +
                          $" 0- Salir");
            int op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    {
                        CtaPesosPant(miBanca);
                        return;
                    }
                case 2:
                    {
                        CtaDolaresPant(miBanca);
                        return;
                    }
                default:
                    break;
            }
        }

        public void CtaPesosPant(Banca miBanca)
        {
            Console.Clear();
            Console.Write($"         - Cuenta Pesos -        \n" +
                $" 1- Consultar\n" +
                $" 2- Acreditar\n" +
                $" 3- Debitar\n" +
                $" 4- Comprar Dolares\n" +
                $" 0- Salir\n");
            int op = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                    {
                        ConsultarCtaPesos(miBanca);
                        return;
                    }
                case 2:
                    {
                        AcreditarCtaPesos(miBanca);
                        return;
                    }
                case 3:
                    {
                        DebitarCtaPesos();
                        return;
                    }
                case 4:
                    {
                        ComprarDolares();
                        return;
                    }
                default:
                    break;
            }
        }

        public void ConsultarCtaPesos(Banca miBanca)
        {
            Console.Clear();
            Console.Write($"\n\n    El saldo actuar es de:\n" +
                $"{GestionCuenta_Facade.ConsultarPesos()}");
        }

        public void AcreditarCtaPesos(Banca miBanca)
        {
            Console.Clear();
            Console.Write($"        - Acreditar Pesos -        \n" +
                $"Ingrese valor a pagar: ");
            double pago = double.Parse(Console.ReadLine());
            if (//AcreditarPesos(pago);)
            {
                Console.Write("Acreditación completada!");
            }
            else
            {
                Console.Write("Saldo insuficiente!");
            }

        }

        public void DebitarCtaPesos(Banca miBanca)
        {
            Console.Clear();
            Console.Write($"        - Debitar Pesos -        \n" +
                $"Ingrese valor a debitar: ");
            double debit = double.Parse(Console.ReadLine());
            //DebitarPesos(pago);
        }

        public void ComprarDolares(Banca miBanca)
        {
            Console.Clear();
            Console.Write($"        - Compra Dolares - \n" +
                          $"Ingrese Dolares a comprar: ");
            double compra = double.Parse(Console.ReadLine());
            Console.Clear();
            Console.Write($"        - Compra Dolares - \n" +
                          $"  Confirmar compra de:{compra} Dolares" +
                          $"  Total en pesos: {compra * Dolar}\n\n");

            Console.Write($" 1- Confirmar\n" +
                $" 2- Cancelar");
            int op = int.Parse(Console.ReadLine());
            if (op == 1) 
            {
                if (//OpCompraDolares(miBanca, compra);)
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


        public void CtaDolaresPant(Banca miBanca)
        {

        }
    }
}
