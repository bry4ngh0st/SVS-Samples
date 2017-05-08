using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YORDY.Solid._2OpenClose
{
    public abstract class EstadoTareaBase
    {
        protected Tarea _tarea;
        public abstract void Fianlizar();
        public abstract void Cancelar();
        public abstract void Posponer();

    }
}
