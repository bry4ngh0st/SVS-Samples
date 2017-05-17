using SVS.Negocio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVS.Database.EF
{
    public class ContextoBD : DbContext
    {
        public ContextoBD() : base(nameOrConnectionString: "dbpruebaxxx")
        {
        }

        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            //System.Data.Entity.Database.SetInitializer<ContextoBD>(new CreateDatabaseIfNotExists<ContextoBD>());
        }
    }
}
