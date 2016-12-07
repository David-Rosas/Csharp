using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            // array
            // Haz un programa que juegue solo a la ruleta 1000 sin dinero, una vez que termine
            //saca por pantalla cuantas veces a caido el numero
            Random aleatorio = new Random();
            int numeroapostado, numeroquecae;
            int[] estadisncaidos = new int[37];

            for(int repeticiones = 0; repeticiones < 36000; repeticiones++)
            {
                numeroapostado = aleatorio.Next(0, 37);
                Console.WriteLine($"Hemos apostado por el {numeroapostado}");

                //generar el número que sale por la ruleta

                numeroquecae = aleatorio.Next(0, 37);
                Console.WriteLine("la bola ha caido en el numero " + numeroquecae);

                //apuntar el numero que ha salido
                estadisncaidos[numeroquecae]++;
                // informa de si hemos ganado o perdido
                if(numeroquecae == numeroapostado)
                {
                    Console.WriteLine("hemos ganado");
                }
               
               else
                {
                    Console.WriteLine("hemos perdido");
                }
            }
            // mostrar estadisticas

            Console.WriteLine("estadisticas ");
            for(int posicion = 0; posicion < estadisncaidos.Length; posicion++)
            {
                Console.WriteLine($"el numero {posicion} ha caido {estadisncaidos[posicion]}");
            }
           
            Console.ReadKey();
        }
    }
}
