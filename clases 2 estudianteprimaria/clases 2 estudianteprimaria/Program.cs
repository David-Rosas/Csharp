﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases_2_estudianteprimaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Escuelap alumnouno = new Escuelap();
            alumnouno.nombre = "Juan";
            alumnouno.apellido = "Rosas";
            alumnouno.letra = true;
            alumnouno.sexo = true;
            Console.WriteLine("Añadir notas del alumno por favor");
            alumnouno.notas = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Consulta ficha alumno" + Environment.NewLine + alumnouno.Obtenerficha() +Environment.NewLine + "Nota global: " + alumnouno.Anadirnotas());
            Console.ReadKey();
        }
    }
    //propiedades
    public class Escuelap
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string curso { get; set;}
        public bool letra { get; set; }
        public char letraelegible {
            get
            {
                if (this.letra == true) return 'a';
                else return 'b';

            }
                }
        public bool sexo { get; set; }
        public string sexolegible
        {
            get
            {
                if (this.sexo == true) return "Mujer";
                else return "Hombre";

            }
        }
        public double notas { get; set; }
        public double notaglobal { get; set; }

        //metodos
        public double Anadirnotas()
        {
            int contador = 0;
            double[] arreglo;
            double sumadenotas = this.notas;

            while (contador != 9)
            {
                arreglo = new double[10];
                arreglo[contador] = this.notas;
                sumadenotas = sumadenotas + arreglo[contador];
                contador++;
                Console.WriteLine("agregue una nueva nota o introdusca -1 para salir");
                arreglo[contador] = Convert.ToInt32(Console.ReadLine());
               
           }
            return sumadenotas;

        }
        public string Obtenerficha()
        {
            string ficha = "Nombre: " + this.nombre + " " + this.apellido + Environment.NewLine +
            "letra: " + this.letraelegible + Environment.NewLine + "Sexo: " + this.sexolegible 
            + Environment.NewLine + "Notas: " + this.notas;
            return ficha;
    }


    }
   
}
