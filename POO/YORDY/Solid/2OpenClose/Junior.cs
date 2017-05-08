using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YORDY.Solid._2OpenClose
{
   
    public class Junior : Desarrollador
    {
        private decimal Salario { get; set; }
        public override decimal ObtenerSalario()
        {
            return Salario = 0;
        }
    }
}
