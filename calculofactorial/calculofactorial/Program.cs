using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculofactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("introduce un numero y calcular su factorial");
            int numero = Convert.ToInt32(Console.ReadLine());
            int resultado = numero;
            
            for (int cont = numero -1; cont >= 1; cont--)
            {
                resultado *= cont;
                  
                          
            }

            Console.WriteLine("los numero factoriales son " + resultado);

            Console.ReadKey();
        }
    }
}
