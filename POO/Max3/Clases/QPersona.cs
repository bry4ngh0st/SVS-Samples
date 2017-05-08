using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Max3.Interfaz;
using System.ComponentModel.Composition;

namespace Max3.Clases
{
    [Export("persona", typeof(IPersona))]
    public class QPersona : IPersona
    {
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool Edit(DTOPersona id)
        {
            throw new NotImplementedException();
        }

        public DTOPersona GetById(int id)
        {
            DTOPersona persona = new DTOPersona();
            
            persona.IdPersona = 1;
            persona.Nombre = "Max";
            persona.Apellido = "Aguilar";
            persona.FechaRegistro = DateTime.Now;
            persona.Fechamodificacion = DateTime.Now;

            return persona;
        }

        public bool Insert(DTOPersona x)
        {
            throw new NotImplementedException();
        }
    }
}
