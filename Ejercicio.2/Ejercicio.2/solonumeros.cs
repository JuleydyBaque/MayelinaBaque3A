using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio._2
{
    class solonumeros
    {
        public solonumeros()
        {
        }
        public Boolean ValidarNumero(String valor)
        {
            Boolean esNum = true;
            int val;
            esNum = int.TryParse(valor, out val);
            return esNum;
        }
    }
}
