using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mayor_de_edad
{
    class Program
    {
        static void Main(string[] args)
        {
             /*
             * > mayor que
             * < menor que
             * == igual
             * != diferente
             * ! negacion
             * ||
             * &&
             */
            Console.WriteLine("introduce cuantos años tienes:");
            int edad = Convert.ToInt32(Console.ReadLine());

            if (edad < 0 || edad > 120)
            {
                Console.WriteLine("La edad esta fuera del rango");
            }

            else if (edad < 12)
            {
                Console.WriteLine("eres demaciado pequeño");
            }
            else if (edad < 18)
            {
                Console.WriteLine("te falta poco para ser mayor");
            }
            else if (edad == 18)
            {
                Console.WriteLine("Feliciadades ya tienes 18");
            }
            else 
            {
                Console.WriteLine("eres muy viejo");
            }

            Console.ReadKey();
        }
    }
}
