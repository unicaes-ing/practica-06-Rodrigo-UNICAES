using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guiapractica6
{
    class Guia6ej3
    {
        static int BaseXExponente(int baseX, int expo)
        {
            if (expo == 0)
            {
                return 1;
            }
            else
            {
                return baseX * BaseXExponente(baseX, expo - 1);
            }
        }

        static void Main(string[] args)
        {
            int baseX, expo;
            Console.WriteLine("Ingrese la base: ");
            baseX = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el exponente: ");
            expo = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} x {1} = {2}", baseX, expo, BaseXExponente(baseX, expo));
            Console.ReadKey();
        }
    }
}
