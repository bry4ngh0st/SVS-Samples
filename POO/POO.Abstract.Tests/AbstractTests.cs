using NUnit.Framework;

namespace POO.Abstract.Tests
{
    [TestFixture]
    public class AbstractTests
    {
        [Test]
        public void TestDeHerenciaUsandoClaseAbstracta()
        {
            ClaseAbstracta claseHija = new ClaseHija();

            // Acceso a un método implementado en la clase abstracta (padre)
            claseHija.MetodoImplementado();

            // Acceso a un método implementado en la clase hija
            claseHija.MetodoAbstracto();
        }
    }
}
