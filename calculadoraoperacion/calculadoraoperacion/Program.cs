using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadoraoperacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido  a la calculadora 2.0");

            Console.WriteLine("Introdusca la operacion que quiere hacer: " + Environment.NewLine +
                "1. Suma" + Environment.NewLine + "2. Resta" + Environment.NewLine + "3. Multiplicacion"
                + Environment.NewLine + "4. Division");

            int operacion = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("introduzca el primer numero");
            Double numerouno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduzca el segundo numero");
            Double numerodos = Convert.ToInt32(Console.ReadLine());

            if (operacion == 1)
            {
                Double resultado = numerouno + numerodos;
                Console.WriteLine("el resultado de la suma es " + resultado);
            } 
            else if (operacion == 2)
            {
                Double resultado = numerouno - numerodos;
                Console.WriteLine("el resultado de la resta es " + resultado);

            }       
            else if (operacion == 3)
            {
                Double resultado = numerouno * numerodos;
                Console.WriteLine("el resultado de la multiplicacion es " + resultado);

            }
            else if ( operacion == 4)
            {
                Double resultado = numerouno / numerodos;
                Console.WriteLine("el resultado de la division es " + resultado);
            }

            else
            {
                Console.WriteLine("Esta opcion no existe");
            }
            Console.ReadKey();
        }
    }
}
