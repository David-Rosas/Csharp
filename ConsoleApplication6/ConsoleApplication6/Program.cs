using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al banco quedas pelando de Venezuela");
            Console.WriteLine();
            Console.WriteLine("Introdusca el monto otorgado ");
            double credito = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introdusca cantidad de meses del credito");
            double meses = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("introdusca el Porcentaje de interes");
            double porcentaje = Convert.ToInt32(Console.ReadLine());
           double resultado = Montomes(credito, porcentaje, meses);

            Console.WriteLine("Su cuoata por mes + interes es :" + resultado + " cantidad total a pagar: " + resultado*meses);

            Console.ReadKey();
        }
        static double Montomes(double credito, double porcentaje, double mes)
        {
            double porciento = porcentaje / 100;
            double resultado1 = (credito/mes) * porciento;
           double resultado2 = resultado1 + (credito/mes);

            return resultado2;
        }
              
    }
}
