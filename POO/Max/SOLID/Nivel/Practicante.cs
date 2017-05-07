using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max.SOLID.Nivel
{
    public class Practicante : Desarrollador
    {
        protected int salario { get; set; }
        public Practicante()
        {
            salario = 0;
        }

        public override decimal ObtenerSalario()
        {
            return salario;
        }
    }
}
