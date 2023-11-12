namespace MyStrategyCloth.Views
{
    partial class InterfazGestionUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterfazGestionUsuario));
            this.lbWelcome = new System.Windows.Forms.Label();
            this.gbAdminUsuario = new System.Windows.Forms.GroupBox();
            this.lbNombreU = new System.Windows.Forms.Label();
            this.tbNombreU = new System.Windows.Forms.TextBox();
            this.lbApellidoU = new System.Windows.Forms.Label();
            this.tbApellidoU = new System.Windows.Forms.TextBox();
            this.lbRol = new System.Windows.Forms.Label();
            this.cbRol = new System.Windows.Forms.ComboBox();
            this.btnAgregarU = new System.Windows.Forms.Button();
            this.btnModificarU = new System.Windows.Forms.Button();
            this.btnEliminarU = new System.Windows.Forms.Button();
            this.gbTabla = new System.Windows.Forms.GroupBox();
            this.btnConsultarU = new System.Windows.Forms.Button();
            this.btLimpiarU = new System.Windows.Forms.Button();
            this.dgvTablaU = new System.Windows.Forms.DataGridView();
            this.gbInforme = new System.Windows.Forms.GroupBox();
            this.btnGenerarInforme = new System.Windows.Forms.Button();
            this.btnAdmStock = new System.Windows.Forms.Button();
            this.gbAdminUsuario.SuspendLayout();
            this.gbTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaU)).BeginInit();
            this.gbInforme.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbWelcome
            // 
            this.lbWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lbWelcome.Font = new System.Drawing.Font("Bebas", 14.25F);
            this.lbWelcome.Location = new System.Drawing.Point(106, 9);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(265, 20);
            this.lbWelcome.TabIndex = 4;
            this.lbWelcome.Text = "<<< Bienvenido Administrador >>>";
            this.lbWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbAdminUsuario
            // 
            this.gbAdminUsuario.BackColor = System.Drawing.Color.Transparent;
            this.gbAdminUsuario.Controls.Add(this.lbNombreU);
            this.gbAdminUsuario.Controls.Add(this.tbNombreU);
            this.gbAdminUsuario.Controls.Add(this.lbApellidoU);
            this.gbAdminUsuario.Controls.Add(this.tbApellidoU);
            this.gbAdminUsuario.Controls.Add(this.lbRol);
            this.gbAdminUsuario.Controls.Add(this.cbRol);
            this.gbAdminUsuario.Controls.Add(this.btnAgregarU);
            this.gbAdminUsuario.Controls.Add(this.btnModificarU);
            this.gbAdminUsuario.Controls.Add(this.btnEliminarU);
            this.gbAdminUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbAdminUsuario.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.gbAdminUsuario.Location = new System.Drawing.Point(27, 34);
            this.gbAdminUsuario.Name = "gbAdminUsuario";
            this.gbAdminUsuario.Size = new System.Drawing.Size(400, 180);
            this.gbAdminUsuario.TabIndex = 5;
            this.gbAdminUsuario.TabStop = false;
            this.gbAdminUsuario.Text = "Administración de Usuarios";
            // 
            // lbNombreU
            // 
            this.lbNombreU.Location = new System.Drawing.Point(30, 30);
            this.lbNombreU.Name = "lbNombreU";
            this.lbNombreU.Size = new System.Drawing.Size(150, 20);
            this.lbNombreU.TabIndex = 0;
            this.lbNombreU.Text = "Nombre del Usuario:";
            // 
            // tbNombreU
            // 
            this.tbNombreU.BackColor = System.Drawing.Color.White;
            this.tbNombreU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNombreU.ForeColor = System.Drawing.Color.White;
            this.tbNombreU.Location = new System.Drawing.Point(200, 30);
            this.tbNombreU.Name = "tbNombreU";
            this.tbNombreU.Size = new System.Drawing.Size(150, 22);
            this.tbNombreU.TabIndex = 1;
            // 
            // lbApellidoU
            // 
            this.lbApellidoU.Location = new System.Drawing.Point(30, 60);
            this.lbApellidoU.Name = "lbApellidoU";
            this.lbApellidoU.Size = new System.Drawing.Size(150, 20);
            this.lbApellidoU.TabIndex = 2;
            this.lbApellidoU.Text = "Apellido:";
            // 
            // tbApellidoU
            // 
            this.tbApellidoU.BackColor = System.Drawing.Color.White;
            this.tbApellidoU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbApellidoU.ForeColor = System.Drawing.Color.White;
            this.tbApellidoU.Location = new System.Drawing.Point(200, 60);
            this.tbApellidoU.Name = "tbApellidoU";
            this.tbApellidoU.Size = new System.Drawing.Size(150, 22);
            this.tbApellidoU.TabIndex = 3;
            // 
            // lbRol
            // 
            this.lbRol.Location = new System.Drawing.Point(30, 90);
            this.lbRol.Name = "lbRol";
            this.lbRol.Size = new System.Drawing.Size(150, 20);
            this.lbRol.TabIndex = 4;
            this.lbRol.Text = "Rol de Usuario:";
            // 
            // cbRol
            // 
            this.cbRol.BackColor = System.Drawing.Color.White;
            this.cbRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRol.ForeColor = System.Drawing.Color.White;
            this.cbRol.Items.AddRange(new object[] {
            "Vendedor",
            "Administrador"});
            this.cbRol.Location = new System.Drawing.Point(200, 90);
            this.cbRol.Name = "cbRol";
            this.cbRol.Size = new System.Drawing.Size(150, 24);
            this.cbRol.TabIndex = 5;
            // 
            // btnAgregarU
            // 
            this.btnAgregarU.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregarU.BackgroundImage")));
            this.btnAgregarU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarU.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAgregarU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarU.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregarU.Location = new System.Drawing.Point(50, 130);
            this.btnAgregarU.Name = "btnAgregarU";
            this.btnAgregarU.Size = new System.Drawing.Size(75, 30);
            this.btnAgregarU.TabIndex = 6;
            this.btnAgregarU.Text = "Agregar";
            // 
            // btnModificarU
            // 
            this.btnModificarU.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModificarU.BackgroundImage")));
            this.btnModificarU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificarU.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnModificarU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarU.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModificarU.Location = new System.Drawing.Point(150, 130);
            this.btnModificarU.Name = "btnModificarU";
            this.btnModificarU.Size = new System.Drawing.Size(75, 30);
            this.btnModificarU.TabIndex = 7;
            this.btnModificarU.Text = "Modificar";
            // 
            // btnEliminarU
            // 
            this.btnEliminarU.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminarU.BackgroundImage")));
            this.btnEliminarU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminarU.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminarU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarU.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarU.Location = new System.Drawing.Point(250, 130);
            this.btnEliminarU.Name = "btnEliminarU";
            this.btnEliminarU.Size = new System.Drawing.Size(75, 30);
            this.btnEliminarU.TabIndex = 8;
            this.btnEliminarU.Text = "Guardar";
            // 
            // gbTabla
            // 
            this.gbTabla.BackColor = System.Drawing.Color.Transparent;
            this.gbTabla.Controls.Add(this.btnConsultarU);
            this.gbTabla.Controls.Add(this.btLimpiarU);
            this.gbTabla.Controls.Add(this.dgvTablaU);
            this.gbTabla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbTabla.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.gbTabla.Location = new System.Drawing.Point(27, 224);
            this.gbTabla.Name = "gbTabla";
            this.gbTabla.Size = new System.Drawing.Size(400, 250);
            this.gbTabla.TabIndex = 6;
            this.gbTabla.TabStop = false;
            // 
            // btnConsultarU
            // 
            this.btnConsultarU.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConsultarU.BackgroundImage")));
            this.btnConsultarU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConsultarU.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnConsultarU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarU.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConsultarU.Location = new System.Drawing.Point(50, 15);
            this.btnConsultarU.Name = "btnConsultarU";
            this.btnConsultarU.Size = new System.Drawing.Size(75, 30);
            this.btnConsultarU.TabIndex = 0;
            this.btnConsultarU.Text = "Consultar";
            // 
            // btLimpiarU
            // 
            this.btLimpiarU.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btLimpiarU.BackgroundImage")));
            this.btLimpiarU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btLimpiarU.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btLimpiarU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLimpiarU.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btLimpiarU.Location = new System.Drawing.Point(150, 15);
            this.btLimpiarU.Name = "btLimpiarU";
            this.btLimpiarU.Size = new System.Drawing.Size(75, 30);
            this.btLimpiarU.TabIndex = 1;
            this.btLimpiarU.Text = "Limpiar";
            // 
            // dgvTablaU
            // 
            this.dgvTablaU.BackgroundColor = System.Drawing.Color.Green;
            this.dgvTablaU.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTablaU.Location = new System.Drawing.Point(25, 55);
            this.dgvTablaU.Name = "dgvTablaU";
            this.dgvTablaU.Size = new System.Drawing.Size(340, 180);
            this.dgvTablaU.TabIndex = 2;
            // 
            // gbInforme
            // 
            this.gbInforme.BackColor = System.Drawing.Color.Transparent;
            this.gbInforme.Controls.Add(this.btnGenerarInforme);
            this.gbInforme.Controls.Add(this.btnAdmStock);
            this.gbInforme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbInforme.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.gbInforme.Location = new System.Drawing.Point(27, 484);
            this.gbInforme.Name = "gbInforme";
            this.gbInforme.Size = new System.Drawing.Size(400, 70);
            this.gbInforme.TabIndex = 7;
            this.gbInforme.TabStop = false;
            this.gbInforme.Text = "Informes y otras administraciones";
            // 
            // btnGenerarInforme
            // 
            this.btnGenerarInforme.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGenerarInforme.BackgroundImage")));
            this.btnGenerarInforme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGenerarInforme.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGenerarInforme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarInforme.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGenerarInforme.Location = new System.Drawing.Point(50, 25);
            this.btnGenerarInforme.Name = "btnGenerarInforme";
            this.btnGenerarInforme.Size = new System.Drawing.Size(75, 30);
            this.btnGenerarInforme.TabIndex = 0;
            this.btnGenerarInforme.Text = "Informe";
            // 
            // btnAdmStock
            // 
            this.btnAdmStock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdmStock.BackgroundImage")));
            this.btnAdmStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdmStock.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAdmStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmStock.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdmStock.Location = new System.Drawing.Point(150, 25);
            this.btnAdmStock.Name = "btnAdmStock";
            this.btnAdmStock.Size = new System.Drawing.Size(150, 30);
            this.btnAdmStock.TabIndex = 1;
            this.btnAdmStock.Text = "Administrar Stock";
            this.btnAdmStock.Click += new System.EventHandler(this.btnAdmStock_Click);
            // 
            // InterfazGestionUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(455, 564);
            this.Controls.Add(this.lbWelcome);
            this.Controls.Add(this.gbAdminUsuario);
            this.Controls.Add(this.gbTabla);
            this.Controls.Add(this.gbInforme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "InterfazGestionUsuario";
            this.Text = "InterfazGestionUsuario";
            this.Load += new System.EventHandler(this.InterfazGestionUsuario_Load);
            this.gbAdminUsuario.ResumeLayout(false);
            this.gbAdminUsuario.PerformLayout();
            this.gbTabla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaU)).EndInit();
            this.gbInforme.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbWelcome;
        private System.Windows.Forms.GroupBox gbAdminUsuario;
        private System.Windows.Forms.Label lbNombreU;
        private System.Windows.Forms.TextBox tbNombreU;
        private System.Windows.Forms.Label lbApellidoU;
        private System.Windows.Forms.TextBox tbApellidoU;
        private System.Windows.Forms.Label lbRol;
        private System.Windows.Forms.ComboBox cbRol;
        private System.Windows.Forms.Button btnAgregarU;
        private System.Windows.Forms.Button btnModificarU;
        private System.Windows.Forms.Button btnEliminarU;
        private System.Windows.Forms.GroupBox gbTabla;
        private System.Windows.Forms.Button btnConsultarU;
        private System.Windows.Forms.Button btLimpiarU;
        private System.Windows.Forms.DataGridView dgvTablaU;
        private System.Windows.Forms.GroupBox gbInforme;
        private System.Windows.Forms.Button btnGenerarInforme;
        private System.Windows.Forms.Button btnAdmStock;
    }
}