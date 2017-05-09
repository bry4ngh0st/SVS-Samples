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
            if (Id == 0)
            {
                return false;
            }
            else
            {
                return true;
            }

            if (Nombre != null)
            {
                return true;
            }
            else
            {
                return false;
            }
            if (Precio != null)
            {

                return true;
            }
            else return false;


        }
    }
}
