using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Max3.Interfaz;
using System.ComponentModel.Composition.Hosting;

namespace Max3.Clases
{
    public class BProducto : Catalogo
    {
        [Import("producto", typeof(IProducto))]
        private IProducto producto { get; set; }

        public void GetById(int id)
        {
            DTOProducto dtoper = producto.GetById(1);
            Console.WriteLine(dtoper.Nombre);
        }
    }
}
