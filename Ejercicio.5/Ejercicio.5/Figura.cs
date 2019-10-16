using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio._5
{
    class Figura
    {
        public Figura()
        {
        }
        public void triangulo(int lado)
        {
            for (int i = 1; i <= lado; i++)
            {

                for (int j = 0; j <= lado - i; j++)

                    Console.Write(" ");

                for (int k = 0; k < (i * 2) - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
