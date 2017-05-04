using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max.Clases.Modelo
{
    public class Venta : Interfaces.IDetalle
    {
        public bool Guardar(Producto p)
        {
            bool salida;
            if (p.Nombre == "CocaCola")
            {
                salida = true;
            }
            else
            {
                salida = false;
            }
            return salida;
        }
    }
}
