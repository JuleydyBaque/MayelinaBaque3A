using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio._2
{
    class Figuras
    {

        public Figuras()
        {
        }

        public void cuadrado(int lado)
        {
            if (lado >= 0 && lado <= 50)
            {
                //linea superior 
                for (int i = 0; i < lado; i++)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine();

                //Centro de la forma
                for (int i = 0; i < lado - 2; i++)
                {
                    Console.Write(" * ");
                    for (int j = 0; j < lado - 2; j++)
                    {
                        Console.Write("   ");
                    }
                    Console.WriteLine(" * ");
                }
                // Linea inferior 
                for (int i = 0; i < lado; i++)
                {
                    Console.Write(" * ");
                }
            }
            Console.WriteLine("    ");
            Console.WriteLine("=======FIN DEL PROGRAMA=======");
        }
    }
}
