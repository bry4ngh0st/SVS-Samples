using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max
{
    class Program
    {
        static void Main(string[] args)
        {
            Clases.Persona persona1 = new Clases.Persona();
            Clases.PersonaNatural persona2 = new Clases.PersonaNatural();

            persona1.Nombre = "Max";
            persona1.Apellido = "Aguilar";
            persona1.FechaModificacion = DateTime.Now;

            Console.WriteLine(persona1.Nombre);
            Console.WriteLine(persona1.Apellido);
            Console.WriteLine(persona1.FechaModificacion);

            persona1.Caminar();
            Console.WriteLine();
            persona2.Natural();
            Console.WriteLine();

            Clases.Matematica multiplicar = new Clases.Matematica();
            Clases.Matematica suma = new Clases.Sumar();
            Clases.Matematica restar = new Clases.Restar();

            int salida1 = multiplicar.Calcular(5, 4);
            int salida2 = suma.Calcular(5, 4);
            int salida3 = restar.Calcular(5, 4);


            Console.WriteLine(salida1);
            Console.WriteLine(salida2);
            Console.WriteLine(salida3);

            Console.ReadLine();
        }
    }
}
