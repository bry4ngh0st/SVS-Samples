using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Max.SOLID
{
    public class ControlErrores
    {
        public static void Imprimir(string error)
        {
            System.IO.File.WriteAllText(@"C:\Users\max\Desktop\Error.txt", error);
        }
    }
}
