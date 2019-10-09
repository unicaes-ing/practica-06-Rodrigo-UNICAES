using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guiapractica6
{
    class Guia6ej2
    {
        public static void Dibujo(int basetam = 0, int alto = 0)
        {
            int a, b;
            for (a = 0; a <= basetam; a++)
            {
                for (b = 0; b <= alto; b++)
                {
                    Console.WriteLine("* ", b);
                    Console.WriteLine("");
                }
            }
        }

        public static void Dibujo(ConsoleColor texto, string forma, int basetam = 0, int alto = 0)
        {
            int a, b;
            Console.ForegroundColor = texto;
            for ( a = 0; a <= basetam; a++)
            {
                for ( b = 0; b <= alto; b++)
                {
                    Console.WriteLine(forma, b);
                    Console.WriteLine("");
                }
            }
        }

        public static void Dibujo(ConsoleColor texto, string forma, int basetam = 0, int alto = 0, int x = 0, int y = 0)
        {
            int a, b;
            Console.ForegroundColor = texto;
            for ( a = 0; a <= basetam; a++)
            {
                Console.SetCursorPosition(x, y++);
                for ( b = 0; b <= alto; b++)
                {
                    Console.WriteLine(forma, b);
                    Console.WriteLine("");
                }
            }
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca el alto de la figura: ");
            int alto = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tamaño de la base de la figura: ");
            int basetam = int.Parse(Console.ReadLine());
            Dibujo(basetam, alto);
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Introduzca el alto de la figura: ");
            alto = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tamaño de la base de la figura: ");
            basetam = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la forma: ");
            string forma = Convert.ToString(Console.ReadLine());
            Dibujo(ConsoleColor.Red, forma, basetam, alto);
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Introduzca alto de la figura: ");
            alto = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tamaño de la base de la figura: ");
            basetam = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la forma: ");
            forma = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Ingrese la coordenada x: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la coordenada y: ");
            int y = int.Parse(Console.ReadLine());
            Dibujo(ConsoleColor.DarkBlue, forma, basetam, alto, x, y);
            Console.ReadKey();
        }
    }
}
