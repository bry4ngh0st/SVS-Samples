using SVS.Frameworks.Data.EF.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVS.Frameworks.Data.EF
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Item> Items { get; set; }
    }
}
