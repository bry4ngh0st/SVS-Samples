using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max.SOLID.Nivel
{
    public class Junior : Desarrollador
    {
        private int salario { get; set; }
        public Junior()
        {
            salario = 2000;
        }

        public override decimal ObtenerSalario()
        {
            return salario;
        }
    }
}
