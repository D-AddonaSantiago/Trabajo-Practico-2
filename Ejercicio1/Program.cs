using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            PantallaPrincipal();
        }

        static void PantallaPrincipal()
        {
            string op;
            Boolean exit = true;
            while (exit)
            {
                Console.Clear();
                Console.Write($"    - Menú Principal -    \n" +
                $" 1- Distancia entre dos puntos \n" +
                $" 2- Área y perímetro de un círculo \n" +
                $" 3- Área y perímetro de un triángulo \n" +
                $" 0- Salir \n" +
                $"\n" +
                $" Ingrese un valor: ");

                op = Console.ReadLine();

                switch (op)
                {

                    case "1":
                        {
                            PantPunto.S_Puntos();  //pantalla Puntos
                            break;
                        }

                    case "2":
                        {
                            PantCirculo.S_Circulo();
                            break;  //pantalla circulo
                        }
                    case "3":
                        {
                            PantTriangulo.S_Triangulo();
                            break;  //pantalla triangulo
                        }
                    case "0":
                        {
                            return; //condicion de salida
                        }
                    default:
                        {
                            Console.WriteLine("Valor ingresado no valido.");
                            Console.ReadKey();
                            break;  //No hacer nada o volver a mostrar las opciones de muestra
                        }
                }

            }
        }
    }
}