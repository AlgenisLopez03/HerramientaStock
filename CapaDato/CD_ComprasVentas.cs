using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDato
{
    public class CD_ComprasVentas
    {
        private CD_Conexion conexion = new CD_Conexion();

        public void InsertarCompra(int idProducto, int cantidad, string Descripcion)
        {
            using (SqlConnection connection = conexion.AbrirConexion())
            {
                string insertQuery = "INSERT INTO Compras (IdProducto, Cantidad, Descripcion) VALUES (@IdProducto, @Cantidad, @Descripcion)";
                SqlCommand command = new SqlCommand(insertQuery, connection);
                command.Parameters.AddWithValue("@IdProducto", idProducto);
                command.Parameters.AddWithValue("@Cantidad", cantidad);
                command.Parameters.AddWithValue("@Descripcion", Descripcion);
                command.ExecuteNonQuery();
            }
        }

        public void InsertarVenta(int idProducto, int cantidad, string Descripcion)
        {
            using (SqlConnection connection = conexion.AbrirConexion())
            {
                string insertQuery = "INSERT INTO Ventas (IdProducto, Cantidad, Descripcion) VALUES (@IdProducto, @Cantidad, @Descripcion)";
                SqlCommand command = new SqlCommand(insertQuery, connection);
                command.Parameters.AddWithValue("@IdProducto", idProducto);
                command.Parameters.AddWithValue("@Cantidad", cantidad);
                command.Parameters.AddWithValue("@Descripcion", Descripcion);
                command.ExecuteNonQuery();
            }
        }
        public void Editar(int idProducto, string nuevoNombre, string nuevaDescripcion, string nuevaMarca, double nuevoPrecio, int nuevoStock)
        {
            using (SqlConnection connection = conexion.AbrirConexion())
            {
                string updateQuery = "UPDATE Productos SET Nombre = @NuevoNombre, Descripcion = @NuevaDescripcion, Marca = @NuevaMarca, Precio = @NuevoPrecio, Stock = @NuevoStock WHERE Id = @IdProducto";
                SqlCommand command = new SqlCommand(updateQuery, connection);
                command.Parameters.AddWithValue("@NuevoNombre", nuevoNombre);
                command.Parameters.AddWithValue("@NuevaDescripcion", nuevaDescripcion);
                command.Parameters.AddWithValue("@NuevaMarca", nuevaMarca);
                command.Parameters.AddWithValue("@NuevoPrecio", nuevoPrecio);
                command.Parameters.AddWithValue("@NuevoStock", nuevoStock);
                command.Parameters.AddWithValue("@IdProducto", idProducto);
                command.ExecuteNonQuery();
            }

            
        }

        public void ActualizarStockVenta(int idProducto, int cantidad)
        {
            using (SqlConnection connection = conexion.AbrirConexion())
            {
                string updateQuery = "UPDATE Productos SET Stock = Stock - @Cantidad WHERE Id = @IdProducto";
                SqlCommand command = new SqlCommand(updateQuery, connection);
                command.Parameters.AddWithValue("@Cantidad", cantidad);
                command.Parameters.AddWithValue("@IdProducto", idProducto);
                command.ExecuteNonQuery();
            }
        }
    }
}

