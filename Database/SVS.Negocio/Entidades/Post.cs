using System;
namespace SVS.Negocio.Entidades
{
    public class Post
    {
        public int IdPost { get; set; }
        public string Titulo { get; set; }
        public string Contenido { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime FechaModificacion { get; set; }

    }
}
