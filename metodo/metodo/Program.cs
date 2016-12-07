using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodo
{
    class Program
    {
        static void Main(string[] args)
        {
            MostrarMenu();
            int opcionelegida = obtenernusuario();

            Console.WriteLine("Introduce el primero Numero");
            double primern = Convert.ToUInt32(Console.ReadLine());

            Console.WriteLine("Introduce el segundo Numero");
            double segundon = Convert.ToUInt32(Console.ReadLine());

            switch (opcionelegida)
            {
                case 1:
                    double suma = Sumar(primern, segundon);
                    Console.WriteLine("La suma es " + suma);

                    break;

            }



            Console.ReadKey();
        }
        static void MostrarMenu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");
        }

        static int obtenernusuario()
        {
            Console.WriteLine("Introduce la opción");
            int opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;
        }
        static double Sumar(double num1, double num2)
        {
            double suma = num1 + num2;
            return suma;
        }
    }
}
