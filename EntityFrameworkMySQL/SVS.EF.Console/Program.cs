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

            //var idPos = 3;
            //var datooptenido= ObtenerPostSegunID(idPos);           

            //var posts = _contexto.Posts;
            //System.Console.WriteLine("obtener id post");
            //foreach (var post in posts)
            //{
            //    System.Console.WriteLine($"{post.Id} | {post.Contenido}");
            //}

            //var mostrar= UltimoPostRegistrado();
            // System.Console.WriteLine($"{mostrar.Id},{mostrar.Contenido}");  
            var buscarPalabra = "mvc";
            var listaPosts = ContenidoSegunPalabraEspecifica(buscarPalabra);
            foreach (var listaPost in listaPosts )
            {
                System.Console.WriteLine($"{listaPost.Id},{listaPost.Contenido}");
            }

            System.Console.ReadLine();
        }
        static public Post UltimoPostRegistrado()
        {
            var ultimo=_contexto.Posts.ToList();
            var post = ultimo.Last();
            return post;
        }
        static public Post ObtenerPostSegunID(int id)
        {
            var posID=_contexto.Posts.Find(id);
            return posID;
        }
        static public List<Post> ContenidoSegunPalabraEspecifica(string palabra)
        {
            var posts = _contexto.Posts.Where(p => p.Contenido.Contains(palabra));
            return posts.ToList();
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
                new Post{Contenido = "Contenido del post 8", FechaRegistro = DateTime.Now },
                new Post{Contenido = "Contenido del post 9", FechaRegistro = DateTime.Now }
            };

            foreach (var post in posts)
            {
                _contexto.Posts.Add(post);
            }

            _contexto.SaveChanges();
        }
    }
}
