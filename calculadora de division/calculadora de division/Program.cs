using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora_de_division
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("introduce 2 numero y los dividiremos");
            Console.WriteLine("introduce dividendo");
            int numerouno = 0;
            bool conversioncorrecta = false;
            while (!conversioncorrecta)
            {
                conversioncorrecta = int.TryParse(Console.ReadLine(), out numerouno);

                if (!conversioncorrecta) Console.Write("introduce nuevamente el dividendo");
            }

            Console.WriteLine("introduce divisor");
            int numerodos= 0;
            conversioncorrecta = false;
            while (!conversioncorrecta)
            {
                conversioncorrecta = int.TryParse(Console.ReadLine(), out numerodos);

                if (!conversioncorrecta) Console.Write("introduce nuevamente el dividendo");
            }

            int resultado;

            try
            {
                resultado = numerouno / numerodos;
            }
            catch (DivideByZeroException )
            {
                Console.WriteLine("No puedes dividir por cero");
                Console.ReadKey();
                return;
            }
            catch
            {
                Console.WriteLine("ah ocurrido un error grave");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("el resultado es " + resultado);
            Console.ReadKey();
        }
        
    }
}
