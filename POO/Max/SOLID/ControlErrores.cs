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
            if (File.Exists(@"C:\Users\max\Desktop\Error.txt"))
            {
                StreamWriter writer = File.AppendText(@"C:\Users\max\Desktop\Error.txt");
                writer.WriteLine(error);
                writer.Close();
            }
            else
            {
                System.IO.File.WriteAllText(@"C:\Users\max\Desktop\Error.txt", error);
            }
            
        }
    }
}
