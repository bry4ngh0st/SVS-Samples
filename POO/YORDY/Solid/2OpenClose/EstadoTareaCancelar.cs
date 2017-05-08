using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YORDY.Solid._2OpenClose
{
    public class EstadoTareaCancelar : EstadoTareaBase
    {
        public override void Cancelar()
        {
            throw new ApplicationException("tarea ya Cancelada");
        }

        public override void Fianlizar()
        {
            throw new ApplicationException("Imposible de cancelar tarea ya cancelada");
        }

        public override void Posponer()
        {
            throw new ApplicationException("Imposible Posponer Tarea ya cancelada");
        }
    }
}
