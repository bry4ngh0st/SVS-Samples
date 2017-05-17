using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVS.Database.EF.CE.Entities
{
    public class Post
    {
        public int id { get; set; }
        public string comentario { get; set; }
        public DateTime fechaRegistro { get; set; }
        public DateTime fechaModificacion{ get; set; }
    }
}
