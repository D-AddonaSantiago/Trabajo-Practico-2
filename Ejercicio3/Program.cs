using System;
using System.IO;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime fecharegistro = DateTime.Parse("04/05/2018 8:34:01"); //obtenemos este valor de una bbdd
            var horas = (DateTime.Now - fecharegistro).TotalSeconds;
            Console.WriteLine(horas);
        }
    }
}
