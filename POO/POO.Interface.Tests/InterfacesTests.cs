using NUnit.Framework;
using POO.Interfaces;
using POO.Interfaces.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Interface.Tests
{
    [TestFixture]
    public class InterfacesTests
    {
        [Test]
        public void PruebaDeManejoDeInterfaces()
        {
            IDatabase sqlServer = new SqlServerDb();
            IDatabase mySql = new MySqlDb();

            sqlServer.Save();
            mySql.Save();
        }
    }
}
