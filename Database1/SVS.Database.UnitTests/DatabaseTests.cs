using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using SVS.Database.UnitTests;
using SVS.Database.EF.CE;
using SVS.Negocio.Entidades;
using SVS.Database.EF;

namespace SVS.Database.UnitTests
{
    [TestFixture]
    public class DatabaseTests
    {
        [Test]
        public void PruebaDeConeccionABaseDeDatos()
        {

        }
        [Test]
        public void PruebaEntityFreamework()
        {
            var dbContex = new ContextoBD();
            var post = new Post();
            post.id = 7;
            post.comentario = "Hola Mundo";
            post.fechaModificacion = DateTime.Now;
            post.fechaRegistro = DateTime.Now;

            var listapost= dbContex.listaPost.Add(post);

            Assert.IsTrue(listapost != null);

        }

    }
}
