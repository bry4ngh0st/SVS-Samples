using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max.Clases
{
    class PersonaNatural:Persona
    {
        public void Natural()
        {
            Correr();

            Console.Write(" Correr-Natural");

            Console.WriteLine();

            Caminar();

            Console.WriteLine(" Natural");

        }
    }
}
