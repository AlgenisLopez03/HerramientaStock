using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Cache;

namespace CapaPresentacion
{
    public partial class Menu : Form
    {
        public Menu()
        {

            InitializeComponent();

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximiza_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximiza.Visible = false;
            btnRestaura.Visible = true;
        }

        private void btnRestaura_Click(object sender, EventArgs e)
        {
            this.WindowState=FormWindowState.Normal;
            btnRestaura.Visible=false;
            btnMaximiza.Visible=true;
           
        }

        private void btnMinimiza_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btnForm1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f2 = new Form1();
            f2.ShowDialog();
            f2 = null;
            this.Show();

        }

        private void btnCunsulta_Click(object sender, EventArgs e)
        {
            this.Hide();
            Consulta CS = new Consulta();
            CS.ShowDialog();
            CS = null;
            this.Show();
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ventas VT = new Ventas();
            VT.ShowDialog();
            VT = null;
            this.Show();
        }

       
        private void LoadUserData()
        {
            lblName.Text =UserLoginCache.FirstName+",  "+UserLoginCache.LastName;
            lblPosicion.Text = UserLoginCache.Position;
            lblEmail.Text = UserLoginCache.Email;
        }
        private void btnCerrarsesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de que quiera cerra sesion?",   "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            LoadUserData();
        }

        private void MenuVertical_Paint(object sender, PaintEventArgs e)
        {
            if (UserLoginCache.Position == CargosINV.General)
            {
                btnForm1.Enabled = true;
                btnVenta.Enabled = false;  
            }
            if (UserLoginCache.Position == CargosINV.Administrator)
            {

            }
        }

        private void PanelCentral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void horafecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }
    }
}
