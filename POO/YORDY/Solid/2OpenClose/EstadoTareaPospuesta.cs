using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YORDY.Solid._2OpenClose
{
    class EstadoTareaPospuesta : EstadoTareaBase
    {
        public override void Cancelar()
        {
            //cancelemos 
        }

        public override void Fianlizar()
        {
            throw new ApplicationException("Imposible posponer Tarea ya fianlizad");
        }

        public override void Posponer()
        {
            throw new ApplicationException("Tarea ya Pospuesta");
        }
    }
}
