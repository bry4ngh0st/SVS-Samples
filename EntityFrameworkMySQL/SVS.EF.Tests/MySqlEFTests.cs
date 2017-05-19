using NUnit.Framework;
using SVS.EF.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

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

        [Test]
        public void ObtenerPostSegunId()
        {
            var id = 1;
            var post = _contexto.Posts.Find(id);

            Assert.IsNotNull(post);
        }
        
        [Test]
        public void ObtenerUltimoPost()
        {
            var posts = _contexto.Posts.ToList();
            var lastPost = posts.Last();

            Assert.IsNotNull(lastPost);
        }

        [Test]
        public void ObtenerPrimerPost()
        {
            var firstPost = _contexto.Posts.First();

            Assert.IsNotNull(firstPost);
        }

        [Test]
        public void ObtenerPostsSegunPalabraClave()
        {
            var palabra = "entity";
            var posts = _contexto.Posts.Where(p => p.Contenido.Contains(palabra));

            foreach (var post in posts)
            {
                Console.WriteLine($"{post.Contenido}");
            }
        }

        [Test]
        public void PostsSegunFechaEspecifica()
        {
            var fecha = new DateTime(2017, 05, 17);
            var posts = _contexto.Posts.ToList();

            var postsFiltrados = posts.Where(p => p.FechaRegistro.Date.Equals(fecha));
        }

        [Test]
        public void PostsConContenidoRepetido()
        {
            var posts = _contexto.Posts.ToList();

            var resultado = posts
                .GroupBy(p => p.Contenido)
                .Where(g => g.Count() > 1)
                .Select(g => g.Key);

            foreach (var post in resultado)
            {
                Console.WriteLine($"{post}");
            }
        }

        [Test]
        public void PostsConContenidoUnico()
        {
            var posts = _contexto.Posts.ToList();

            var resultado = posts
                .GroupBy(p => p.Contenido)
                .Where(g => g.Count().Equals(1))
                .Select(g => g.Key);

            foreach (var post in resultado)
            {
                Console.WriteLine($"{post}");
            }
        }

        [Test]
        public void RankingDePostsSegunFecha()
        {
            var posts = _contexto.Posts.ToList();

            var resultado = posts
                .GroupBy(p => p.FechaRegistro.Date)
                .Select(g => new { fecha = g.Key, cantidad = g.Count() })
                .OrderBy(g => g.cantidad);
            
            foreach (var valor in resultado)
            {
                Console.WriteLine($"{valor.fecha.Date} - {valor.cantidad}");
            }
        }

        [Test]
        public void AdoTest()
        {
            var connectionstring = "Server=tcp:kiru.database.windows.net,1433;Initial Catalog=BD-Kiru;Persist Security Info=False;User ID=kiru;Password=azure2017$;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            using (var connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                connection.Close();
            }
        }
    }
}
