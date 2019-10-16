using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio._2
//Crear un programa que lea un número entero y a partir de él cree un cuadrado de asteriscos
//con ese tamaño. Los asteriscos sólo se verán en el borde del cuadrado, no en el interior. 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=======CREANDO UN CUADRADO=======");
            Figuras fig = new Figuras();
            solonumeros snum = new solonumeros();
            Boolean esNum;
            String valor;

            do
            {
                Console.WriteLine("Ingrese el valor base del cuadrado");
                valor = Console.ReadLine();
                esNum = snum.ValidarNumero(valor);

            } while (esNum == false);

            int num = Convert.ToInt32(valor);

            //Dibujamos el cuadrado llamando a el método "cuadrado" que se encuentra en la clase 
            // "figura" con el siguiente comando:

            fig.cuadrado(num);

            Console.ReadKey();

        }
    }
}

