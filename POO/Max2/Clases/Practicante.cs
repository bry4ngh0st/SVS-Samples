using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Max2.Interfaz;

namespace Max2.Clases
{
    public class Practicante : Desarrollador, ISalario
    {
        private int salario { get; set; }
        public Practicante()
        {
            salario = 0;
        }

        public decimal ObtenerSalario()
        {
            return salario;
        }
    }
}
