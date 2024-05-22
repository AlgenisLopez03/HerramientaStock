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
using Common.Cache;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {

        CN_Productos objetoCN = new CN_Productos();
        private string idProducto = null;
        private bool Editar = false;


        public SqlConnection SqlConnection { get; }

        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarProdctos();
        }

        private void MostrarProdctos()
        {

            CN_Productos objeto = new CN_Productos();
            dataGridView1.DataSource = objeto.MostrarProd();
        }


        //Aqui se esta usando el  metodo encapsulamiento para el boton de Guarda los datos
        private void GuardarDB()
        {
            //INSERTAR
            if (Editar == false)
            {
                try
                {
                    objetoCN.InsertarPRod(txtNombre.Text, txtDesc.Text, txtMarca.Text, txtPrecio.Text, txtStock.Text);
                    MessageBox.Show("se inserto correctamente");
                    MostrarProdctos();
                    limpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo insertar los datos por: " + ex);
                }
            }
            //EDITAR
            if (Editar == true)
            {

                try
                {
                    objetoCN.EditarProd(txtNombre.Text, txtDesc.Text, txtMarca.Text, txtPrecio.Text, txtStock.Text, idProducto);
                    MessageBox.Show("se edito correctamente");
                    MostrarProdctos();
                    limpiarForm();
                    Editar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo editar los datos por: " + ex);
                }
            }
        }

        //Aqui se esta usando el  metodo encapsulamiento para poder editiar los datos
       
        private void Enditarr()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Editar = true;
                txtNombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                txtMarca.Text = dataGridView1.CurrentRow.Cells["Marca"].Value.ToString();
                txtDesc.Text = dataGridView1.CurrentRow.Cells["Descripcion"].Value.ToString();
                txtPrecio.Text = dataGridView1.CurrentRow.Cells["Precio"].Value.ToString();
                txtStock.Text = dataGridView1.CurrentRow.Cells["Stock"].Value.ToString();
                idProducto = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
            }
            else
                MessageBox.Show("seleccione una fila por favor");

        }

        private void limpiarForm()
        {
            txtDesc.Clear();
            txtMarca.Text = "";
            txtPrecio.Clear();
            txtStock.Clear();
            txtNombre.Clear();
        }


        private void Eliminarr()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                idProducto = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
                objetoCN.EliminarPRod(idProducto);
                MessageBox.Show("Eliminado correctamente");
                MostrarProdctos();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

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

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            Enditarr();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarDB();
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            Mostarlist();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            Eliminarr();
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            BuscarDB();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            if (UserLoginCache.Position == CargosINV.General)
            {
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;

            }
            if (UserLoginCache.Position == CargosINV.Administrator)
            {

            }
        }
    }
}
