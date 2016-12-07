using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("METODOS RECURSIVOS");
            Console.WriteLine();
            Console.WriteLine(" Numero a factorial");
            Console.WriteLine(" Introdusca Numero");
            int numeroentrada = Convert.ToInt32(Console.ReadLine());
            int resultado = factorialrecursivo (numeroentrada);

            Console.WriteLine(" El resultado es " + resultado);

            Console.ReadKey();
        }
        static int factorial ( int numero)
        {
            int calcularf = 1;
            for ( int contador =1; contador <= numero; contador++){
                
                 calcularf = contador * calcularf;

                

            }
            return calcularf;
        }

        static int factorialrecursivo(int numero)
        {
            int resultado;
            if (numero == 0) return 1;

          resultado = numero * factorialrecursivo(numero - 1);

            return resultado;
        }
    }
}
