using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio._6
{
    class Figura
    {
        public Figura()
        {
        }
        public void rombo(int lado)
        {
            for (int i = 1; lado - 1 >= i; i++)
            {
                for (int j = lado; j >= i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; 2 * i - 1 >= k; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = 1; lado >= i; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 2 * lado - 1; 2 * i - 1 <= k; k--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}

