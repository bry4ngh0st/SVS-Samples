using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SVS.Database.EF.MA.Entities;

namespace SVS.Database.EF.MA
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Post> ListaPosts { get; set; }
        public DatabaseContext() : base("post") { }
    }
}
