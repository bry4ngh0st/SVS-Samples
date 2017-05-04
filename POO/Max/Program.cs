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
            persona1.Dni = "123456789";
            persona1.Correo = "zZ30.MaxZz@gmail.com";
            persona1.CodigoPostal = 051003;
        

            Console.WriteLine("Nombre: \n"+persona1.Nombre);
            Console.WriteLine("Apellido:\n"+persona1.Apellido);
            Console.WriteLine("Fecha de Modificación: \n"+persona1.FechaModificacion);
            Console.WriteLine("Correo Electrónico: \n"+persona1.Correo);
            Console.WriteLine("Código Postal: \n"+persona1.CodigoPostal);
            Console.WriteLine("Dni: \n"+persona1.Dni);

            persona1.Caminar();
            Console.WriteLine();
            persona2.Natural();
            Console.WriteLine();

            Clases.Matematica multiplicar = new Clases.Matematica();
            Clases.Matematica suma = new Clases.Sumar();
            Clases.Matematica restar = new Clases.Restar();
            Clases.Matematica divicion = new Clases.Divicion();

            int salida1 = multiplicar.Calcular(5, 4);
            int salida2 = suma.Calcular(5, 4);
            int salida3 = restar.Calcular(5, 4);
            int salida4 = divicion.Calcular(10, 2);

            Interfaces.IOperaciones operacion = new Clases.Matematica();
            Interfaces.IEspecialidad curso = new Clases.Matematica();

            Console.WriteLine("La raíz de 9 es=" + operacion.Raiz(9));
            Console.WriteLine("El curso es= " + curso.Curso("Programación Orientada a Objetos"));
 
            Console.WriteLine(salida1);
            Console.WriteLine(salida2);
            Console.WriteLine(salida3);
            Console.WriteLine(salida4);
            Console.WriteLine("\n Potencia de 5="+Clases.Matematica.Potencia(5));

            Console.ReadLine();
        }
    }
}
