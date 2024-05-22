using System.Data.SqlClient;
using System.Data;

namespace CapaDato
{
    public class CD_Conexion
    {
        private readonly string connectionString;

        public CD_Conexion()
        {
            connectionString = "Server=ALGENISLOPEZ\\SQLEXPRESS;Database=Practica;Integrated Security=true";
        }

        protected SqlConnection GetSqlConnection()
        {
            return new SqlConnection(connectionString);
        }

        public SqlConnection AbrirConexion()
        {
            SqlConnection connection = GetSqlConnection();
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            return connection;
        }

        public SqlConnection CerrarConexion(SqlConnection connection)
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
            return connection;
        }
    }
}
