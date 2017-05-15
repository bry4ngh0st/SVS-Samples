using NUnit.Framework;
using TDD.Business;

namespace TDD.UnitTests
{
    [TestFixture]
    public class LugarTests
    {
        [Test]
        public void ValidarLugar_DatosValidos_ReturnTrue()
        {
            var lugar = new Lugar
            {
                Id = 1,
                Nombre = "Abancay"
            };

            Assert.IsTrue(lugar != null);
        }
    }
}
