using System;

namespace POO.Abstract
{
    public class ClaseHija : ClaseAbstracta
    {
        public override void MetodoAbstracto()
        {
            Console.WriteLine("Implementando un metodo abstracto heredado");

            throw new NotImplementedException();
        }
    }
}
