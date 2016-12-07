using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace media
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bienvenido este programa calcula la nota media de diferentes examenes");
            Console.WriteLine("Introduzca notas de examenes hasta que desee. Cuando quieras terminar, introduzca  -1");

            int numerodenotas = 0;
            double sumadenotas = 0;
            double numero = 0;

            while (numero != -1) {
            numero = Convert.ToDouble(Console.ReadLine());
                if (numero != -1)
                {
                    sumadenotas += numero;
                    numerodenotas++;
                } 
                }
                    double media = sumadenotas / numerodenotas;
                    Console.WriteLine("la media de la notas " + media);
            Console.ReadKey();
        }
    }
}
