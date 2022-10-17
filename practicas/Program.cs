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
            //Practica3
            Console.WriteLine(Practica4);
            

        
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


        #region Practica3
        static void LeerRespuesta()
        {
            Console.WriteLine("¿Quieres entrar? S/N: ");
            string respuesta;
            Boolean salir = false;
            const string OPCION_1 = "S";
            const string OPCION_2 = "N";    
            while(salir == false)
            {
                respuesta = Console.ReadLine().ToUpper();
                if ((String.Equals(respuesta,OPCION_1)) || (String.Equals(respuesta, OPCION_2)))
                {
                    salir = true;
                } else
                {
                    Console.WriteLine("Debes introducir el valor S/N");
                }
                Console.WriteLine($"Has introducido {respuesta}");
            }

        }
        #endregion

        
        #region Practica4
        static string LeerRespuesta2()
        {
            Console.WriteLine("¿Quieres entrar? S/N: ");
            string respuesta;
            bool salir = false;
            const string OPCION_1 = "S";
            const string OPCION_2 = "N";    
            do
            {
                respuesta = Console.ReadLine().ToUpper();
                if ((String.Equals(respuesta,OPCION_1)) || (String.Equals(respuesta, OPCION_2)))
                {
                    salir = true;
                } else
                {
                    Console.WriteLine("Debes introducir el valor S/N");
                }
                 Console.WriteLine($"Has introducido {respuesta}");
            } while(!salir);
            Console.WriteLine("mensaje");
            return respuesta;

        }
        #endregion
    }
}
