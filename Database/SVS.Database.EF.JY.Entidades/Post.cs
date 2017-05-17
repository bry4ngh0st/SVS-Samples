using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVS.Database.EF.JY.Entidades
{
    public class Post
    {
        public int id { get; set; }
        public string Comentario { get; set; }
        public DateTime FechaRegistro { get; set; }
        public  DateTime FechaModificacion{ get; set; }
    }
}
