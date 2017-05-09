using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YORDY.Solid._2OpenClose
{
    public class Validador
    {

        public static bool Validar(Desarrollador desarrollador) {
            if (string.IsNullOrEmpty(desarrollador.Nombre))
            {
                throw new Exception(desarrollador.GetType().Name+"el nombre no puede ser nulo");
               
            }
            return true;
        }
    }
}
