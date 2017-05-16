using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SVS.Database.Implementaciones;

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
    }
}
