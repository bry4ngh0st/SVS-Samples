using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SVS.Database.Implementaciones;
using SVS.Database.EF.JY;
using MySql.Data.Entity;
using SVS.Database.EF.JY.Entidades;

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
            var database = new DatabaseContext();
            
            
            var post = new Post();
            var resultado = database.ListaPost.Add(post);
            post.id = 1;
            post.Comentario = "Framework";
            post.FechaModificacion = DateTime.Now;
            post.FechaRegistro =DateTime.Now;
            //database.ListaPost(resultado);
                Assert.IsTrue(database.ListaPost.Count()>1);
                
             
        }
    }
}
