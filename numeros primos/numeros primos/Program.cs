using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numeros_primos
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            Console.WriteLine("numero primos entre 1 y 1000:");
            for (int numeros = 1; numeros <= 1000 && contador < 100; numeros++)
            {
                bool esnumeroprimo = true;
               
                for (int recorrido = 1; recorrido < numeros; recorrido++)
                {
                    bool esnumeronodivisible = numeros % recorrido != 0;
                    if (!esnumeronodivisible && recorrido != 1)
                    {
                        esnumeroprimo = false;
                        break;
                    }
                }
                if (esnumeroprimo)
                {
                    contador++;
                    Console.Write(numeros + ", ");
                }
            }



            Console.ReadKey();
        }
    }
}
