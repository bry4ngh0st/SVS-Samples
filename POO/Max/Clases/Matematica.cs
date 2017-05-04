using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max.Clases
{
    class Matematica
    {
        public virtual int Calcular(int x, int y)
        {
            return x * y;
        }
        public static int Potencia(int x)
        {
            return x * x;
        }
    }
}
