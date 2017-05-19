using SVS.EF.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVS.EF.Negocio
{
    public class ManagerBD 
    {
        public static ContextoBD Contexto = new ContextoBD();
        public List<Post> Listarposts()
        {
            return Contexto.Posts.ToList();
        }
        public string Lista()
        {
            return "Hola";
        }

    }
}
