using NUnit.Framework;
using SVS.Database.EF;
using SVS.Database.Implementaciones;
using SVS.Negocio.Entidades;
using System;

namespace SVS.Database.UnitTests
{
    [TestFixture]
    public class DatabaseTests
    {
        [Test]
        public void EntityFramework()
        {
            ContextDB contextBD = new ContextDB();
            Post post = new Post();

            post.IdPost = 1;
            post.Titulo = "Entrevista";
            post.Contenido = "Comenzando a escribir algo";
            post.FechaRegistro = DateTime.Now;
            post.FechaModificacion = DateTime.Now;

            contextBD.ListaPost.Add(post);
            contextBD.SaveChanges();
        }
    }
}
