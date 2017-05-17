using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SVS.Database.Implementaciones;
using SVS.Database.EF.MA;
using SVS.Database.EF.MA.Entities;

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
            DatabaseContext dbContext = new DatabaseContext();

            Post pos = new Post();

            pos.Contenido = "Contenidod del post";
            pos.Id = 0;
            pos.FechaRegistro = DateTime.Now;
            pos.FechaModificacion = DateTime.Now;

            dbContext.ListaPosts.Add(pos);
            dbContext.SaveChanges();

            Assert.IsTrue(dbContext.ListaPosts.Count() > 1);
        }
    }
}
