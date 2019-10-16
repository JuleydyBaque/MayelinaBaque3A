using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio._10

//Crear un programa que muestre un menú como este: 

//1) Salir 
//2) Sumatorio
//3) Factorial

//Tras mostrar el menú, el programa debe leer un número del 1 al tres si se elige 1, el programa acaba. Si se 
//elige 2 se calcula el sumatorio del número, si se elige 3 se calcula la factorial (en ambos casos el programa 
//pedirá escribir el número sobre el que se calcula el sumatorio o la factorial). Tras calcular el sumatorio o la 
//factorial e indicar el resultado, el programa volverá a mostrar el menú y así sucesivamente. 
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            int numero;
            double r;

            do
            {
                do
                {
                    Console.WriteLine("::::::::MENÚ PRINCIPAL::::::::");
                    Console.WriteLine("1) Salir.");
                    Console.WriteLine("2) Sumatorio.");
                    Console.WriteLine("3) Factorial.");
                    Console.WriteLine("Introduzca una opción");
                    opcion = Convert.ToInt32(Console.ReadLine());

                } while (opcion != 1 && opcion != 2 && opcion != 3);
                if (opcion == 2)
                {
                    Console.WriteLine("Introduzca un número el cúal quiere el sumatorio");
                    numero = Convert.ToInt32(Console.ReadLine());
                    r = 0;

                    for (int i = numero; i >= 1; i--)
                    {
                        r = r + i;
                    }
                    Console.WriteLine("El sumatorio es:" + r);
                }
                else if (opcion == 3)
                {
                    Console.WriteLine("Introduzca un número el cúal quiere el factorial");
                    numero = Convert.ToInt32(Console.ReadLine());
                    r = 1;
                    for (int i = numero; i >= 1; i--)
                    {
                        r = r * i;
                    }
                    Console.WriteLine("El factorial es:" + r);
                }
            } while (opcion != 1);
            Console.WriteLine("ADIOS!!");
            Console.WriteLine(" ");
            Console.WriteLine("::::::EL PROGRAMA FINALIZÓ::::::::");
            Console.ReadKey();
        }
    }
}

          

          


