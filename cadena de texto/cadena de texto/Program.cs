using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadena_de_texto
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
           Console.Write("Introduce tu nombre");
            nombre = Console.ReadLine();
                        
            Console.WriteLine("hola," + nombre + "!!!");

            Console.ReadKey();
        }
    }
}
