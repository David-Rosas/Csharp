using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            double resultado = Suma(3, 4, 2);
            Console.WriteLine(resultado);


            Console.ReadKey();

        }
        static int Suma(int numero1, int numero2, int numero3 = 0, int numero4 = 0)
        {
            return numero1 + numero2 + numero3 + numero4;
        }
        
    }
}
