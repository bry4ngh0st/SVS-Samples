using SVS.EF.Entidades;
using System;
using System.Collections;
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

            var Fecha = DateTime.Today;

            System.Console.WriteLine("=======>Lista de post en una fecha específica" + Fecha);
            
            listaPost = ListarPostEnFechaEspecifica(Fecha);

            foreach (var item in listaPost)
            {
                System.Console.WriteLine(item.Contenido);
            }

            System.Console.WriteLine("=======>Lista de post en una fecha específica" + Fecha);

            System.Console.WriteLine("=======>Lista de post modificados");

            listaPost = ListarPostModificados();

            foreach (var item in listaPost)
            {
                System.Console.WriteLine(item.Contenido);
            }

            System.Console.WriteLine("=======>Lista de post modificados");

            System.Console.WriteLine("=======>Lista de post Repetidos");

            var listaPostRepetidos = ObtenerPostSegunContenidoRepetido();

            foreach (var item in listaPost)
            {
                System.Console.WriteLine(item.Contenido);
            }

            System.Console.WriteLine("=======>Lista de post Repetidos");

            System.Console.WriteLine("=======>Ranking de Post");

            var rankingPost = RankingPost();

            System.Console.WriteLine("hasta aca");
            foreach (var ps in rankingPost)
            {
                System.Console.WriteLine(ps.);
            }

            System.Console.WriteLine("=======>Ranking de Post");


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
            
            var posts = _contexto.Posts.Where(p => p.Contenido.Contains(valor)).ToList();
            return posts;
        }
        public static List<Post> ObtenerPostSegunContenidoRepetido()
        {
            var duplicados = _contexto.Posts.GroupBy(x => x.Contenido)   
                .Where(g => g.Count() > 1)   
                .Select(g => g.FirstOrDefault());


            List<Post> listaDuplicados = new List<Post>();

            var grpDupes = from f in _contexto.Posts
                           group f by f.Contenido into grps
                           where grps.Count() > 1
                           select grps;

            foreach (var item in grpDupes)
            {
                foreach (var thing in item)
                {
                    listaDuplicados.Add(thing);
                }
            }
            
            return listaDuplicados.ToList();
        }

        public static List<Post> ObtenerPostSegunContenidoUnico()
        {
            var duplicados = _contexto.Posts.GroupBy(x => x.Id).
                Select(y => y.First()).Distinct();

            return duplicados.ToList();
        }

        public static ArrayList[][] RankingPost()
        {
            var rankingPorFechas = _contexto.Posts.
                GroupBy(f => f.FechaRegistro).
                Select(y => new {
                    Fecha = y.Key,
                    Cantidad = y.Count(),
                });

            ArrayList[][] nuevoRanking = new ArrayList[][];

            foreach (var post in rankingPorFechas)
            {
                    nuevoRanking.Add(post);
                System.Console.WriteLine(post.Fecha);
                
            }
            return nuevoRanking;
        }

        public static List<Post> ListarPostEnFechaEspecifica(DateTime data)
        {
            return _contexto.Posts.Where(p => p.FechaRegistro==data).ToList();
        }

        public static List<Post> ListarPostModificados()
        {
            var listPosts = _contexto.Posts.Where(p => !p.FechaModificacion.Equals(p.FechaRegistro));
            var listPosts2 = _contexto.Posts.Where(p => p.FechaModificacion != p.FechaRegistro);
            return listPosts2.ToList();
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
