using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YORDY
{
    class Program
    {
        static void Main(string[] args)
        {
            Solid.Factura factura = new Solid.Factura();
           
            factura.CalcularTotal();
            
            Solid._2OpenClose.Junior junior = new Solid._2OpenClose.Junior();

            Console.WriteLine(junior.ObtenerSalario());

            Console.ReadLine();

        }
    }
}
