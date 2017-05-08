using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YORDY.Solid._2OpenClose
{
    class EstadosTareaHelper
    {
        Tarea tare = new Tarea();
        EstadosTarea estado = new EstadosTarea();
        public virtual void Finalizar(EstadosTarea estado )
        {
            switch(estado)
            {
                case estado.Pendiente:
                    break;

                case estado.Pospuesta:
                    throw new ApplicationException("imposible de fianlizar");
                default:
                    throw new ArgumentOutOfRangeException();


            } 
        }
      /*  public virtual void Cancelar(EstadosTarea estado)
        {
            switch (estado)
            {

            }

         

        }
        public virtual void Posponer(EstadosTarea estado)
        {
            switch (estado)
            {
                //posponemos
            }
        }
        */
    }
}
