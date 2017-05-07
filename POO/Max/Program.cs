using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Max.SOLID;
using Max.SOLID.Nivel;
using Max.Clases;
using Max.Interfaces;

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


            Console.WriteLine("Nombre: \n" + persona1.Nombre);
            Console.WriteLine("Apellido:\n" + persona1.Apellido);
            Console.WriteLine("Fecha de Modificación: \n" + persona1.FechaModificacion);
            Console.WriteLine("Correo Electrónico: \n" + persona1.Correo);
            Console.WriteLine("Código Postal: \n" + persona1.CodigoPostal);
            Console.WriteLine("Dni: \n" + persona1.Dni);

            persona1.Caminar();
            Console.WriteLine();
            persona2.Natural();
            Console.WriteLine();

            Matematica multiplicar = new Matematica();
            Matematica suma = new Sumar();
            Matematica restar = new Restar();
            Matematica divicion = new Divicion();

            int salida1 = multiplicar.Calcular(5, 4);
            int salida2 = suma.Calcular(5, 4);
            int salida3 = restar.Calcular(5, 4);
            int salida4 = divicion.Calcular(10, 2);

            IOperaciones operacion = new Matematica();
            IEspecialidad curso = new Matematica();
            IEspecialidad docente = new Matematica();

            IDetalle detalle = new Clases.Modelo.Venta();

            Producto producto = new Producto();
            producto.Nombre = "giughdigh";
            producto.Precio = 8;
            producto.Cantiad = 5;

            Console.WriteLine("El producto fue guardado? =" + detalle.Guardar(producto));

            Console.WriteLine("La raíz de 9 es=" + operacion.Raiz(9));
            Console.WriteLine("El curso es= " + curso.Curso("Programación Orientada a Objetos"));
            Console.WriteLine("El nombre del Docente es= " + docente.Docente("Kevin"));

            Console.WriteLine(salida1);
            Console.WriteLine(salida2);
            Console.WriteLine(salida3);
            Console.WriteLine(salida4);
            Console.WriteLine("\n Potencia de 5=" + Matematica.Potencia(5));

            /*Clase Null Reference*/
            ClaseNullReference.AdminEquipo adm = ClaseNullReference.Equipo.GetAdmin();
            ClaseNullReference.AdminEquipo adm2 = ClaseNullReference.Equipo.GetAdmin();
            ClaseNullReference.AdminEquipo amd3 = ClaseNullReference.Equipo.GetAdmin();

            adm.procesar();
            adm2.procesar();
            amd3.procesar();

            //FIN


            ClaseDAtaMapper.Mapper mapeo = new ClaseDAtaMapper.Mapper();
            ClaseDAtaMapper.UsuarioDTO usrD = new ClaseDAtaMapper.UsuarioDTO();
            ClaseDAtaMapper.UsuarioNegocio usrN = new ClaseDAtaMapper.UsuarioNegocio();
            //Hardcode, setear manualmente
            usrD.id = 10;
            usrD.nombre = "Max";
            usrD.direccion = "Street";
            usrD.correo = "example@mail.com";

            usrN = mapeo.Mapear(usrD);

            Console.WriteLine("El nombre asignado: " + usrN.nombre);

            //Principios de programación SOLID
            ProcesarDatos procesar = new SOLID.ProcesarDatos();
            procesar.Procesar();


            Practicante practicante = new Practicante();
            Junior junior = new Junior();
            Senior senior = new Senior();

            try
            {
                Console.WriteLine("El nivel Practicante gana: " + practicante.ObtenerSalario());
                Console.WriteLine("El nivel Junior gana: " + junior.ObtenerSalario());
                Console.WriteLine("El nivel Senior gana: " + senior.ObtenerSalario());
            }
            catch (Exception ex)
            {
                ControlErrores.Imprimir(ex.Message);
            }
            

            
            Console.Read();
        }
    }
}
