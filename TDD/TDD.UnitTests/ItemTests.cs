using NUnit.Framework;
using System;
using TDD.Business;

namespace TDD.UnitTests
{
    [TestFixture]
    public class ItemTests
    {
        [TestCase(-1)]
        [TestCase(0)]
        public void ValidarItem_IdInvalido_ThrowException(int id)
        {
            var item = new Item()
            {
                Id = id,
                Nombre = "Name",
                Precio = 100,
                Lugar = new Lugar()
            };

            Assert.Throws<Exception>(() => item.Validar());
        }

        [TestCase("")]
        [TestCase(null)]
        public void ValidarItem_NombreInvalido_ThrowException(string nombre)
        {
            var item = new Item()
            {
                Id = 1,
                Nombre = nombre,
                Precio = 100,
                Lugar = new Lugar()
            };

            Assert.Throws<Exception>(() => item.Validar());
        }

        [TestCase(-100)]
        [TestCase(0)]
        public void ValidarItem_PrecioInvalido_ThrowException(decimal precio)
        {
            var item = new Item()
            {
                Id = 1,
                Nombre = "nombre",
                Precio = precio,
                Lugar = new Lugar()
            };

            Assert.Throws<Exception>(() => item.Validar());
        }

        [Test]
        public void ValidarItem_LugarInvalido_ThrowException()
        {
            var item = new Item()
            {
                Id = 1,
                Nombre = "nombre",
                Precio = 100,
                Lugar = null
            };

            Assert.Throws<Exception>(() => item.Validar());
        }
        
        [Test]
        public void ValidarItem_DatosCorrectos_ReturnTrue()
        {
            var item = new Item()
            {
                Id = 1,
                Nombre = "nombre",
                Precio = 100,
                Lugar = new Lugar()
                {
                    Id = 1,
                    Nombre = "Abancay"
                }
            };

            Assert.IsTrue(item.Validar());
        }
    }
}
