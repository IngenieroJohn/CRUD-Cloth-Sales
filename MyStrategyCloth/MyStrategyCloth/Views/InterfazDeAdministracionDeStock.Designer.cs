namespace MyStrategyCloth.Views
{
    partial class InterfazDeAdministracionDeStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterfazDeAdministracionDeStock));
            this.btnAdmUsuarios = new System.Windows.Forms.Button();
            this.btnGenerarInforme = new System.Windows.Forms.Button();
            this.gbInforme = new System.Windows.Forms.GroupBox();
            this.lbWelcome = new System.Windows.Forms.Label();
            this.gbAdmin = new System.Windows.Forms.GroupBox();
            this.lbNomProducto = new System.Windows.Forms.Label();
            this.tbNomProducto = new System.Windows.Forms.TextBox();
            this.lbCantidad = new System.Windows.Forms.Label();
            this.tbCantidad = new System.Windows.Forms.TextBox();
            this.lbPreUnitario = new System.Windows.Forms.Label();
            this.tbPreUnitario = new System.Windows.Forms.TextBox();
            this.lbProveedor = new System.Windows.Forms.Label();
            this.tbProveedor = new System.Windows.Forms.TextBox();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.btAgregarProd = new System.Windows.Forms.Button();
            this.btModificarProd = new System.Windows.Forms.Button();
            this.btEliminarProd = new System.Windows.Forms.Button();
            this.gbTabla = new System.Windows.Forms.GroupBox();
            this.btConsultar = new System.Windows.Forms.Button();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.dgvTabla = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.CmbCategoria = new System.Windows.Forms.ComboBox();
            this.gbInforme.SuspendLayout();
            this.gbAdmin.SuspendLayout();
            this.gbTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdmUsuarios
            // 
            this.btnAdmUsuarios.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdmUsuarios.BackgroundImage")));
            this.btnAdmUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdmUsuarios.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAdmUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmUsuarios.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.btnAdmUsuarios.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdmUsuarios.Location = new System.Drawing.Point(150, 35);
            this.btnAdmUsuarios.Name = "btnAdmUsuarios";
            this.btnAdmUsuarios.Size = new System.Drawing.Size(153, 37);
            this.btnAdmUsuarios.TabIndex = 1;
            this.btnAdmUsuarios.Text = "Administrar Usuarios";
            this.btnAdmUsuarios.Click += new System.EventHandler(this.btnAdmUsuarios_Click);
            // 
            // btnGenerarInforme
            // 
            this.btnGenerarInforme.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGenerarInforme.BackgroundImage")));
            this.btnGenerarInforme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGenerarInforme.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGenerarInforme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarInforme.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.btnGenerarInforme.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGenerarInforme.Location = new System.Drawing.Point(33, 35);
            this.btnGenerarInforme.Name = "btnGenerarInforme";
            this.btnGenerarInforme.Size = new System.Drawing.Size(111, 37);
            this.btnGenerarInforme.TabIndex = 0;
            this.btnGenerarInforme.Text = "Informe";
            // 
            // gbInforme
            // 
            this.gbInforme.BackColor = System.Drawing.Color.Transparent;
            this.gbInforme.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbInforme.BackgroundImage")));
            this.gbInforme.Controls.Add(this.btnGenerarInforme);
            this.gbInforme.Controls.Add(this.btnAdmUsuarios);
            this.gbInforme.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.gbInforme.Location = new System.Drawing.Point(30, 335);
            this.gbInforme.Name = "gbInforme";
            this.gbInforme.Size = new System.Drawing.Size(361, 90);
            this.gbInforme.TabIndex = 3;
            this.gbInforme.TabStop = false;
            this.gbInforme.Text = "Informes y otras administraciones";
            // 
            // lbWelcome
            // 
            this.lbWelcome.BackColor = System.Drawing.Color.DarkGreen;
            this.lbWelcome.Font = new System.Drawing.Font("Bebas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWelcome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbWelcome.Location = new System.Drawing.Point(291, 9);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(250, 20);
            this.lbWelcome.TabIndex = 3;
            this.lbWelcome.Text = "<<< Bienvenido Administrador >>>";
            this.lbWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbAdmin
            // 
            this.gbAdmin.BackColor = System.Drawing.Color.Transparent;
            this.gbAdmin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbAdmin.BackgroundImage")));
            this.gbAdmin.Controls.Add(this.CmbCategoria);
            this.gbAdmin.Controls.Add(this.lbCategoria);
            this.gbAdmin.Controls.Add(this.lbNomProducto);
            this.gbAdmin.Controls.Add(this.tbNomProducto);
            this.gbAdmin.Controls.Add(this.lbCantidad);
            this.gbAdmin.Controls.Add(this.tbCantidad);
            this.gbAdmin.Controls.Add(this.lbPreUnitario);
            this.gbAdmin.Controls.Add(this.tbPreUnitario);
            this.gbAdmin.Controls.Add(this.lbProveedor);
            this.gbAdmin.Controls.Add(this.tbProveedor);
            this.gbAdmin.Controls.Add(this.lbCodigo);
            this.gbAdmin.Controls.Add(this.tbCodigo);
            this.gbAdmin.Controls.Add(this.btAgregarProd);
            this.gbAdmin.Controls.Add(this.btModificarProd);
            this.gbAdmin.Controls.Add(this.btEliminarProd);
            this.gbAdmin.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.gbAdmin.Location = new System.Drawing.Point(30, 57);
            this.gbAdmin.Name = "gbAdmin";
            this.gbAdmin.Size = new System.Drawing.Size(361, 272);
            this.gbAdmin.TabIndex = 4;
            this.gbAdmin.TabStop = false;
            this.gbAdmin.Text = "Administración de Stock";
            // 
            // lbNomProducto
            // 
            this.lbNomProducto.Location = new System.Drawing.Point(30, 30);
            this.lbNomProducto.Name = "lbNomProducto";
            this.lbNomProducto.Size = new System.Drawing.Size(150, 20);
            this.lbNomProducto.TabIndex = 0;
            this.lbNomProducto.Text = "Nombre del Producto:";
            // 
            // tbNomProducto
            // 
            this.tbNomProducto.Location = new System.Drawing.Point(176, 30);
            this.tbNomProducto.Name = "tbNomProducto";
            this.tbNomProducto.Size = new System.Drawing.Size(150, 22);
            this.tbNomProducto.TabIndex = 1;
            // 
            // lbCantidad
            // 
            this.lbCantidad.Location = new System.Drawing.Point(30, 60);
            this.lbCantidad.Name = "lbCantidad";
            this.lbCantidad.Size = new System.Drawing.Size(150, 20);
            this.lbCantidad.TabIndex = 2;
            this.lbCantidad.Text = "Cantidad:";
            // 
            // tbCantidad
            // 
            this.tbCantidad.Location = new System.Drawing.Point(176, 60);
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(150, 22);
            this.tbCantidad.TabIndex = 3;
            // 
            // lbPreUnitario
            // 
            this.lbPreUnitario.Location = new System.Drawing.Point(30, 90);
            this.lbPreUnitario.Name = "lbPreUnitario";
            this.lbPreUnitario.Size = new System.Drawing.Size(150, 20);
            this.lbPreUnitario.TabIndex = 4;
            this.lbPreUnitario.Text = "Precio Unitario:";
            // 
            // tbPreUnitario
            // 
            this.tbPreUnitario.Location = new System.Drawing.Point(176, 90);
            this.tbPreUnitario.Name = "tbPreUnitario";
            this.tbPreUnitario.Size = new System.Drawing.Size(150, 22);
            this.tbPreUnitario.TabIndex = 5;
            // 
            // lbProveedor
            // 
            this.lbProveedor.Location = new System.Drawing.Point(30, 120);
            this.lbProveedor.Name = "lbProveedor";
            this.lbProveedor.Size = new System.Drawing.Size(150, 20);
            this.lbProveedor.TabIndex = 6;
            this.lbProveedor.Text = "Proveedor:";
            // 
            // tbProveedor
            // 
            this.tbProveedor.Location = new System.Drawing.Point(176, 120);
            this.tbProveedor.Name = "tbProveedor";
            this.tbProveedor.Size = new System.Drawing.Size(150, 22);
            this.tbProveedor.TabIndex = 7;
            // 
            // lbCodigo
            // 
            this.lbCodigo.Location = new System.Drawing.Point(30, 150);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(150, 20);
            this.lbCodigo.TabIndex = 8;
            this.lbCodigo.Text = "Código:";
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(176, 150);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(150, 22);
            this.tbCodigo.TabIndex = 9;
            // 
            // btAgregarProd
            // 
            this.btAgregarProd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btAgregarProd.BackgroundImage")));
            this.btAgregarProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btAgregarProd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btAgregarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAgregarProd.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.btAgregarProd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btAgregarProd.Location = new System.Drawing.Point(39, 226);
            this.btAgregarProd.Name = "btAgregarProd";
            this.btAgregarProd.Size = new System.Drawing.Size(75, 30);
            this.btAgregarProd.TabIndex = 10;
            this.btAgregarProd.Text = "Agregar";
            // 
            // btModificarProd
            // 
            this.btModificarProd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btModificarProd.BackgroundImage")));
            this.btModificarProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btModificarProd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btModificarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btModificarProd.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.btModificarProd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btModificarProd.Location = new System.Drawing.Point(139, 226);
            this.btModificarProd.Name = "btModificarProd";
            this.btModificarProd.Size = new System.Drawing.Size(75, 30);
            this.btModificarProd.TabIndex = 11;
            this.btModificarProd.Text = "Modificar";
            // 
            // btEliminarProd
            // 
            this.btEliminarProd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btEliminarProd.BackgroundImage")));
            this.btEliminarProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btEliminarProd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btEliminarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEliminarProd.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.btEliminarProd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btEliminarProd.Location = new System.Drawing.Point(239, 226);
            this.btEliminarProd.Name = "btEliminarProd";
            this.btEliminarProd.Size = new System.Drawing.Size(75, 30);
            this.btEliminarProd.TabIndex = 12;
            this.btEliminarProd.Text = "Guardar";
            // 
            // gbTabla
            // 
            this.gbTabla.BackColor = System.Drawing.Color.Transparent;
            this.gbTabla.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbTabla.BackgroundImage")));
            this.gbTabla.Controls.Add(this.btConsultar);
            this.gbTabla.Controls.Add(this.btLimpiar);
            this.gbTabla.Controls.Add(this.dgvTabla);
            this.gbTabla.Location = new System.Drawing.Point(416, 57);
            this.gbTabla.Name = "gbTabla";
            this.gbTabla.Size = new System.Drawing.Size(400, 368);
            this.gbTabla.TabIndex = 5;
            this.gbTabla.TabStop = false;
            // 
            // btConsultar
            // 
            this.btConsultar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btConsultar.BackgroundImage")));
            this.btConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btConsultar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConsultar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.btConsultar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btConsultar.Location = new System.Drawing.Point(35, 15);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(90, 30);
            this.btConsultar.TabIndex = 0;
            this.btConsultar.Text = "Consultar";
            // 
            // btLimpiar
            // 
            this.btLimpiar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btLimpiar.BackgroundImage")));
            this.btLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLimpiar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.btLimpiar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btLimpiar.Location = new System.Drawing.Point(131, 15);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(94, 30);
            this.btLimpiar.TabIndex = 1;
            this.btLimpiar.Text = "Limpiar";
            // 
            // dgvTabla
            // 
            this.dgvTabla.BackgroundColor = System.Drawing.Color.DarkGreen;
            this.dgvTabla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTabla.Location = new System.Drawing.Point(5, 50);
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.Size = new System.Drawing.Size(390, 275);
            this.dgvTabla.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkGreen;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(8, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 34);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGreen;
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(843, 39);
            this.panel1.TabIndex = 8;
            // 
            // lbCategoria
            // 
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.Location = new System.Drawing.Point(30, 186);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(72, 16);
            this.lbCategoria.TabIndex = 13;
            this.lbCategoria.Text = "Categoria: ";
            // 
            // CmbCategoria
            // 
            this.CmbCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbCategoria.FormattingEnabled = true;
            this.CmbCategoria.Location = new System.Drawing.Point(178, 181);
            this.CmbCategoria.Name = "CmbCategoria";
            this.CmbCategoria.Size = new System.Drawing.Size(147, 24);
            this.CmbCategoria.TabIndex = 14;
            // 
            // InterfazDeAdministracionDeStock
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(840, 439);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbWelcome);
            this.Controls.Add(this.gbAdmin);
            this.Controls.Add(this.gbInforme);
            this.Controls.Add(this.gbTabla);
            this.Controls.Add(this.panel1);
            this.Name = "InterfazDeAdministracionDeStock";
            this.Text = "Sistema de Gestión de Inventario";
            this.gbInforme.ResumeLayout(false);
            this.gbAdmin.ResumeLayout(false);
            this.gbAdmin.PerformLayout();
            this.gbTabla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdmUsuarios;
        private System.Windows.Forms.Button btnGenerarInforme;
        private System.Windows.Forms.GroupBox gbInforme;
        private System.Windows.Forms.Label lbWelcome;
        private System.Windows.Forms.GroupBox gbAdmin;
        private System.Windows.Forms.Label lbNomProducto;
        private System.Windows.Forms.TextBox tbNomProducto;
        private System.Windows.Forms.Label lbCantidad;
        private System.Windows.Forms.TextBox tbCantidad;
        private System.Windows.Forms.Label lbPreUnitario;
        private System.Windows.Forms.TextBox tbPreUnitario;
        private System.Windows.Forms.Label lbProveedor;
        private System.Windows.Forms.TextBox tbProveedor;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Button btAgregarProd;
        private System.Windows.Forms.Button btModificarProd;
        private System.Windows.Forms.Button btEliminarProd;
        private System.Windows.Forms.GroupBox gbTabla;
        private System.Windows.Forms.Button btConsultar;
        private System.Windows.Forms.Button btLimpiar;
        private System.Windows.Forms.DataGridView dgvTabla;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbCategoria;
        private System.Windows.Forms.ComboBox CmbCategoria;
    }
}