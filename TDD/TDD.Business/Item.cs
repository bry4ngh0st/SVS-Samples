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
                throw new Exception("Id invalido");
                
            if (Id == 0 || Precio == 0 || Lugar == null )
            {
                return false;
            }
            else
            {
                if (string.IsNullOrEmpty(Nombre))
                {
                    throw new Exception("El nombre es nulo o vacío");
                }
                else
                {
                    return true;
                }
            }            

            return true;
        }
    }
}
