using NUnit.Framework;
using SVS.EF.Entidades;
using System;
using System.Collections.Generic;

namespace SVS.EF.Tests
{
    [TestFixture]
    public class MySqlEFTests
    {
        private static ContextoBD _contexto = new ContextoBD();

        [Test]

        public void RegistrarNuevosPostsTest()
        {
            var posts = new List<Post>()
            {
                new Post { Contenido = "Post sobre entity framework", FechaRegistro = DateTime.Now },
                new Post { Contenido = "Post sobre errores en entity framework", FechaRegistro = DateTime.Now },
                new Post { Contenido = "Post sobre principios solid", FechaRegistro = DateTime.Now },
                new Post { Contenido = "Post sobre patrones de diseno", FechaRegistro = DateTime.Now },
                new Post { Contenido = "UNAMBA", FechaRegistro = DateTime.Now },
                new Post { Contenido = "Spring Valley Software", FechaRegistro = DateTime.Now },
                new Post { Contenido = "Kevin", FechaRegistro = DateTime.Now },
                new Post { Contenido = "Percy", FechaRegistro = DateTime.Now },
                new Post { Contenido = "Post sobre entity framework. Parte 2", FechaRegistro = DateTime.Now }
            };

            foreach (var post in posts)
            {
                _contexto.Posts.Add(post);
            }

            _contexto.SaveChanges();
        }

        [Test]
        public void GetPostsTest()
        {
            var posts = _contexto.Posts;

            foreach (var post in posts)
            {
                Console.WriteLine($"{post.Id} | {post.Contenido}");
            }
        }
    }
}
