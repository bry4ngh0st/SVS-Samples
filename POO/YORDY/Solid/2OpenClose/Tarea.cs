using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YORDY.Solid._2OpenClose
{
    public class Tarea
    {
        private EstadoTareaBase _estadoTarea;
        public Tarea()
        {
            _estadoTarea = new EstadoTareaPendiente();

        }
        public void Finalizar()
        {
            _estadoTarea.Finalizar();

        }
        public void Cancelar()
        {
            _estadoTarea.Cancelar();
        }
        public void Posponer()
        {
            _estadoTarea.Posponer();
        }

    }
}
