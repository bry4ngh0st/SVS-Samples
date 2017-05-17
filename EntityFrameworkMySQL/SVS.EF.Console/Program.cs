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

        public static void Main(string[] args)
        {
            //RegistrarPosts();
            //System.Console.WriteLine("Posts agregados correctamente");
            /*
            var posts = _contexto.Posts;

            foreach (var post in posts)
            {
                System.Console.WriteLine($"{post.Id} | {post.Contenido}");
            }
            */
            /*
            System.Console.WriteLine("Ingrese El id del post a buscar :");
            int Parametro = int.Parse(System.Console.ReadLine());
            var postPorId = ObtenerPostPorId(Parametro);
            System.Console.WriteLine(string.Concat(postPorId.Id,"  ",postPorId.Contenido));
            */
            /*
            var post = ObtenerUltimoPost();
            System.Console.WriteLine(string.Concat(post.Id, "  ", post.Contenido));
            */
            var posts = BuscarPorPalabraEspecifica("1");

            foreach (var post in posts)
            {
                System.Console.WriteLine($"{post.Id} | {post.Contenido}");
            }

            System.Console.ReadLine();
            
        }

        public static List<Post> ListarPorContenidoRepetido(string cadena)
        {
            var resultado = _contexto.Posts.Where(p => p.Contenido.Contains(cadena));
            return resultado.ToList();
        }

        public static List<Post> BuscarPorPalabraEspecifica(string cadena)
        {
            var resultado = _contexto.Posts.Where(p => p.Contenido.Contains(cadena));
            return resultado.ToList();
        }

        public static Post ObtenerUltimoPost()
        {
            var lista = _contexto.Posts.ToList();
            var ultimo = lista.Last();
            return ultimo;

        }

        public static Post ObtenerPostPorId(int Id)
        {
            var post = _contexto.Posts.Find(Id);
            return post;

        }

        private static void RegistrarPosts()
        {
            var posts = new List<Post>()
            {
                new Post{Contenido = "Contenido del post 1", FechaRegistro = DateTime.Now },
                new Post{Contenido = "Contenido del post 2", FechaRegistro = DateTime.Now },
                new Post{Contenido = "Contenido del post 3", FechaRegistro = DateTime.Now },
                new Post{Contenido = "Contenido del post 4", FechaRegistro = DateTime.Now },
                new Post{Contenido = "Contenido del post 5", FechaRegistro = DateTime.Now },
                new Post{Contenido = "Contenido del post 6", FechaRegistro = DateTime.Now },
                new Post{Contenido = "Contenido del post 7", FechaRegistro = DateTime.Now },
                new Post{Contenido = "Contenido del post 8", FechaRegistro = DateTime.Now }
            };

            foreach (var post in posts)
            {
                _contexto.Posts.Add(post);
            }

            _contexto.SaveChanges();            
        }
    }
}
