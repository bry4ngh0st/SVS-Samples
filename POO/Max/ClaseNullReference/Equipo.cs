using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max.ClaseNullReference
{
    class Equipo
    {
        public Equipo()
        {
            if (admin == null)
            {
                admin = new AdminEquipo();
            }
        }
        public int id { get; set; }
        public AdminEquipo admin { get; set; }
    }
}
