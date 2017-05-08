using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Max3.Interfaz;
using System.ComponentModel.Composition;

namespace Max3.Clases
{
    [Export("producto", typeof(IProducto))]
    public class QProducto : IProducto
    {
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool Edit(DTOProducto id)
        {
            throw new NotImplementedException();
        }

        public DTOProducto GetById(int id)
        {
            DTOProducto producto = new DTOProducto();

            producto.Nombre = "ACE";
            producto.Precio = 200;
            producto.FechaRegistro = DateTime.Now;
            producto.Fechamodificacion = DateTime.Now;

            return producto;
        }

        public bool Insert(DTOProducto x)
        {
            throw new NotImplementedException();
        }
    }
}
