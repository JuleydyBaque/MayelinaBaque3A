using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio._5
//Crear el programa asteriscos4 en el que se introduce un número entero y se crea una
//pirámide de asteriscos. Por ejemplos, si se introduce el 6, el resultado seria:
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------CREANDO UNA PIRÁMIDE------");

            Figura fig = new Figura();
            NumeroEntero nument = new NumeroEntero();
            Boolean NumEnt;
            String valor;

            do
            {
                Console.WriteLine("Ingrese un número entero para crear la pirámide:");
                valor = Console.ReadLine();
                NumEnt = nument.ValidarNumero(valor);

            } while (NumEnt == false);

            int numero = Convert.ToInt32(valor);

            //Dibujamos el triángulo llamando el método "triángulo" que se 
            //muestra en la clase "figura" con el siguiente comando:

            fig.triangulo(numero);


            Console.WriteLine(" ");


            Console.WriteLine("------FIN DEL PROGRAMA------");


            Console.ReadKey();
        }
    }
}
