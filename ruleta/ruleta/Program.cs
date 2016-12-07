using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ruleta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ruleta C#-------");

            int saldo = 1000;
            while (true)
            {
                Console.WriteLine("Su saldo es " +saldo + "$");
                
                Console.Write("introduce el numero por el que quiere apostar, para terminar -1: ");
                int apuesta = Convert.ToInt32(Console.ReadLine());

                if (apuesta == -1) break;

                if (apuesta > saldo)
                {
                Console.WriteLine("No puedes apostar no tienes suficiente dinero");
                continue;
                }

                Random generador = new Random();
                int numeroaleatorio = generador.Next(0, 37);

                if(apuesta == numeroaleatorio)
                {
                    Console.WriteLine("A Caido tu numero");
                    saldo += apuesta * 36;
                }
                else
                {

                    Console.WriteLine("Lo sentimos no ha caido tu nuemro");
                    saldo -= apuesta;
                }
            }




            Console.ReadKey();
        }
    }
}
