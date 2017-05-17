using SVS.Negocio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVS.Database.EF
{
    public class ContextoBD : DbContext
    {
        public DbSet<Post> listaPost { get; set; }
        public ContextoBD() : base("prueba")
        {

        }

    }
}
