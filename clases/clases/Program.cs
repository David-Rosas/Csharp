using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado empleadouno = new Empleado();
            empleadouno.nombre = "juan";
            empleadouno.apellido = "fendandez Roldan";
            empleadouno.departamento = "Contabilidad";
            empleadouno.sexo = false;
            empleadouno.sueldo = 1400;
            Empleado empleadodos = new Empleado();
            empleadodos.nombre = "Pepe";
            empleadodos.apellido = "Perez Gonzalez";
            empleadodos.departamento = "Informatica";
            empleadodos.sexo = false;
            empleadodos.sueldo = 1000;

            Console.WriteLine(empleadouno.obtenerFicha());

            empleadouno.subirsueldo(20);
            Console.WriteLine(empleadouno.obtenerFicha());
            Console.ReadKey();

        }
    }
    public class Empleado
    {
        //properties
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string departamento { get; set; }
        public bool sexo { get; set; }  // false for male, true female
        public double sueldo { get; set; }

        // Métodos
        public string obtenerFicha()
        {
            string sexoelegible = "Hombre";
            if (this.sexo == true) sexoelegible = "Mujer";
            string ficha = "Nombre: " + this.nombre + " " + this.apellido + Environment.NewLine +
                            "Departamento: " + this.departamento + Environment.NewLine +
                            "Sexo: " + sexoelegible + Environment.NewLine +
                            "Sueldo: " + this.sueldo + "$" + Environment.NewLine;

            return ficha;
        }
        public void subirsueldo(double porcentaje)
        {
            this.sueldo += porcentaje * this.sueldo / 100;
        }
    }
}
       
