using System;


namespace SVS.Database.Implementaciones
{
    public class ArthurSQLServer : IDatabase
    {
        public bool Conectar()
        {
            System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
            conn.ConnectionString = "integrated security=SSPI;data source=;" + "persist security info=False;initial catalog=northwind";
            try
            {
                conn.Open();
                return true;
                // Insert code to process data.
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
