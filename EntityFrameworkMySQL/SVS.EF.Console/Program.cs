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

            //var posts = _contexto.Posts;

            //foreach (var post in posts)
            //{
            //    System.Console.WriteLine($"{post.Id} | {post.Contenido}");
            //}

            //1 consulta
            //var id = 2;
            //var consulta = ObtenerPostSegunId(id);
            //System.Console.WriteLine($"{consulta.Id} | {consulta.Contenido}");

            //2 consulta
            //var ultimo = UltimoPostRegistrado();
            //System.Console.WriteLine($"{ultimo.Contenido} | {ultimo.FechaRegistro}");

            //3 consulta
            //var primer = PrimerPostRegistrado();
            //System.Console.WriteLine($"{primer.Contenido} | {primer.FechaRegistro}");
            
            //4 consulta
            //var palabra = "del";
            //var posts = ListaPostsSegunPalabraEspecifica(palabra);
            //foreach (var post in posts)
            //{
            //    System.Console.WriteLine($"{post.Id} | {post.Contenido}");
            //}

            //5 consulta
            //var repetidos = ListaPostsContenidoRepetido();

            //foreach (var repetido in repetidos)
            //{
            //    System.Console.WriteLine($"{repetido.Id} | {repetido.Contenido}");
            //}

            //6 consulta
            //var unicos = ListaPostsContenidoUnico();

            //foreach (var unico in unicos)
            //{
            //    System.Console.WriteLine($"{unico.Id} | {unico.Contenido}");
            //}

            //7 consulta
            //DateTime fecha = new DateTime(2017, 05, 14, 00, 00, 00);
            //var posts = ListaPostsFechaEspecifica(fecha);
            //foreach (var post in posts)
            //{
            //    System.Console.WriteLine($"{post.Id} | {post.Contenido} | {post.FechaRegistro}");
            //}

            //8 consulta
            //DateTime iniciofecha = new DateTime(2017, 05, 15, 00, 00, 00);
            //DateTime finfecha = new DateTime(2017, 05, 16, 00, 00, 00);
            //var posts = ListaPostsRangoFecha(iniciofecha, finfecha);
            //foreach (var post in posts)
            //{
            //    System.Console.WriteLine($"{post.Id} | {post.Contenido} | {post.FechaRegistro}");
            //}

            //9 consulta
            //var rankings = ListaPostsPorRanking();
            //foreach (var ranking in rankings)
            //{
            //    System.Console.WriteLine($"{ranking.Fecha} | {ranking.Cantidad}");
            //}

            //10 consulta
            //var posts = ListaPostModificados();
            //foreach (var post in posts)
            //{
            //    System.Console.WriteLine($"{post.Contenido} | {post.FechaRegistro} | {post.FechaModificacion}");
            //}

            //11 consulta 
            //var posts = ListaPostsNoModificados();
            //foreach (var post in posts)
            //{
            //    System.Console.WriteLine($"{post.Contenido} | {post.FechaRegistro} | {post.FechaModificacion}");
            //}

            System.Console.ReadLine();
        }

        public static Post ObtenerPostSegunId(int id)
        {
            var post = _contexto.Posts.Find(id);
            return post;
        }

        public static Post UltimoPostRegistrado()
        {
            var posts = _contexto.Posts.ToList();
            var ultimo = posts.Last();
            return ultimo;
        }

        public static Post PrimerPostRegistrado()
        {
            var post = _contexto.Posts.First();
            return post;
        }

        public static List<Post> ListaPostsSegunPalabraEspecifica(string palabra)
        {
            var resultado = _contexto.Posts.Where(p=> p.Contenido.Contains(palabra));
            return resultado.ToList();
        }

        public static List<Post> ListaPostsContenidoRepetido()
        {
            var repetido =  _contexto.Posts.GroupBy(p => p.Contenido)
                                            .Where(g => g.Count() > 1)
                                            .Select(g => g.FirstOrDefault());
            return repetido.ToList();
         
        }

        public static List<Post> ListaPostsContenidoUnico()
        {
            var repetido = _contexto.Posts
                            .GroupBy(p => p.Contenido)
                            .Where(g => g.Count() < 2)
                            .Select(g => g.FirstOrDefault());
            return repetido.ToList();
        }

        public static List<Post> ListaPostsFechaEspecifica(DateTime fecha)
        {

            var lista = _contexto.Posts.Where(p => p.FechaRegistro.Equals(fecha));

            return lista.ToList();
        }

        public static List<Post> ListaPostsRangoFecha(DateTime iniciofecha, DateTime finfecha)
        {
            var rango = _contexto.Posts.Where(p => p.FechaRegistro.Date >= iniciofecha && p.FechaRegistro.Date <= finfecha);
            return rango.ToList();
        }
        public static List<Ranking> ListaPostsPorRanking()
        {
            var posts = _contexto.Posts.ToList();
            var ranking = posts
                            .GroupBy(p => p.FechaRegistro.Date)
                            .Select(g => new Ranking { Fecha = g.Key, Cantidad = g.Count() })
                            .OrderByDescending(g => g.Cantidad);
            return ranking.ToList();
        }
        public static List<Post> ListaPostModificados()
        {
            var modificados = _contexto.Posts.Where(p => !p.FechaRegistro.Equals(p.FechaModificacion));
            return modificados.ToList();
        }

        public static List<Post> ListaPostsNoModificados()
        {
            var nulo = _contexto.Posts.Where(p => p.FechaModificacion == null);
            return nulo.ToList();
        }

        private static void RegistrarPosts()
        {
            var posts = new List<Post>()
            {
                new Post{Contenido = "Comentario", FechaRegistro = DateTime.Now },
                new Post{Contenido = "Comentario", FechaRegistro = DateTime.Now },
                new Post{Contenido = "Comentario", FechaRegistro = DateTime.Now },
                new Post{Contenido = "Comentario", FechaRegistro = DateTime.Now },
                new Post{Contenido = "Comentario", FechaRegistro = DateTime.Now },
                new Post{Contenido = "Comentario", FechaRegistro = DateTime.Now },
            };

            foreach (var post in posts)
            {
                _contexto.Posts.Add(post);
            }

            _contexto.SaveChanges();            
        }
    }
}
