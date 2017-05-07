using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YORDY.Solid._2OpenClose
{
    class EstadosTareaHelper
    {
        public virtual void Finalizar(EstadosTareaHelper estado )
        {
            switch(estado)
            {
                case EstadoTarea.Pendiente:
                    break;

            } 
        }
    }
}
