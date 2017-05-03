using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max.Clases
{
    class Sumar:Matematica
    {
        public override int Calcular(int x, int y)
        {
            return x + y;
        }
    }
}
