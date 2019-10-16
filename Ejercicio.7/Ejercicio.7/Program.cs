using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio._7
//Crear un programa que escriba dos columnas de números, en la primera se colocan
//los números del 1 al 100, en la segunda los números del 100 al 1  
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------NÚMEROS--------");
            Console.WriteLine("-1 AL 100- -100 AL 1-");

            int j = 100;

            for (int i = 1; i <= j; i++)
            {
                Console.Write(i);
                Console.Write("             ");
                Console.WriteLine(101 - i);

            }
            Console.WriteLine(" ");

            Console.WriteLine("----FIN DEL PROGRAMA----");

            Console.ReadKey();
        }
    }
}
