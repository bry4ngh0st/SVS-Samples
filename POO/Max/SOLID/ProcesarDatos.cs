using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Http;

namespace Max.SOLID
{
    public class ProcesarDatos
    {
        public void Procesar()
        {
            try
            {
                Console.WriteLine("\n Preocesando el error ");

                throw new Exception("\nCreando un error forzado\n");
                
            }
            catch (Exception e)
            {
                Console.WriteLine("Error guardado");
                
                ControlErrores.Imprimir(e.Message); //Al ser un método estático ya no es necesario enlazar en el código
            }
            
        }
    }
}
