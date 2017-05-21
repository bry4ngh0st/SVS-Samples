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
        private static ContextoBD Context = new ContextoBD();

        public List<Post> ListaPost()
        {
            var listaPosts= Context.Posts.ToList();
            return listaPosts;
        }

    }


}
