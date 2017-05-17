using NUnit.Framework;
using System;
using SVS.Database.Implementaciones;
using SVS.Database.EF;
using SVS.Negocio.Entidades;

namespace SVS.Database.UnitTests
{
    [TestFixture]
    public class DatabaseTests
    {
        [Test]
        public void PruebaDeConeccionABaseDeDatos()
        {
            var baseDatos = new SqlServer();
            var resultado = baseDatos.Conectar();

            Assert.IsTrue(resultado);
        }
        [Test]
        public void PruebaEntityFramework()
        {
            //DatabaseContext dbContext = new DatabaseContext();

            //Post pos = new Post();

            //pos.Contenido = "Contenido del post";
            //pos.Id = 0;
            //pos.FechaRegistro = DateTime.Now;
            //pos.FechaModificacion = DateTime.Now;

            //dbContext.ListaPosts.Add(pos);
            //dbContext.SaveChanges();

            //Assert.IsTrue(dbContext.ListaPosts.Count() > 1);
        }

        [Test]
        public void PruebaEntityFrameworkEF()
        {
            using (ContextoBD contexto = new ContextoBD())
            {

                var post = new Post()
                {
                    Contenido = "contenido",
                    FechaRegistro = DateTime.Now,
                    FechaModificacion = DateTime.Now
                };

                contexto.Posts.Add(post);

                contexto.SaveChanges();
            }

            //var posts = dbContext.ListaPosts.ToList();

            //pos.Contenido = "Contenido del post";
            ////pos.Id = 0;
            //pos.FechaRegistro = DateTime.Now;
            //pos.FechaModificacion = DateTime.Now;

            //dbContext.ListaPosts.Add(pos);
            //dbContext.SaveChanges();

            //Assert.IsTrue(dbContext.ListaPosts.Count() > 1);
        }
    }
}
