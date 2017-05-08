using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max.SOLID
{
    public abstract class Desarrollador
    {
        public string Nombre { get; set; }
        public abstract decimal ObtenerSalario();

    }
}
