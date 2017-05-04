using System;

namespace POO.Interfaces.Implementation
{
    public class SqlServerDb : IDatabase
    {
        public void Delete()
        {
            Console.WriteLine("Deleting data by SQL Server");

            throw new NotImplementedException();
        }

        public void Save()
        {
            Console.WriteLine("Saving data by SQL Server");

            throw new NotImplementedException();
        }

        public void Update()
        {
            Console.WriteLine("Updating data by SQL Server");

            throw new NotImplementedException();
        }
    }
}
