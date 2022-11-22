using System;
using System.Data.SqlClient;
using System.Configuration;

namespace SAPS.Util
{
    public class Connection
    {
        private SqlConnection sqlConn;

        public SqlConnection openConnection()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["AgroMaisDB"].ConnectionString;
                SqlConnection sqlConn = new SqlConnection(connectionString);
                sqlConn.Open();
                this.sqlConn = sqlConn;
            }
            catch (Exception) { throw new Exception("Não foi possível acessar a base de dados do sistema."); }
            return sqlConn;
        }
        public  SqlConnection getConnection()
        {
            try
            { 
                string connectionString = ConfigurationManager.ConnectionStrings["AgroMaisDB"].ConnectionString;
                SqlConnection sqlConn = new SqlConnection(connectionString);
                sqlConn.Open();
                this.sqlConn = sqlConn;
            }
            catch (Exception) { throw new Exception("Não foi possível acessar a base de dados do sistema."); }
            return sqlConn;
        }
        public void closeConnection()
        {
            if (this.sqlConn != null) { sqlConn.Close(); }
        }
    }
}