using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using CapaNegocio;
using Common.Cache;

namespace CapaPresentacion
{
    public partial class CapLogin : Form
    {
        public CapLogin()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

   
        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.Silver;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "CONTRASEÑA")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.LightGray;
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "CONTRASEÑA";
                txtPass.ForeColor = Color.Silver;
                txtPass.UseSystemPasswordChar = false;
            }
            if (txtPass.Text == "")
            {
                txtPass.Text = "Contraseña";
                txtPass.ForeColor = Color.Silver;
                txtPass.UseSystemPasswordChar = false;
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        
        //Esto dos ultimas linea de codigo sirve para que se mueva el formulario
        private void CapLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //Aqui se esta llamando los campos 
        private void btnLogin_Click(object sender, EventArgs e)
        {
            login_mandato();
        }
        private void login_mandato()
        {
            if (txtUsuario.Text != "USUARIO")
            {
                if (txtPass.Text != "CONTRASEÑA")
                {
                    UserModel user = new UserModel();
                    var validLogin = user.LoginUser(txtUsuario.Text, txtPass.Text);
                    //Esto es para Verifica si el usuario existe
                    if (validLogin == true)
                    {

                        Menu menu = new Menu();
                        MessageBox.Show("Bienvenido/a  " + UserLoginCache.FirstName + ", " + UserLoginCache.LastName);
                        menu.Show();
                        menu.FormClosed += Logout;
                        this.Hide();

                    }
                    else
                    {
                        msgError("Error de contraseña o usuario.");
                        txtPass.Text = "CONTRASEÑA";
                        txtUsuario.Focus();
                    }

                }
                else msgError("Por favor ingrese su contraseña.");

            }
            else msgError("Por favor ingrese su usuario.");
        }
        // Esto es para que muestre el mensaje de error
        private void msgError(string msg)
        {
            lblErrorMessagge.Text = "    " + msg;
            lblErrorMessagge.Visible = true; 
        }
        //Creamo un metedo para cerrar sesion
        private void Logout(object sender, FormClosedEventArgs e)
        {
            txtPass.Text = "CONTRASEÑA";
           txtPass.UseSystemPasswordChar = false;
            txtUsuario.Text = "USUARIO";
            lblErrorMessagge.Visible=false;
            this.Show();
            //txtUsuario.Focus();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
