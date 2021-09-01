using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class PantCirculo
    {
        public static void S_Circulo()
        {
            Console.Clear();
            Console.Write($"    - Menu Circulo -    \n" +
                $" Ingrese el punto central del circulo: \n" +
                $" Eje X: ");
            double px = Convert.ToDouble(Console.ReadLine());
            Console.Write($" Eje Y: ");
            double py = Convert.ToDouble(Console.ReadLine());

            Console.Write("\n Ingrese el radio del circulo: ");
            double radio = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"\n    - Resultados -    \n" +
                $" El área es de: {FacadeCirculo.AreaCirculo(px, py, radio)}");
            Console.Write($" Y su perímetro de: {FacadeCirculo.PerimCirculo(px, py, radio)}");
            Console.ReadKey();
        }
    }
}
