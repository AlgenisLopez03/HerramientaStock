using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CapaPresentacion
{
    public partial class Ventas : Form
    {
         private Negocio_ComprasVentas negocioComprasVentas = new Negocio_ComprasVentas();
        private Label lblTotalPagar;

        public Ventas()
        {
            InitializeComponent();
            lblTotalPagar = new Label();
            CargarProductos();

        }

        private void CargarProductos()
        {

        }


        //string nombre = lblNombre.Text;
        //decimal precio = decimal.Parse(lblPrecio.Text);
        //int cantidad = int.Parse(txtCantidad.Text);
        //decimal subtotal = precio * cantidad;

        //dataGridView1.Rows.Add( nombre, precio, cantidad, subtotal);
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DataGridViewRow file = new DataGridViewRow();
            file.CreateCells(dataGridView1);

            file.Cells[0].Value = lblNombre.Text;
            file.Cells[1].Value = lblDescripcion.Text;
            file.Cells[2].Value = lblMarca.Text;
            file.Cells[3].Value = lblPrecio.Text;
            file.Cells[4].Value = txtCantidad.Text;

            int precio;
            int cantidad;

            if (int.TryParse(lblPrecio.Text.Trim(), out precio) && int.TryParse(txtCantidad.Text.Trim(), out cantidad))
            {
                int total = precio * cantidad;
                file.Cells[5].Value = total.ToString(); // Total en la columna "Total"
            }
            else
            {
                // Manejo del error de formato aquí, como mostrar un mensaje al usuario
                MessageBox.Show("Error en el formato de los valores numéricos.");
                return;
            }

            dataGridView1.Rows.Add(file);
            dataGridView1.Refresh(); // Actualiza el DataGridView

            lblNombre.Text = lblDescripcion.Text = lblMarca.Text =  lblPrecio.Text = txtCantidad.Text = "";


        }

        private void ActualizarTotal()
        {
           float total = 0;

             foreach (DataGridViewRow row in dataGridView1.Rows)
              {
                  if (row.Cells[5].Value != null && float.TryParse(row.Cells[5].Value.ToString(), out float subtotal))
                  {
                     total += subtotal;
                  }
              }

                lblTotalPagar.Text = total.ToString("C");
        }




        private void btnVender_Click(object sender, EventArgs e)
        {
            if (!float.TryParse(txtEfectivo.Text, out float efectivo))
            {
                MessageBox.Show("Ingrese una cantidad válida en efectivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            float totalPagar;
            if (!float.TryParse(lblTotalPagar.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out totalPagar))
            {
                MessageBox.Show("Error en el cálculo del total a pagar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            float devolucion = efectivo - totalPagar;

            lblDevolucion.Text = devolucion.ToString("C");
        }

        private void txtBuscarr_TextChanged(object sender, EventArgs e)
        {
            string textoBusqueda = txtBuscar.Text.Trim();

            
            Producto productoEncontrado = BuscarProductoPorNombre(textoBusqueda);

            if (productoEncontrado != null)
            {
                // Actualizar las etiquetas con los detalles del producto
                lblNombre.Text = productoEncontrado.Nombre;
                lblDescripcion.Text = productoEncontrado.Descripcion;
                lblMarca.Text = productoEncontrado.Marca;
                lblPrecio.Text = productoEncontrado.Precio.ToString("C"); 
            }
            else
            {
                // Limpiar las etiquetas si no se encuentra el producto
                lblNombre.Text = "-";
                lblDescripcion.Text = "-";
                lblMarca.Text = "-";
                lblPrecio.Text = "-";
            }

        }
        private Producto BuscarProductoPorNombre(string nombre)
        {
            Producto productoEncontrado = null;

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection("Server=ALGENIS_LOPEZ\\SQLEXPRESS;DataBase=Practica;Integrated Security=true"))
                {
                    sqlConnection.Open();

                    // Consulta para buscar productos que coincidan con el texto de búsqueda en nombre o ID
                    string query = "SELECT Id, Nombre, Descripcion, Marca, Precio, Stock " +
                     "FROM Productos WHERE Nombre LIKE '%' + @TextoBusqueda + '%' OR Id LIKE '%' + @TextoBusqueda + '%';";

                    using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@TextoBusqueda", nombre);

                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                productoEncontrado = new Producto
                                {
                                   
                                    Nombre = reader["Nombre"].ToString(),
                                    Descripcion = reader["Descripcion"].ToString(),
                                    Marca = reader["Marca"].ToString(),
                                    Precio = (int)reader["Precio"]
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar productos: " + ex.Message);
            }

            return productoEncontrado;
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            ActualizarTotal();

        }
        private void CalcularTotal()
        {
            float total = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[4].Value != null && float.TryParse(row.Cells[4].Value.ToString(), out float subtotal))
                {
                    total += subtotal;
                }
            }

            lblTotalPagar.Text = total.ToString();
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("¿Desea eliminar el producto?",
                    "Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (dataGridView1.CurrentRow != null)
                    {
                        dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                        CalcularTotal();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        private void txtEfectivo_TextChanged(object sender, EventArgs e)
        {
            try {
                lblDevolucion.Text = (float.Parse(txtEfectivo.Text) - float.Parse(lblTotatlPagar.Text)).ToString();

                
            }
            catch { }

            if (txtEfectivo.Text == "")
            {
                lblDevolucion.Text = "";
            }
        }
    }             

}
