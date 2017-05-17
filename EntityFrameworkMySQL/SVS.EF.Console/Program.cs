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
            System.Console.WriteLine("Leer post:");
            int idPost = Convert.ToInt32(System.Console.ReadLine());

            System.Console.WriteLine("=======>POST:"+idPost);
                 
            var postObtenido = ObtenerPostSegunID(idPost);

            System.Console.WriteLine(postObtenido.Contenido);

            System.Console.WriteLine("=======>POST");

            System.Console.WriteLine("=======>Último Post:");

            postObtenido = ObtenerUltimoPost();

            System.Console.WriteLine(postObtenido.FechaRegistro);

            System.Console.WriteLine("=======>Último Post||");

            System.Console.WriteLine("=======>Primer Post:");

            postObtenido = ObtenerPrimerPost();

            System.Console.WriteLine(postObtenido.FechaRegistro);

            System.Console.WriteLine("=======>Primer Post||");

            System.Console.Write("Ingrese una palabra clave:");
            var valor = Convert.ToString(System.Console.ReadLine()) ;
            System.Console.WriteLine("=======>Lista de post con contenido " + valor);
            
            var listaPost = ObtenerPostSegunContenido(valor);

            foreach (var item in listaPost)
            {
                System.Console.WriteLine(item.Contenido);
            }

            System.Console.WriteLine("=======>Lista de post con contenido " + valor);

            System.Console.ReadLine();
        }
        public static Post ObtenerPostSegunID(int id)
        {
            return _contexto.Posts.Find(id);
        }
        public static Post ObtenerUltimoPost()
        {
            var posts = _contexto.Posts.ToList();

            return posts.Last();
        }

        public static Post ObtenerPrimerPost()
        {
            var posts = _contexto.Posts.ToList();

            return posts.First();
        }
        public static List<Post> ObtenerPostSegunContenido(string valor)
        {
            
            var posts = _contexto.Posts.Where(p=>p.Contenido.Contains(valor)).ToList();
            return posts;
        }
        public static List<Post> ObtenerPostSegunContenidoRepetido()
        {
            var posts = _contexto.Posts.Where(p => p.Contenido.Contains("")).ToList();
            return posts;
        }
        //private static void RegistrarPosts()
        //{
        //    var posts = new List<Post>()
        //    {
        //        new Post{Contenido = "Contenido del post 1", FechaRegistro = DateTime.Now },
        //        new Post{Contenido = "Contenido del post 2", FechaRegistro = DateTime.Now },
        //        new Post{Contenido = "Contenido del post 3", FechaRegistro = DateTime.Now },
        //        new Post{Contenido = "Contenido del post 4", FechaRegistro = DateTime.Now },
        //        new Post{Contenido = "Contenido del post 5", FechaRegistro = DateTime.Now },
        //        new Post{Contenido = "Contenido del post 6", FechaRegistro = DateTime.Now },
        //        new Post{Contenido = "Contenido del post 7", FechaRegistro = DateTime.Now },
        //        new Post{Contenido = "Contenido del post 8", FechaRegistro = DateTime.Now }
        //    };

        //    foreach (var post in posts)
        //    {
        //        _contexto.Posts.Add(post);
        //    }

        //    _contexto.SaveChanges();            
        //}
    }
}
