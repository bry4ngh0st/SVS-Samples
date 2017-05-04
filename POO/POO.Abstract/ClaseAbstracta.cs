using System;

namespace POO.Abstract
{
    public abstract class ClaseAbstracta
    {
        public string Propiedad { get; set; }

        public void MetodoImplementado()
        {
            Console.WriteLine("Usando el método implementado en una clase abstracta");
        }

        public abstract void MetodoAbstracto();
    }
}
