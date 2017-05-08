using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Max2.Interfaz;
using System.Threading.Tasks;

namespace Max2.Clases
{
    public  class Senior : Desarrollador, ISalario,ISalario2
    {
        private int salario { get; set; }
        public Senior()
        {
            salario = 5000;
        }

        public decimal ObtenerSalario()
        {
            return salario;
        }

        public decimal ObtenerDescuento()
        {
            double des = salario*0.1;
            return (decimal)des;         
        }
    }
}
