using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max.Clases
{
    class Persona:Audit
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        private void Saltar() //No se va a heredar en otras clases ni en objetos
        {
            Console.WriteLine();
            Console.Write(" Estoy Saltando ");
        }
        protected void Correr()//Sí se va a poder a heredar en clases y objetos
        {
            Console.Write("Estoy Corriendo");
        }
        public void Caminar()
        {
            Correr();
            Console.Write(" Caminar");
            Saltar();
        }
    }
}
