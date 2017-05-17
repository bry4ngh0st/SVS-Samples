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
        public ContextoBD() : base("prueba")
        {

        }
        public DbSet<Post> ListaPost { get; set; }
    }
}
