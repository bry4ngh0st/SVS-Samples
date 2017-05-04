using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max.Clases
{
    public class Matematica : Interfaces.IOperaciones
    {
        public virtual int Calcular(int x, int y)
        {
            return x * y;
        }
        public static int Potencia(int x)
        {
            return x * x;
        }
        public double Raiz(int x)
        {
            return Math.Sqrt(x);
        }
    }
}
