using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un numero y te dire su tabla de multiplicar:");
            int numero = Convert.ToInt32(Console.ReadLine());
            for(int cuenta = 1; cuenta <= 10; cuenta++)
            {
                int multiplicacion = numero * cuenta;
                Console.WriteLine(numero +" por " + cuenta + " es igual " + multiplicacion);
            }



            Console.ReadKey();
        }
    }
}
