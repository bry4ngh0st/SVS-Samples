using Max3.Interfaz;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max3.Clases
{
    public class BPersona : Catalogo
    {

        [Import("persona", typeof(IPersona))]
        private IPersona persona { get; set; }

        public BPersona()
        {
        }
        public void GetById(int id)
        {
            DTOPersona dtoper = persona.GetById(1);
            Console.WriteLine(dtoper.Nombre);
        }
    }
}
