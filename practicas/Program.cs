using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace practicas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Practica 1
            //Practica 2
            //Practica 3
            

        }

        #region Practica 1
        static void Practica1(string[] args)
        {
             
            //Ejercicio HolaMundo
            Console.WriteLine("¡Hola mundo!");
            
        }
        #endregion


        #region Practica 2
        static void Practica2()
        {
            int edad = 25;
            int alumnos = 24;
            string curso = "DEINT";


            Console.WriteLine("Intoduzca un número", curso, alumnos);
        }
        #endregion


        #region  Practica 3
        static void Practica3()
        {
            int radio = int.Parse(Console.ReadLine());
            double area = Math.Pow(radio, 2) * Math.PI;
            Console.WriteLine($"El área del círculo de radio {radio} es {area}");
        }
        #endregion


        #region  Practica 4
        static void Practica4()
        {
            
        }
        #endregion

    }
}
