using SVS.EF;
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
        private static ContextoBD contexto = new ContextoBD();
       
        public List<Post> ListaPosts()
        {            
            var lista = contexto.Posts;
            return lista.ToList();
        }       
    }
}
