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

            if (string.IsNullOrEmpty(Nombre))
                throw new Exception("Nombre invalido");

            if (Precio == 0)
                throw new Exception("Insetar precio");

            if (Lugar == null)
                throw new Exception("El lugar es invalido.");

            return true;
        }
    }
}
