using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio._1
//Programa que lea una serie de números por teclado e indique cuál es el mayor.

{
    class Program
    {
        static void Main(string[] args)
        {
            int cant, num;
            int mayor = 0;
            Console.WriteLine("Digite la cantidad de números a comparar");
            cant = int.Parse(Console.ReadLine());

            for (int i = 0; i < cant; i++)
            {
                Console.WriteLine("Escriba un número");
                num = int.Parse(Console.ReadLine());

                if (i == 0)
                {
                    mayor = num;

                }
                else if (i != 0)
                {
                    if (num > mayor)
                    {
                        mayor = num;
                    }
                }

            }
            Console.WriteLine("El número mayor es:" + mayor);
            Console.WriteLine("--------FIN DEL PROGRAMA-------");
            Console.ReadKey();

        }
    }
}
