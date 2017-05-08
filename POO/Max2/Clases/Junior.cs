using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Max2.Interfaz;

namespace Max2.Clases
{
    public  class Junior : Desarrollador,ISalario,ISalario2
    {
        private int salario { get; set; }
        public Junior()
        {
            salario = 2000;
        }

        public decimal ObtenerSalario()
        {
            return salario;
        }

        public decimal ObtenerDescuento()
        {
            double des = salario * 0.1;
            return (decimal)des;
        }
    }
}
