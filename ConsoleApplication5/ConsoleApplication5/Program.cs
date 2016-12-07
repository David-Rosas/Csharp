using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("introducir numero para calcular factorial");
            int numero = Convert.ToInt32(Console.ReadLine());
            double resultado = factorial(numero);

            Console.WriteLine("el resultado es: " + resultado);



            Console.ReadKey();
        }
        static double factorial(int numero)
        {
            int resultado = 1;
            for(int multiplicador = 1; multiplicador <= numero; multiplicador++)
            {
                resultado *= multiplicador;
            }
            return resultado;
        }
    }

}
