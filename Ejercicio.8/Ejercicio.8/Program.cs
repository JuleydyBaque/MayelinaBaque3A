using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio._8
// Crear un programa en C# que lea un número entero y positivo y que escriba tres columnas. 
// La primera cuenta desde uno hasta el número escrito contando de uno en uno; la segunda
// columna cuenta de dos en dos y la tercera de tres.  
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa un número que sea entero");

            int primero = Convert.ToInt32(Console.ReadLine());

            int segundo = 0;
            int tercero = 0;

            for (int i = 1; i <= primero; i++)
            {
                Console.Write(i);
                Console.Write("  ");

                segundo = segundo + 2;

                if (segundo > primero)
                {
                    Console.Write("  ");

                }
                else
                {
                    Console.Write(segundo);

                }
                Console.Write("  ");
                tercero = tercero + 3;

                if (tercero > primero)
                {
                    Console.Write("  ");
                }
                else
                {
                    Console.Write(tercero);
                }
                Console.WriteLine();


            }
            Console.Write("--------PROGRAMA TERMINADO--------");

            Console.ReadKey();
        }
    }
}
