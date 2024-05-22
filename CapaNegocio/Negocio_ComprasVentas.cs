using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using CapaDato;


namespace CapaNegocio
{
    public class Negocio_ComprasVentas
    {
        private CD_ComprasVentas cdComprasVentas = new CD_ComprasVentas();


        public void RealizarVenta(int idProducto, int cantidad, string Descripcion)
        {
            cdComprasVentas.InsertarVenta(idProducto, cantidad,Descripcion);
        }
        public void ModificarProducto(int idProducto, string nuevoNombre, double nuevoPrecio, int nuevoStock)
        {
            cdComprasVentas.Editar(idProducto, nuevoNombre, "", "", nuevoPrecio, nuevoStock);
        }
        public void RealizarVenta(int idProducto, int cantidad)
        {
            cdComprasVentas.ActualizarStockVenta(idProducto, cantidad);
        }

        public void ActualizarStockVenta(int idProducto, int cantidad)
        {
            using (SqlConnection connection = new SqlConnection("\"Server=ALGENIS_LOPEZ\\\\SQLEXPRESS;DataBase=Practica;Integrated Security=true\""))
            {
                connection.Open();
                string updateQuery = "UPDATE Productos SET Stock = Stock - @Cantidad WHERE Id = @IdProducto";
                SqlCommand command = new SqlCommand(updateQuery, connection);
                command.Parameters.AddWithValue("@Cantidad", cantidad);
                command.Parameters.AddWithValue("@IdProducto", idProducto);
                command.ExecuteNonQuery();
            }
        }


    }
}
