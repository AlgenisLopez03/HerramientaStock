using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Consulta : Form
    {
        CN_Productos objetoCN = new CN_Productos();
        private string idProducto = null;
        private bool Editar = false;

        public SqlConnection SqlConnection { get; }
        public Consulta()
        {
            InitializeComponent();
        }
        private void MostrarProdctos()
        {

            CN_Productos objeto = new CN_Productos();
            dataGridView1.DataSource = objeto.MostrarProd();
        }


        //Aqui se esta usando el  metodo encapsulamiento para el boton de Guarda los datos
       

        

        //Aqui se esta usando el  metodo encapsulamiento para el boton de Buscar datos los datos
        private void BuscarDB()
        {
            string textoBusqueda = txtBuscar.Text.Trim();

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection("Server=ALGENIS_LOPEZ\\SQLEXPRESS;DataBase= Practica;Integrated Security=true"))
                {
                    sqlConnection.Open();

                    // Consulta para buscar productos que coincidan con el texto de búsqueda en nombre o ID
                    string query = "SELECT Id, Nombre, Descripcion, Marca, Precio, Stock " +
                                   "FROM Productos WHERE Nombre LIKE '%' + @TextoBusqueda + '%' OR Id LIKE '%' + @TextoBusqueda + '%';";

                    using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@TextoBusqueda", textoBusqueda);

                        // Crear un adaptador de datos para cargar los datos en el DataTable
                        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                        DataTable dataTable = new DataTable();
                        sqlDataAdapter.Fill(dataTable);

                        // Asignar el DataTable al DataGridView para mostrar los datos
                        dataGridView1.DataSource = dataTable;
                    }

                    // Resaltar el texto de búsqueda en el DataGridView
                    ResaltarTextoBusqueda(textoBusqueda);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar productos: " + ex.Message);
            }
        }
        private void ResaltarTextoBusqueda(string textoBusqueda)
        {
            // Recorrer todas las celdas del DataGridView para resaltar el texto de búsqueda
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().Contains(textoBusqueda))
                    {
                        cell.Style.BackColor = System.Drawing.Color.Yellow;
                    }
                    else
                    {
                        cell.Style.BackColor = System.Drawing.Color.White;
                    }
                }
            }
        }

        // Crea una clase para representar los datos que deseas mostrar

        private void Mostarlist()
        {
            CN_Productos objeto = new CN_Productos();
            dataGridView1.DataSource = objeto.MostrarProd();

        }

       
        private void btnactualizar_Click_1(object sender, EventArgs e)
        {
            Mostarlist();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
           
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarDB();
        }
    }
}
