using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Recursividad");
            int sumar = 1;
            int sumadenumeros = 0;
            int Contador = 0;
            int[] nuevoarreglo;
            Console.WriteLine("introdusca los numero a sumar o S para salir");
        
            
            while (sumar != 0)
            {
                nuevoarreglo[Contador] = Convert.ToInt32(Console.ReadLine());

                sumar = nuevoarreglo[Contador];
                
                if (sumar != 0)
                {
                    sumadenumeros += nuevoarreglo[Contador];
                   
                }
                Contador++;
                
                            }

            Console.WriteLine("la suma es igual: " + sumadenumeros);

            Console.ReadKey();
        }

    }

}
