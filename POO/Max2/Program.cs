using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Max2.Clases;

namespace Max2
{
    class Program
    {
        static void Main(string[] args)
        {
            Junior junior = new Junior();
            Practicante practicante = new Practicante();
            Senior senior = new Senior();

            junior.Nombre = "Max";
            practicante.Nombre = "Yordy";
            senior.Nombre = "Arthur";


            Console.WriteLine("El salario de " + junior.Nombre + " es: " + junior.ObtenerSalario());
            Console.WriteLine("El salario de " + practicante.Nombre + " es: " + practicante.ObtenerSalario());
            Console.WriteLine("El salario de " + senior.Nombre + " es: " + senior.ObtenerSalario());

            Console.WriteLine(junior.Nombre + " tiene un desuento de: " + junior.ObtenerDescuento());
            Console.WriteLine(senior.Nombre + " tiene un desuento de:  " + senior.ObtenerDescuento());
            Console.Read();
        }
    }
}
