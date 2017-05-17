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
                var cadenaconexion = ConfigurationManager.ConnectionStrings["prueba"].ConnectionString;
                 var conexion= new MySqlConnection(cadenaconexion);
                {
                    conexion.Open();
                    conexion.Close();
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
