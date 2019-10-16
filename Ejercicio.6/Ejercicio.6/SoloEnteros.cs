using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio._6
{
    class SoloEnteros
    {
        public SoloEnteros()
        {
        }
        public Boolean ValidarNumero(String numero)
        {
            Boolean SoEnt = true;
            int val;
            SoEnt = int.TryParse(numero, out val);
            return SoEnt;
        }
    }
}
