using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio HolaMundo
            Console.WriteLine("¡Hola mundo!");

            //Ejercicio de la Edad
            //int edad = 25;
            //int alumnos = 24;
            //string curso = "DEINT";

            
            //Console.WriteLine("Intoduzca un número", curso, alumnos);
            
            
            int radio = int.Parse(Console.ReadLine());
            double area = Math.Pow(radio, 2) * Math.PI;
            Console.WriteLine($"El área del círculo de radio {radio} es {area}");
        }
    }
}
