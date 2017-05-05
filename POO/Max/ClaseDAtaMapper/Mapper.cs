using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max.ClaseDAtaMapper
{
    public class Mapper
    {
        public UsuarioNegocio Mapear(UsuarioDTO usrDTO)
        {
            UsuarioNegocio usrNgc = new UsuarioNegocio //Contructor por defecto
            {
                id = usrDTO.id,
                nombre = usrDTO.nombre
            };

            return usrNgc;
        }
    }
}
