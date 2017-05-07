using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YORDY
{
    public class Deduccion
    {
        private decimal deducion;

        public Deduccion(ushort porcentaje)
        {
            deducion = porcentaje;
        }
        public decimal CalcualrDeducion(decimal importe)
        {
            return (importe * deducion)/100;
        }
    }
}
