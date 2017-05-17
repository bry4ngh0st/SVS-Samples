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

            var posts = _contexto.Posts;

            foreach (var post in posts)
            {
                System.Console.WriteLine($"{post.Id} | {post.Contenido}");
            }

            System.Console.ReadLine();
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
