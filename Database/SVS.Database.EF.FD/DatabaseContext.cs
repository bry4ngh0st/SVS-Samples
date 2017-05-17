using SVS.Database.EF.FD.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVS.Database.EF.FD
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("dbprueba")
        {

        }
        public DbSet<Post> ListaPost { get; set; }

        

    }
}
