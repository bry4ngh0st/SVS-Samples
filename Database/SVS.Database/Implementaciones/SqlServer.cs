using System;
using System.Data.SqlClient;
using System.Configuration;

namespace SVS.Database.Implementaciones
{
    public class SqlServer : IDatabase
    {
        public bool Conectar()
        {
            try
            {
                var connectionString = ConfigurationManager.ConnectionStrings["dbprueba"].ConnectionString;

                using (var sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    sqlConnection.Close();
                }

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error en la conexion a la base de datos. {ex.Message}");
            }
        }
    }
}
