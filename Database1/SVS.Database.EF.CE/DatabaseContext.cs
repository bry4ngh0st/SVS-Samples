using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using SVS.Database.EF.CE.Entities;

namespace SVS.Database.EF.CE
{
    public class DatabaseContext: DbContext
    {
        public DbSet<Post> listaPost { get; set; }
        public DatabaseContext() : base("prueba"){
            
            }

    }
}
