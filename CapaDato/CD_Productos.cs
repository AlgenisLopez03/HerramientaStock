using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace CapaDato
{
    public class CD_Productos
    {
        private CD_Conexion conexion = new CD_Conexion();
        private SqlConnection connection;

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public void ConsultarProductos()
        {
            using (connection = conexion.AbrirConexion())
            {
                string selectQuery = "SELECT * FROM Productos";
                SqlCommand command = new SqlCommand(selectQuery, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine($"ID: {reader["Id"]}, Nombre: {reader["Nombre"]}, Precio: {reader["Precio"]}");
                }

                reader.Close();
            }
            conexion.CerrarConexion(connection);
        }

        public DataTable Mostrar()
        {
            connection = conexion.AbrirConexion();
            comando.Connection = connection;
            comando.CommandText = "MostrarProductos";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion(connection);

            return tabla;
        }

        public void Insertar(string nombre, string desc, string marca, int precio, int stock)
        {
            connection = conexion.AbrirConexion();
            comando.Connection = connection;
            comando.CommandText = "InsetarProductos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@descrip", desc);
            comando.Parameters.AddWithValue("@Marca", marca);
            comando.Parameters.AddWithValue("@precio", precio);
            comando.Parameters.AddWithValue("@stock", stock);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
            conexion.CerrarConexion(connection);
        }

        public void Editar(string nombre, string desc, string marca, int precio, int stock, int id)
        {
            connection = conexion.AbrirConexion();
            comando.Connection = connection;
            comando.CommandText = "EditarProductos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@descrip", desc);
            comando.Parameters.AddWithValue("@Marca", marca);
            comando.Parameters.AddWithValue("@precio", precio);
            comando.Parameters.AddWithValue("@stock", stock);
            comando.Parameters.AddWithValue("@id", id);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
            conexion.CerrarConexion(connection);
        }

        public void Eliminar(int id)
        {
            connection = conexion.AbrirConexion();
            comando.Connection = connection;
            comando.CommandText = "EliminarProducto";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idpro", id);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
            conexion.CerrarConexion(connection);
        }
    }
}
