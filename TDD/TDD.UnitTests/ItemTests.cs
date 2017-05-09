using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDD.Business;

namespace TDD.UnitTests
{
    [TestFixture]
    public class ItemTests
    {
        [Test]
        public void PruebaDeValidacion()
        {
            var item = new Item();
            item.Id = 01;
            item.Nombre = string.Empty;
            item.Precio = 12.6m;
            Lugar lugar = new Lugar();
            item.Lugar = lugar;

            var validar =  item.EsValido();

            Assert.IsTrue(validar);
        }
    }  
}
