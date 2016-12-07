using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola bienvenido a la calculadora.");
            
                Console.WriteLine(" introduce un numero 1");
                int numero1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(" introduce el numero 2");
                int numero2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" Que operacion deseas realizar" + Environment.NewLine + "1. Suma" + Environment.NewLine + "2. Resta" + Environment.NewLine + "3. Multiplicacion" +
                Environment.NewLine + "4. Division");
                Console.WriteLine(" elija una opcion: ");
                int opcion = Convert.ToInt32(Console.ReadLine());
                double resultado;

                switch (opcion)
                {
                    case 1:
                        resultado = numero1 + numero2;
                        Console.WriteLine("el resultado de la Suma es: " + resultado);
                        break;

                    case 2:
                        resultado = numero1 - numero2;
                        Console.WriteLine("el resultado de la Resta es: " + resultado);
                        break;

                    case 3:
                        resultado = numero1 * numero2;
                        Console.WriteLine("el resultado de la Multiplicando es: " + resultado);
                        break;

                    case 4:
                        resultado = numero1 / numero2;
                        Console.WriteLine("el resultado de la Dividiendo es: " + resultado);
                        break;
                    default:
                        Console.WriteLine("La opcion es invalida");
                        break;
                }

                Console.WriteLine("Desea realizar otra operacion Si o No para si Presione 1 para no Presione 0");
                int rep = Convert.ToInt32(Console.ReadLine());

            Console.ReadKey();
           
        }
    }
}
