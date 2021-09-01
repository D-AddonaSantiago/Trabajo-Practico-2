using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class PantTriangulo
    {
        public static void S_Triangulo()
        {
            Console.Clear();
            Console.Write($"    - Menu Triángulo -    \n" +
                $" Ingrese el primer punto: \n");
            Console.Write($" P1(x): ");
            double px1 = Convert.ToDouble(Console.ReadLine());
            Console.Write($" P1(y): ");
            double py1 = Convert.ToDouble(Console.ReadLine());

            Console.Write($"\n Segundo punto: \n");
            Console.Write($" P2(x): ");
            double px2 = Convert.ToDouble(Console.ReadLine());
            Console.Write($" P2(y): ");
            double py2 = Convert.ToDouble(Console.ReadLine());

            Console.Write($"\n Tercer punto: \n");
            Console.Write($" P3(x): ");
            double px3 = Convert.ToDouble(Console.ReadLine());
            Console.Write($" P3(y): ");
            double py3 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine($"\n    - Resultados -    ");
            Console.Write($" El área del triángulo es de: {FacadeTriangulo.AreaTriangulo(px1,py1,px2,py2,px3,py3)}\n");
            Console.Write($" Y el perímetro es de: {FacadeTriangulo.PerimTriangulo(px1, py1, px2, py2, px3, py3)}");
            Console.ReadKey();
        }
    }
}
