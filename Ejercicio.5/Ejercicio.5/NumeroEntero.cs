using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio._5
{
    class NumeroEntero
    {
        public NumeroEntero()
        {
        }
        public Boolean ValidarNumero(String valor)
        {
            Boolean NumEnt = true;
            int val;
            NumEnt = int.TryParse(valor, out val);
            return NumEnt;

        }
    }
}
