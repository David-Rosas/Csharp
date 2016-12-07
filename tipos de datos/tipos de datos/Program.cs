using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tipos_de_datos
{
    class Program
    {
        static void Main(string[] args)
        {
            int repetir = 1;
            while (repetir == 1)
            {
                Console.WriteLine("Bienvenidos dame una opcion para calcular tu edad o utilizar una calculadora estandar");
                Console.WriteLine("Diga cual de las siguiente operaciones desea hacer: " + Environment.NewLine + "1. Calcular tu edad" +
                Environment.NewLine + "2. Calculadora Estandar.");

                int opcion = Convert.ToInt32(Console.ReadLine());
                int resultado;
                switch (opcion)
                {

                    case 1:
                        char edad1repetir = 's';
                        while (edad1repetir == 's')
                        {
                            Console.WriteLine("Por favor introduzca su fecha de nacimiento");
                            int edad = Convert.ToInt32(Console.ReadLine());
                            resultado = 2016 - edad;
                            Console.WriteLine("Su edad es el siguiente: " + resultado);
                            Console.WriteLine("Desea calcular su edad de nuevo o ir al menu principal. para calcular de nuevo presione S para ir al menu principal presione 0");
                            edad1repetir = Convert.ToChar(Console.ReadLine());
                        }
                            
                        break;
                    case 2:
                        Console.WriteLine("Bienvenido a la calculadora");

                        Console.WriteLine(" introduzca el primero numero");
                        int numero1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(" introduzca el primero numero");
                        int numero2 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(" elija la operacion que desea realizar:" + Environment.NewLine + "1. Sumar" + Environment.NewLine + "2. Restar"
                            + Environment.NewLine + "3. Multiplicar" + Environment.NewLine + "4. division");
                        int opcioncal = Convert.ToInt32(Console.ReadLine());

                        break;

                    default:
                        Console.WriteLine("Opción invalidad");

                        break;

                }
            }
            Console.ReadKey();  
        }
    }
}
