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
            var item = new Item
            {
                Id = 01,
                Nombre = "",
                Precio = 15m,
                Lugar = new Lugar()
            };
            
            var validar =  item.EsValido();

            Assert.IsTrue(validar);
        }
    }  
}
