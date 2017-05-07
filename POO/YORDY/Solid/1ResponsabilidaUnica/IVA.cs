using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YORDY
{
    class IVA
    {
        public readonly decimal iva = 0.16m;
        public decimal ClacualarIva(decimal importante)
        {
            return importante * iva;
        } 
    }
}
