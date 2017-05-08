using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YORDY.Solid._2OpenClose
{
    public class Senior : Desarrollador
    {
        private decimal Salario { get; set; }
        public override decimal ObtenerSalario()
        {
            return 5000;
        }
    }
}
