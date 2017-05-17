using System;
using System.Data.SqlClient;
namespace SVS.Database
{
    public class SqlServer:IDatabase
    {
        public bool Conectar()
        {
            try
            {
                var connectionString = ConfigurationManager.ConnectionStrings["prueba"].ConnectionString;
                
                using (var sqlConnection = new SqlConnection(connectionString))
                    
                {
                    sqlConnection.Open();
                    sqlConnection.Close();
                }
                return true;
            }
            catch (Exception ex) { throw new Exception($"Error en la conexion a la base de datos. {ex.Message}"); }
        }
    }
}
