using SVS.Database.EF.JY.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVS.Database.EF.JY
{
    public class DatabaseContext : DbContext
    {

        public DatabaseContext() : base("bdprueba")
        {

        }
        public DbSet<Post> ListaPost { get; set; }


    }



}
