using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.Business
{
    public class Item
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public Lugar Lugar { get; set; }

        public bool EsValido()
        {
            if ((Id == 0))
            {
                return false;
            }
            else if (Nombre == null)
            {
                return false;
            }
            else if (Precio == 0)
            {
                return false;

            }
            else if (Lugar == null)
            {
                return false;
            }
            else
                return true;


        }
    }
}
