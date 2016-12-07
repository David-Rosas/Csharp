using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
           

           int numeroinvertido = invertirnumero(invertirnumero(123456));
            Console.WriteLine(numeroinvertido);

            Console.ReadKey();
        }
     static int invertirnumero(int numero)
        {
            string numerostring = numero.ToString();
            char[] secuenciacaracter = numerostring.ToCharArray();
            char[] secuenciainvertida = new char[secuenciacaracter.Length];

            for (int contador = secuenciacaracter.Length - 1; contador >= 0; contador--)
            {
                secuenciainvertida[5 - contador] = secuenciacaracter[contador];
            }
            string cadenainvertida = new string(secuenciainvertida);
            return Convert.ToInt32(cadenainvertida);
        }
    }
}
