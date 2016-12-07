using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numeros_pares_e_impares
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("numeros par de 1 hasta el 1000");
            for (int cont = 1; cont <= 1000; cont++)
            {
                if( cont % 2 != 0)
                {
                    Console.Write(cont + ",");
                }
            }

            Console.ReadKey();
        }
    }
}
