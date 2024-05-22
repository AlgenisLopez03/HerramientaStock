namespace CapaPresentacion
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.BarraTitulo = new Guna.UI.WinForms.GunaPanel();
            this.btnRestaura = new Guna.UI.WinForms.GunaPictureBox();
            this.btnMinimiza = new Guna.UI.WinForms.GunaPictureBox();
            this.btnMaximiza = new Guna.UI.WinForms.GunaPictureBox();
            this.btnCerrar = new Guna.UI.WinForms.GunaPictureBox();
            this.MenuVertical = new Guna.UI.WinForms.GunaPanel();
            this.btnCerrarsesion = new Guna.UI.WinForms.GunaButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPosicion = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnVenta = new Guna.UI.WinForms.GunaButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnCunsulta = new Guna.UI.WinForms.GunaButton();
            this.btnReporte = new Guna.UI.WinForms.GunaButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnForm1 = new Guna.UI.WinForms.GunaButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelCentral = new Guna.UI.WinForms.GunaPanel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.horafecha = new System.Windows.Forms.Timer(this.components);
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimiza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximiza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.MenuVertical.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelCentral.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BarraTitulo.Controls.Add(this.btnRestaura);
            this.BarraTitulo.Controls.Add(this.btnMinimiza);
            this.BarraTitulo.Controls.Add(this.btnMaximiza);
            this.BarraTitulo.Controls.Add(this.btnCerrar);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1300, 38);
            this.BarraTitulo.TabIndex = 0;
            // 
            // btnRestaura
            // 
            this.btnRestaura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaura.BaseColor = System.Drawing.Color.White;
            this.btnRestaura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaura.Image = global::CapaPresentacion.Properties.Resources.compartir_flecha;
            this.btnRestaura.Location = new System.Drawing.Point(1232, 7);
            this.btnRestaura.Name = "btnRestaura";
            this.btnRestaura.Size = new System.Drawing.Size(25, 25);
            this.btnRestaura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaura.TabIndex = 3;
            this.btnRestaura.TabStop = false;
            this.btnRestaura.Visible = false;
            this.btnRestaura.Click += new System.EventHandler(this.btnRestaura_Click);
            // 
            // btnMinimiza
            // 
            this.btnMinimiza.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimiza.BaseColor = System.Drawing.Color.White;
            this.btnMinimiza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimiza.Image = global::CapaPresentacion.Properties.Resources.minimizar;
            this.btnMinimiza.Location = new System.Drawing.Point(1201, 7);
            this.btnMinimiza.Name = "btnMinimiza";
            this.btnMinimiza.Size = new System.Drawing.Size(25, 25);
            this.btnMinimiza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimiza.TabIndex = 2;
            this.btnMinimiza.TabStop = false;
            this.btnMinimiza.Click += new System.EventHandler(this.btnMinimiza_Click);
            // 
            // btnMaximiza
            // 
            this.btnMaximiza.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximiza.BaseColor = System.Drawing.Color.White;
            this.btnMaximiza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximiza.Image = global::CapaPresentacion.Properties.Resources.maximizar__1_;
            this.btnMaximiza.Location = new System.Drawing.Point(1232, 7);
            this.btnMaximiza.Name = "btnMaximiza";
            this.btnMaximiza.Size = new System.Drawing.Size(25, 25);
            this.btnMaximiza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximiza.TabIndex = 1;
            this.btnMaximiza.TabStop = false;
            this.btnMaximiza.Click += new System.EventHandler(this.btnMaximiza_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BaseColor = System.Drawing.Color.White;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::CapaPresentacion.Properties.Resources.cruz;
            this.btnCerrar.Location = new System.Drawing.Point(1263, 7);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.MenuVertical.Controls.Add(this.btnCerrarsesion);
            this.MenuVertical.Controls.Add(this.panel7);
            this.MenuVertical.Controls.Add(this.pictureBox1);
            this.MenuVertical.Controls.Add(this.btnVenta);
            this.MenuVertical.Controls.Add(this.panel6);
            this.MenuVertical.Controls.Add(this.btnCunsulta);
            this.MenuVertical.Controls.Add(this.btnReporte);
            this.MenuVertical.Controls.Add(this.panel5);
            this.MenuVertical.Controls.Add(this.panel2);
            this.MenuVertical.Controls.Add(this.btnForm1);
            this.MenuVertical.Controls.Add(this.panel1);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 38);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(245, 612);
            this.MenuVertical.TabIndex = 1;
            this.MenuVertical.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuVertical_Paint);
            // 
            // btnCerrarsesion
            // 
            this.btnCerrarsesion.AnimationHoverSpeed = 0.07F;
            this.btnCerrarsesion.AnimationSpeed = 0.03F;
            this.btnCerrarsesion.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnCerrarsesion.BorderColor = System.Drawing.Color.Black;
            this.btnCerrarsesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarsesion.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCerrarsesion.FocusedColor = System.Drawing.Color.Empty;
            this.btnCerrarsesion.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarsesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarsesion.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarsesion.Image")));
            this.btnCerrarsesion.ImageSize = new System.Drawing.Size(25, 25);
            this.btnCerrarsesion.Location = new System.Drawing.Point(3, 524);
            this.btnCerrarsesion.Name = "btnCerrarsesion";
            this.btnCerrarsesion.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnCerrarsesion.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCerrarsesion.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCerrarsesion.OnHoverImage = null;
            this.btnCerrarsesion.OnPressedColor = System.Drawing.Color.Black;
            this.btnCerrarsesion.Size = new System.Drawing.Size(202, 50);
            this.btnCerrarsesion.TabIndex = 13;
            this.btnCerrarsesion.Text = "Cerrar sesion";
            this.btnCerrarsesion.Click += new System.EventHandler(this.btnCerrarsesion_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panel7.Controls.Add(this.lblEmail);
            this.panel7.Controls.Add(this.lblName);
            this.panel7.Controls.Add(this.lblPosicion);
            this.panel7.Location = new System.Drawing.Point(0, 143);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(245, 98);
            this.panel7.TabIndex = 0;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEmail.Location = new System.Drawing.Point(10, 67);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 16);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblName.Location = new System.Drawing.Point(10, 7);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(62, 16);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Nombre";
            // 
            // lblPosicion
            // 
            this.lblPosicion.AutoSize = true;
            this.lblPosicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblPosicion.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPosicion.Location = new System.Drawing.Point(10, 40);
            this.lblPosicion.Name = "lblPosicion";
            this.lblPosicion.Size = new System.Drawing.Size(67, 16);
            this.lblPosicion.TabIndex = 0;
            this.lblPosicion.Text = "Posicion";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnVenta
            // 
            this.btnVenta.AnimationHoverSpeed = 0.07F;
            this.btnVenta.AnimationSpeed = 0.03F;
            this.btnVenta.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnVenta.BorderColor = System.Drawing.Color.Black;
            this.btnVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVenta.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnVenta.FocusedColor = System.Drawing.Color.Empty;
            this.btnVenta.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVenta.ForeColor = System.Drawing.Color.White;
            this.btnVenta.Image = ((System.Drawing.Image)(resources.GetObject("btnVenta.Image")));
            this.btnVenta.ImageSize = new System.Drawing.Size(30, 30);
            this.btnVenta.Location = new System.Drawing.Point(16, 300);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnVenta.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnVenta.OnHoverForeColor = System.Drawing.Color.White;
            this.btnVenta.OnHoverImage = null;
            this.btnVenta.OnPressedColor = System.Drawing.Color.Black;
            this.btnVenta.Size = new System.Drawing.Size(198, 51);
            this.btnVenta.TabIndex = 11;
            this.btnVenta.Text = "Venta";
            this.btnVenta.Click += new System.EventHandler(this.btnVenta_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Blue;
            this.panel6.Location = new System.Drawing.Point(3, 300);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(11, 51);
            this.panel6.TabIndex = 10;
            // 
            // btnCunsulta
            // 
            this.btnCunsulta.AnimationHoverSpeed = 0.07F;
            this.btnCunsulta.AnimationSpeed = 0.03F;
            this.btnCunsulta.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnCunsulta.BorderColor = System.Drawing.Color.Black;
            this.btnCunsulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCunsulta.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCunsulta.FocusedColor = System.Drawing.Color.Empty;
            this.btnCunsulta.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCunsulta.ForeColor = System.Drawing.Color.White;
            this.btnCunsulta.Image = ((System.Drawing.Image)(resources.GetObject("btnCunsulta.Image")));
            this.btnCunsulta.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCunsulta.Location = new System.Drawing.Point(16, 368);
            this.btnCunsulta.Name = "btnCunsulta";
            this.btnCunsulta.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnCunsulta.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCunsulta.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCunsulta.OnHoverImage = null;
            this.btnCunsulta.OnPressedColor = System.Drawing.Color.Black;
            this.btnCunsulta.Size = new System.Drawing.Size(181, 47);
            this.btnCunsulta.TabIndex = 5;
            this.btnCunsulta.Text = "Consulta";
            this.btnCunsulta.Click += new System.EventHandler(this.btnCunsulta_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.AnimationHoverSpeed = 0.07F;
            this.btnReporte.AnimationSpeed = 0.03F;
            this.btnReporte.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnReporte.BorderColor = System.Drawing.Color.Black;
            this.btnReporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReporte.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnReporte.FocusedColor = System.Drawing.Color.Empty;
            this.btnReporte.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.ForeColor = System.Drawing.Color.White;
            this.btnReporte.Image = ((System.Drawing.Image)(resources.GetObject("btnReporte.Image")));
            this.btnReporte.ImageSize = new System.Drawing.Size(30, 30);
            this.btnReporte.Location = new System.Drawing.Point(16, 433);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnReporte.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnReporte.OnHoverForeColor = System.Drawing.Color.White;
            this.btnReporte.OnHoverImage = null;
            this.btnReporte.OnPressedColor = System.Drawing.Color.Black;
            this.btnReporte.Size = new System.Drawing.Size(181, 47);
            this.btnReporte.TabIndex = 7;
            this.btnReporte.Text = "Reporte";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Blue;
            this.panel5.Location = new System.Drawing.Point(2, 433);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(11, 51);
            this.panel5.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.Location = new System.Drawing.Point(3, 368);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 51);
            this.panel2.TabIndex = 4;
            // 
            // btnForm1
            // 
            this.btnForm1.AnimationHoverSpeed = 0.07F;
            this.btnForm1.AnimationSpeed = 0.03F;
            this.btnForm1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnForm1.BorderColor = System.Drawing.Color.Black;
            this.btnForm1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnForm1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnForm1.FocusedColor = System.Drawing.Color.Empty;
            this.btnForm1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForm1.ForeColor = System.Drawing.Color.White;
            this.btnForm1.Image = ((System.Drawing.Image)(resources.GetObject("btnForm1.Image")));
            this.btnForm1.ImageSize = new System.Drawing.Size(30, 30);
            this.btnForm1.Location = new System.Drawing.Point(20, 247);
            this.btnForm1.Name = "btnForm1";
            this.btnForm1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnForm1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnForm1.OnHoverForeColor = System.Drawing.Color.White;
            this.btnForm1.OnHoverImage = null;
            this.btnForm1.OnPressedColor = System.Drawing.Color.Black;
            this.btnForm1.Size = new System.Drawing.Size(181, 47);
            this.btnForm1.TabIndex = 3;
            this.btnForm1.Text = "Registro";
            this.btnForm1.Click += new System.EventHandler(this.btnForm1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Location = new System.Drawing.Point(3, 247);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(11, 47);
            this.panel1.TabIndex = 2;
            // 
            // PanelCentral
            // 
            this.PanelCentral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(37)))), ((int)(((byte)(92)))));
            this.PanelCentral.Controls.Add(this.lblFecha);
            this.PanelCentral.Controls.Add(this.lblHora);
            this.PanelCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelCentral.Location = new System.Drawing.Point(245, 38);
            this.PanelCentral.Name = "PanelCentral";
            this.PanelCentral.Size = new System.Drawing.Size(1055, 612);
            this.PanelCentral.TabIndex = 2;
            this.PanelCentral.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelCentral_Paint);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Century Gothic", 90F);
            this.lblHora.Location = new System.Drawing.Point(189, 199);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(409, 142);
            this.lblHora.TabIndex = 0;
            this.lblHora.Text = "HORA";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 25F);
            this.lblFecha.Location = new System.Drawing.Point(217, 396);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(121, 40);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Fecha";
            // 
            // horafecha
            // 
            this.horafecha.Enabled = true;
            this.horafecha.Tick += new System.EventHandler(this.horafecha_Tick);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.PanelCentral);
            this.Controls.Add(this.MenuVertical);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.Text = "Menu";
            this.BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimiza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximiza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.MenuVertical.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelCentral.ResumeLayout(false);
            this.PanelCentral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel BarraTitulo;
        private Guna.UI.WinForms.GunaPanel MenuVertical;
        private Guna.UI.WinForms.GunaPanel PanelCentral;
        private Guna.UI.WinForms.GunaPictureBox btnCerrar;
        private Guna.UI.WinForms.GunaPictureBox btnMaximiza;
        private Guna.UI.WinForms.GunaPictureBox btnMinimiza;
        private Guna.UI.WinForms.GunaPictureBox btnRestaura;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaButton btnForm1;
        private Guna.UI.WinForms.GunaButton btnCunsulta;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaButton btnReporte;
        private System.Windows.Forms.Panel panel5;
        private Guna.UI.WinForms.GunaButton btnVenta;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPosicion;
        private Guna.UI.WinForms.GunaButton btnCerrarsesion;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer horafecha;
    }
}