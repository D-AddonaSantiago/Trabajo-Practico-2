using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class PantPunto
    {
        public static void S_Puntos()
        {
            Console.Clear();
            Console.Write($"    - Menu Puntos -    \n" +                        
            $" Ingrese las componentes del primer punto: \n");
            Console.Write(" P1(x)= ");
            double px1 = Convert.ToDouble(Console.ReadLine());
            Console.Write(" P1(y)= ");
            double py1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n Ingrese las componentes del segundo punto: ");
            Console.Write(" P2(x)= ");
            double px2 = Convert.ToDouble(Console.ReadLine());
            Console.Write(" P2(y)= ");
            double py2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"\n    - Resultados -    \n");
            Console.Write($" La distancia entre los puntos es de: {FacadePunto.ManejoPuntos(px1, py1, px2, py2)}");
            Console.ReadKey();
        }
    }
}
