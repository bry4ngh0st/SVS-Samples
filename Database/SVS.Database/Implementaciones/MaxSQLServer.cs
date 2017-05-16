using System;
using System.Data.SqlClient;
using System.Configuration;

namespace SVS.Database.Implementaciones
{
    public class MaxSQLServer : IDatabase
    {
        public bool Conectar()
        {
            try
            {
                string ruta = ConfigurationManager.ConnectionStrings["db_prueba"].ConnectionString;
                SqlConnection conexion = new SqlConnection(ruta);

                Console.WriteLine("Conexion establecida:"+ conexion);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en la conexión:"+ex.Message);
                return false;
            }
        }
    }
}
