using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Max4.Interfaz;
namespace Max4.Clases
{
    public class Manager
    {
        public static void Registrar(IDatabase db)
        {
            db.Registrar();
        }
    }
}
