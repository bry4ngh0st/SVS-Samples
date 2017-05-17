using SVS.Negocio.Entidades;
using System.Data.Entity;

namespace SVS.Database.EF
{
    public class ContextDB : DbContext
    {
        public ContextDB() : base("dbprueba") { }
        public DbSet<Post> ListaPost { get; set; }
    }
}
