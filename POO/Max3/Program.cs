using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Max3.Clases;
using Max3.Interfaz;

namespace Max3
{
    class Program
    {
        static void Main(string[] args)
        {
            BPersona per = new BPersona();
            BProducto prod = new BProducto();

            per.GetById(1);
            prod.GetById(1);
            


            Console.Read();
        }
    }
}
