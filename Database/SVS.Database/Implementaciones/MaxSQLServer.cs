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
                string ruta = ConfigurationManager.ConnectionStrings["prueba"].ConnectionString;
                SqlConnection conexion = new SqlConnection(ruta);
                conexion.Open();
                Console.WriteLine("Conexion establecida:"+ conexion);
                conexion.Close();
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
