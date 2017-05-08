using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max.SOLID
{
    public class Validador
    {
        public static void Validar(Desarrollador des)
        {
            try
            {
                if (string.IsNullOrEmpty(des.Nombre))
                {
                    throw new Exception(des.GetType().Name + " tiene un nombre nulo");
                }
            }
            catch (Exception ex)
            {

                ControlErrores.Imprimir(ex.Message);
                Console.WriteLine(des.GetType().Name +" tiene un nombre nulo");
            }
        }
    }
}
