using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Max4.Clases;
using Max4.Interfaz;

namespace Max4
{
    class Program
    {
        static void Main(string[] args)
        {
            IDatabase sql = new SQLServer();
            IDatabase mysql = new MySQL();

            Manager.Registrar(sql);
            Manager.Registrar(mysql);

            Console.Read();
        }
    }
}
