using SVS.EF.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVS.EF.Console
{
    public class Program
    {
        private static ContextoBD _contexto = new ContextoBD();

        static void Main(string[] args)
        {
            //RegistrarPosts();
            //System.Console.WriteLine("Posts agregados correctamente");
            //var posts = _contexto.Posts;

            //foreach (var post in posts)
            //{
            //    System.Console.WriteLine($"{post.Id} | {post.Contenido}");
            //}
            // var post = obteberpost(1);
            //System.Console.WriteLine($"{post.Id} | {post.Contenido}");

            //var ultimopost = UltimoPost();
            //System.Console.WriteLine($"{ultimopost.Id} | {ultimopost.Contenido}");

            //var posts = consultadePostSegunPalabraEspecigica("Madrid");
            //foreach (var post in posts)
            //{
            //    System.Console.WriteLine($"{post.Contenido}");

            //}

            //var posts = ListarPostContenidoRepetido();
            //foreach (var post in posts)
            //{
            //    System.Console.WriteLine($"{post.Contenido}");

            //}

            //var posts = ListarPostContenidoUnico();
            //foreach (var post in posts)
            //{
            //    System.Console.WriteLine($"{post.Contenido}");

            //}

            var dato = RankingDePostSegunFecha();
            foreach (var post in dato)
            {
                System.Console.WriteLine($"{post.Cantidad} | {post.Fecha}");
            }

            System.Console.ReadLine();
        }

        private static void RegistrarPosts()
        {
            var posts = new List<Post>()
            {
                new Post{Contenido = "Bayer", FechaRegistro = DateTime.Now },
                new Post{Contenido = "PSG", FechaRegistro = DateTime.Now },
                new Post{Contenido = "New Castle", FechaRegistro = DateTime.Now },

            };

            foreach (var post in posts)
            {
                _contexto.Posts.Add(post);
            }

            _contexto.SaveChanges();
        }
        public static Post obteberpost(int Id)
        {
            return _contexto.Posts.Find(Id);
        }
        public static Post UltimoPost()
        {
            var posts = _contexto.Posts.ToList();
            return posts.Last();
        }
        public static List<Post> consultadePostSegunPalabraEspecigica(string cadena)
        {
            var resultado = _contexto.Posts.Where(p => p.Contenido.Contains(cadena));
            return resultado.ToList();
        }

        public static List<Post> ListarPostContenidoRepetido()
        {
            var resultado = _contexto.Posts
                .GroupBy(p => p.Contenido)
                .Where(p => p.Count() > 1)
                .Select(p => p.FirstOrDefault());

            return resultado.ToList(); ;

        }
        public static List<Post> ListarPostContenidoUnico()
        {
            var resultado = _contexto.Posts
                .GroupBy(p => p.Contenido)
                .Where(p => p.Count() == 1)
                .Select(p => p.FirstOrDefault());

            return resultado.ToList(); ;

        }

        public static List<Ranking> RankingDePostSegunFecha()
        {
            var post = _contexto.Posts.ToList();
            var resultado = post
            .GroupBy(p => p.FechaRegistro.Date)
            .Select(g => new Ranking { Fecha = g.Key, Cantidad = g.Count() });
            return resultado.ToList();
        }

    }
}
