using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumnouno = new Alumno();
            alumnouno.nombre = "Pedro";
            alumnouno.apellido = "Rosas";
            alumnouno.curso = 5;   
        }
    }
    public class Alumno
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int curso {
            get
            {
                if (0 > curso && curso > 7) return curso;
                    
            }
        }
        public char letra { get; set; }
        public bool sexo { get; set; } // true mujer , false hombre
        public int notaglobal { get; set; }
        public int notas { get; set; }
    }
}
