using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SVS.Database.Implementaciones;
using SVS.Database.EF.FD;
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

        /*[Test]
        public void PruebaEntityFramework()
        {
            DatabaseContext dbcontext =  new DatabaseContext();
            var post = new Post();
            post.IdPost = 1;
            post.comentario = "Abstraccion";
            post.fechaRegistro = DateTime.Now;
            post.fechaModificacion = DateTime.Now;
            //dbcontext.ListaPost.Add(post);
            var resultado = dbcontext.ListaPost.Add(post);
            Assert.IsTrue(resultado !=null);



        }*/
        [Test]
        public void PruebaEntityFramework()
        {
            ContextoBD bdcontext = new ContextoBD();
            var post = new Post();
           // post.IdPost = 1;
            post.comentario = "Abstraccion";
            post.fechaRegistro = DateTime.Now;
            post.fechaModificacion = DateTime.Now;
            //dbcontext.ListaPost.Add(post);
            var resultado = bdcontext.ListaPost.Add(post);
            Assert.IsTrue(resultado != null);
        }
    }

}
