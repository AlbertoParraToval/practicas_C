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
        }

        #region Practica 1
        static void Practica1(string[] args)
        {
             
            //Ejercicio HolaMundo
            Console.WriteLine("¡Hola mundo!");
            
        }
        #endregion


        #region Practica Ejemplo
        static void Ejemplo1()
        {
            int edad = 25;
            int alumnos = 24;
            string curso = "DEINT";


            Console.WriteLine("Intoduzca un número", curso, alumnos);
        }
        #endregion


        #region  Practica Ejemplo
        static void Ejemplo2()
        {
            int radio = int.Parse(Console.ReadLine());
            double area = Math.Pow(radio, 2) * Math.PI;
            Console.WriteLine($"El área del círculo de radio {radio} es {area}");
        }
        #endregion


        #region  Practica 2
        static void Practica2()
        {
            const int edad_Conducir = 18;
            const string Tiene_Carnet = "S";

            Console.WriteLine("Vamos a evaluar si puedes conducir");
            Console.WriteLine("Introduce tu edad, por favor:");
            int edad = int.Parse(Console.ReadLine());

            if(edad >= edad_Conducir)
            {
                Console.WriteLine("Puede conducir");
                string carnet = Console.ReadLine();
                Console.WriteLine("¿Pero, tienes carnet de conducir? (S/N)");
                if (String.Equals(carnet, Tiene_Carnet))
                {
                    Console.WriteLine("Puedes conducir");
                }
                else
                {
                    Console.WriteLine("No puedes conducir");
                }
                
                
            }
            else
            {
                Console.WriteLine("No puedes conducir debido a que eres menor.");
            }

         
        }
        #endregion

    }
}
