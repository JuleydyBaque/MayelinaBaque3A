using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio._9
//Crear el programa tablaMultiplicar que escriba la tabla de multiplicar del número 1 al número 15. 

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" :::::: TABLA DE MULTIPLICAR DEL 1 AL 15 :::::: ");

            for (int i = 1; i <= 15; i++)
            {
                Console.WriteLine("  ");
                Console.WriteLine(i);

                for (int j = 1; j <= 12; j++)
                {

                    Console.WriteLine(i + " X " + j + " = " + i * j);

                }

            }
            Console.WriteLine("  ");
            Console.WriteLine(":::::::PROGRAMA FINALIZADO:::::::");
            Console.ReadKey();
        }
    }
}
