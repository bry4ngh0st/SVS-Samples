using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max.SOLID.Nivel
{
    public class Senior : Desarrollador
    {
        private int salario { get; set; }
        public Senior()
        {
            salario = 5000;
        }

        public override decimal ObtenerSalario()
        {
            return salario;
        }
    }
}
