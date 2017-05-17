using SVS.Database.EF.AE.Entities;
using System.Data.Entity;
namespace SVS.Database.EF.AE
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("prueba")
        {
        }
        public DbSet<Post> ListaPost { get; set; }
    }
}
