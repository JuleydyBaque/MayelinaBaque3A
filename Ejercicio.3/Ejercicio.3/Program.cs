using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio._3
//Crear un programa que lea cantidades y precios y al final indique el total de la factura. 
//Primero se pregunta:  
//Introduzca la cantidad vendida tras lo cual el usuario introducirá un número entero positivo. 
//Después se pregunta: 
//Introduzca el precio que será un número decimal positivo. 
//La lectura termina cuando en la cantidad se introduzca un cero. Si es así se escribirá el total.
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidad = 0;
            double precio = 0, total_pagar = 0;

            Console.WriteLine("*******FACTURA*******");

            do
            {
                Console.WriteLine("Introduzca la cantidad vendida");
                cantidad = Convert.ToInt32(Console.ReadLine());

                if (cantidad != 0)
                {
                    Console.WriteLine("Introduzca el precio");
                    precio = Convert.ToDouble(Console.ReadLine());
                }
                total_pagar = total_pagar + (cantidad * precio);

            } while (cantidad != 0);
            Console.WriteLine("El valor a cancelar es:" + total_pagar);

            Console.WriteLine("  ");
            Console.WriteLine(" ******PROGRAMA TERMINADO****** ");
            Console.ReadKey();
        }
    }
}
