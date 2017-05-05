using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max.ClaseNullReference
{
    public class Equipo
    {
        private static AdminEquipo admin { get; set; }
        
        public static AdminEquipo GetAdmin()
        {
            if (admin == null)
            {
                admin = new AdminEquipo();
            }
            return admin;
        }
        
    }
}
