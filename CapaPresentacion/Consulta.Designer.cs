namespace CapaPresentacion
{
    partial class Consulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consulta));
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txtBuscar = new Guna.UI.WinForms.GunaTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new Guna.UI.WinForms.GunaButton();
            this.btnactualizar = new Guna.UI.WinForms.GunaButton();
            this.actualizar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.Location = new System.Drawing.Point(-66, 316);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(72, 25);
            this.gunaLabel6.TabIndex = 30;
            this.gunaLabel6.Text = "Stock :";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(12, 24);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(115, 30);
            this.gunaLabel1.TabIndex = 25;
            this.gunaLabel1.Text = "Buscador :";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BaseColor = System.Drawing.Color.White;
            this.txtBuscar.BorderColor = System.Drawing.Color.Silver;
            this.txtBuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscar.FocusedBaseColor = System.Drawing.Color.White;
            this.txtBuscar.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtBuscar.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBuscar.Location = new System.Drawing.Point(132, 24);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PasswordChar = '\0';
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.Size = new System.Drawing.Size(240, 40);
            this.txtBuscar.TabIndex = 19;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(17, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(656, 312);
            this.dataGridView1.TabIndex = 18;
            // 
            // btnBuscar
            // 
            this.btnBuscar.AnimationHoverSpeed = 0.07F;
            this.btnBuscar.AnimationSpeed = 0.03F;
            this.btnBuscar.BaseColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBuscar.BorderColor = System.Drawing.Color.Black;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBuscar.FocusedColor = System.Drawing.Color.Empty;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBuscar.ForeColor = System.Drawing.Color.Firebrick;
            this.btnBuscar.Image = global::CapaPresentacion.Properties.Resources.lupa__1_;
            this.btnBuscar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBuscar.ImageSize = new System.Drawing.Size(50, 50);
            this.btnBuscar.Location = new System.Drawing.Point(378, 15);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnBuscar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBuscar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBuscar.OnHoverImage = null;
            this.btnBuscar.OnPressedColor = System.Drawing.Color.Black;
            this.btnBuscar.Size = new System.Drawing.Size(79, 60);
            this.btnBuscar.TabIndex = 35;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnactualizar
            // 
            this.btnactualizar.AnimationHoverSpeed = 0.07F;
            this.btnactualizar.AnimationSpeed = 0.03F;
            this.btnactualizar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnactualizar.BaseColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnactualizar.BorderColor = System.Drawing.Color.Black;
            this.btnactualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnactualizar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnactualizar.FocusedColor = System.Drawing.Color.Empty;
            this.btnactualizar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnactualizar.ForeColor = System.Drawing.Color.White;
            this.btnactualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnactualizar.Image")));
            this.btnactualizar.ImageSize = new System.Drawing.Size(60, 60);
            this.btnactualizar.Location = new System.Drawing.Point(593, 15);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnactualizar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnactualizar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnactualizar.OnHoverImage = null;
            this.btnactualizar.OnPressedColor = System.Drawing.Color.Black;
            this.btnactualizar.Size = new System.Drawing.Size(80, 85);
            this.btnactualizar.TabIndex = 33;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click_1);
            // 
            // actualizar
            // 
            this.actualizar.AutoSize = true;
            this.actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actualizar.Location = new System.Drawing.Point(493, 44);
            this.actualizar.Name = "actualizar";
            this.actualizar.Size = new System.Drawing.Size(89, 20);
            this.actualizar.TabIndex = 37;
            this.actualizar.Text = "Actualizar";
            // 
            // Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(704, 440);
            this.Controls.Add(this.actualizar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Consulta";
            this.Text = "Consulta";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaButton btnBuscar;
        private Guna.UI.WinForms.GunaButton btnactualizar;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox txtBuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label actualizar;
    }
}