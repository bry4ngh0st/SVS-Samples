using NUnit.Framework;
using POO.Builders;

namespace POO.Tests
{
    [TestFixture]
    public class BuilderTests
    {
        [Test]
        public void ConstructorTest()
        {
            var usuario = new Usuario();
            var otroUsuario = new Usuario("123", "70652070", "Edson", "Castañeda");

            Assert.IsNull(usuario.Id);
            Assert.IsNotNull(otroUsuario.Id);
        }
    }
}
