using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Configuration;
using System.Data.SqlClient;
using System;

namespace SVS.Database.Implementaciones
{
    class EveSQLServer: IDatabase
    {
        public bool Conectar()
        {
            try
            {
                var conexionString = ConfigurationManager.ConnectionStrings["dbprueba"].ConnectionString;
                using (var sqlConnection = new SqlConnection(conexionString))
                {
                    sqlConnection.Open();
                    sqlConnection.Close();
                }

                return true;
            }
            catch(Exception ex)
            {
                throw new Exception($"Error en la conexion a la base de datos. {ex.Message}");
            }
        }
    }
}
