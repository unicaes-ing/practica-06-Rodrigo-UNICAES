using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guiapractica6
{
    class Guia6ej4
    {
        static decimal Binario(decimal num)
        {
            if (num < 2)
            {
                return num;
            }
            else
            {
                return num % 2 + (10 * Binario(num / 2));
            }
        }

        static void Main(string[] args)
        {
            decimal num;
            Console.WriteLine("Ingrese el numero que desea convertir a binario: ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("El numero en binario es: {0}", Binario(num));
            Console.ReadKey();
        }
    }
}
