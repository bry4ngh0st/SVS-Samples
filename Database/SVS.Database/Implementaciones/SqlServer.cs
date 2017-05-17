using System;
using System.Data.SqlClient;
using System.Configuration;
using MySql.Data.MySqlClient;
namespace SVS.Database.Implementaciones
{
    public class SqlServer : IDatabase
    {
        public bool Conectar()
        {
            try
            {
                //var connectionString = ConfigurationManager.ConnectionStrings["dbprueba"].ConnectionString;
                var connectionString = ConfigurationManager.ConnectionStrings["prueba"].ConnectionString;
                //string conexion = ;
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
