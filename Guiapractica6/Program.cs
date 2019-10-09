using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guiapractica6
{
    class Program
    {
        public static void Tabla(int num)
        {
            Console.WriteLine("Tabla de multliplicacion");
            Console.WriteLine();
            for (int i = 1; i < 13; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", num, i, num*i );
            }
        }
        public static void Tabla(int num, ConsoleColor texto)
        {
            Console.WriteLine("Tabla de multliplicacion");
            Console.WriteLine();
            for (int i = 1; i < 13; i++)
            {
                Console.ForegroundColor = texto;
                Console.WriteLine("{0} x {1} = {2}", num, i, num*i);
            }
        }
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Ingrese el numero que quiere multlipicar:");
            numero = int.Parse(Console.ReadLine());
            Console.Clear();
            Tabla(numero);
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Ingrese el numero que quiere multlipicar:");
            numero = int.Parse(Console.ReadLine());
            Console.Clear();
            Tabla(numero, ConsoleColor.Blue);
            Console.ReadKey();
        }
    }
}
