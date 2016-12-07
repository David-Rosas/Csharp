using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int tamanox = 3;
            int tamanoy = 3;
            //Array multidimensionales
            int[,] numero2d = new int[tamanox, tamanoy];
            numero2d[0, 1] = 32;
            numero2d[0, 2] = 13;
            numero2d[0, 0] = 17;

            numero2d[1, 0] = 24;
            numero2d[1, 1] = 3;
            numero2d[1, 2] = 15;

            numero2d[2, 0] = 97;
            numero2d[2, 1] = 33;
            numero2d[2, 2] = 27;
            
            for(int ps = 0; ps < tamanox; ps++)
            {
                for( int ps2 = 0; ps2 < tamanoy; ps2++)
                {
                    Console.Write(numero2d[ps, ps2] + "\t");

                }
                Console.Write(Environment.NewLine);
            }

            Console.ReadKey();
        }

    }
}
