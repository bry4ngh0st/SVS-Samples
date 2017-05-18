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

            //var post = ObtenerPostSegunId(9);
            //System.Console.WriteLine($"{post.Id} | {post.Contenido}");

            //var post = UltimoRegistrado();
            //System.Console.WriteLine($"{post.Id} | {post.Contenido}");

            //var post = PrimerRegistro();
            //System.Console.WriteLine($"{post.Id} | {post.Contenido}");

            //var posts = FiltrarPostsSegunPalabraClave("post");
            //foreach (var post in posts)
            //{
            //    System.Console.WriteLine($"{post.Id} | {post.Contenido}");
            //}

            //var posts = ListadePostsconContenidoRepetido();
            //foreach (var post in posts)
            //{
            //    System.Console.WriteLine($"{post.Id} | {post.Contenido}");
            //}

            //var posts = ListaPostContenidoUnico();
            //foreach (var post in posts)
            //{
            //    System.Console.WriteLine($"{post.Id} | {post.Contenido}");
            //}

            var posts = RankingdePostsporFecha();

            foreach (var post in posts)
            {
                System.Console.WriteLine($"{post.fecha} | {post.cantidad}");
            }

            //var fecha = Convert.ToDateTime('2017-05-17 11:45:09').Date();
            //var posts = ListadePostsRegistradosenFechaEspecifica(fecha);
            //foreach (var post in posts)
            //{
            //    System.Console.WriteLine($"{post.Id} | {post.Contenido}");
            //}

            System.Console.ReadLine();
        }

        public static Post ObtenerPostSegunId(int id)
        {            
            return _contexto.Posts.Find(id);
        }

        public static Post UltimoRegistrado()
        {
            var posts = _contexto.Posts.ToList();
            return posts.Last();
        }
        public static Post PrimerRegistro()
        {
            return _contexto.Posts.First();
        }
        public static List<Post> FiltrarPostsSegunPalabraClave(string palabra)
        {
            var resultado = _contexto.Posts.Where(p => p.Contenido.Contains(palabra));
            return resultado.ToList();
        }
        public static List<Post> ListadePostsconContenidoRepetido()
        {
            var resultado1 = _contexto.Posts
                .GroupBy(p => p.Contenido)
                .Where(p => p.Count() > 1)
                .Select(p => p.FirstOrDefault());         // Select first person from the grouping - they all are identical
            return resultado1.ToList();
        }
        public static List<Post> ListaPostContenidoUnico()
        {
            var resultado1 = _contexto.Posts
                .GroupBy(p => p.Contenido)
                .Where(p => p.Count() == 1)
                .Select(p => p.FirstOrDefault());
            return resultado1.ToList();
        }

        public static List<Ranking> RankingdePostsporFecha()
        {
            var posts = _contexto.Posts.ToList();

            var resultado = posts
                .GroupBy(p => p.FechaRegistro.Date)
                .Select(p => new Ranking { fecha = p.Key, cantidad = p.Count()});         // Select first person from the grouping - they all are identical

            return resultado.ToList();
        }


        public static List<Post> ListadePostsRegistradosenFechaEspecifica(DateTime fecha)
        {
            var resultado1 = _contexto.Posts.Where(p => p.FechaRegistro == fecha);
            return resultado1.ToList();
        }

        //public static List<Post> ListadePostspoRango(DateTime fecha1, DateTime fecha2)
        //{
        //    var resultado1 = _contexto.Posts.Where(p => p.FechaRegistro
        //    return resultado1.ToList();
        //}
        public static List<Post> ListaPostsModificados()
        {
            var resultado1 = _contexto.Posts.Where(p => !p.FechaModificacion.Date.Equals(p.FechaRegistro));
            return resultado1.ToList();

        }
        private static void RegistrarPosts()
        {
            var posts = new List<Post>()
            {
                new Post{Contenido = "Abstraccion", FechaRegistro = DateTime.Now },
                new Post{Contenido = "Polimorfismo", FechaRegistro = DateTime.Now },
                new Post{Contenido = "Base de Datos", FechaRegistro = DateTime.Now, FechaModificacion = DateTime.Now },
                new Post{Contenido = "BD II", FechaRegistro = DateTime.Now },
                new Post{Contenido = "IA", FechaRegistro = DateTime.Now , FechaModificacion = DateTime.Now},
                new Post{Contenido = "IA II", FechaRegistro = DateTime.Now },
                new Post{Contenido = "ADSI", FechaRegistro = DateTime.Now },
                new Post{Contenido = "ADSI II", FechaRegistro = DateTime.Now, FechaModificacion = DateTime.Now }
            };

            foreach (var post in posts)
            {
                _contexto.Posts.Add(post);
            }

            _contexto.SaveChanges();            
        }
    }
}
