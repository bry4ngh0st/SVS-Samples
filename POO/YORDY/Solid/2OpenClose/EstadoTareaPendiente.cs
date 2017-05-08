using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YORDY.Solid._2OpenClose
{
    class EstadoTareaPendiente : EstadoTareaBase
    {
        public override void Cancelar()
        {
            throw new ApplicationException("Imposible de Cancelar");
        }

        public override void Fianlizar()
        {
            throw new ApplicationException("tarea finalizada");
        }

        public override void Posponer()
        {
            throw new ApplicationException("Imposible de cancelar");
        }
    }
}
