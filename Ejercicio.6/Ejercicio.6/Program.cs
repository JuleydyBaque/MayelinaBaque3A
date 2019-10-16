using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio._6
//Modificar el ejercicio anterior para que aparezca un rombo.  
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("::::::::CREANDO EL ROMBO::::::::");

            Figura fig = new Figura();
            SoloEnteros soent = new SoloEnteros();
            Boolean SoEnt;
            String numero;

            do
            {
                Console.WriteLine("Ingrese un número para la base del rombo:");
                numero = Console.ReadLine();
                SoEnt = soent.ValidarNumero(numero);

            } while (SoEnt == false);
            int num = Convert.ToInt32(numero);

            // Dibujamos el rombo llamando al método "rombo" que se 
            //encuentra en la clase "figura" con el siguiente comando.

            fig.rombo(num);

            Console.WriteLine(" ");

            Console.WriteLine("::::::::ROMBO TERNIMADO::::::::");

            Console.ReadKey();
        }
    }
}
