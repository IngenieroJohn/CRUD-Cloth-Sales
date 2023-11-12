namespace MyStrategyCloth.Views
{
    partial class InterfazDeGestionDeVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterfazDeGestionDeVenta));
            this.lbWelcome = new System.Windows.Forms.Label();
            this.listaProductos = new System.Windows.Forms.ListBox();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.cantidadProducto = new System.Windows.Forms.NumericUpDown();
            this.labelTotalPagar = new System.Windows.Forms.Label();
            this.totalPagar = new System.Windows.Forms.TextBox();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.CmbCategoria = new System.Windows.Forms.ComboBox();
            this.confirmarVenta = new System.Windows.Forms.Button();
            this.cancelarVenta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // lbWelcome
            // 
            this.lbWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lbWelcome.Font = new System.Drawing.Font("Bebas", 14.25F);
            this.lbWelcome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbWelcome.Location = new System.Drawing.Point(155, 20);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(228, 29);
            this.lbWelcome.TabIndex = 10;
            this.lbWelcome.Text = "<<< Bienvenido Vendedor >>>";
            this.lbWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listaProductos
            // 
            this.listaProductos.BackColor = System.Drawing.Color.YellowGreen;
            this.listaProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listaProductos.Location = new System.Drawing.Point(287, 69);
            this.listaProductos.Name = "listaProductos";
            this.listaProductos.Size = new System.Drawing.Size(249, 312);
            this.listaProductos.TabIndex = 11;
            // 
            // labelCantidad
            // 
            this.labelCantidad.BackColor = System.Drawing.Color.Transparent;
            this.labelCantidad.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.labelCantidad.Location = new System.Drawing.Point(33, 82);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(80, 20);
            this.labelCantidad.TabIndex = 12;
            this.labelCantidad.Text = "Cantidad:";
            // 
            // cantidadProducto
            // 
            this.cantidadProducto.Location = new System.Drawing.Point(143, 82);
            this.cantidadProducto.Name = "cantidadProducto";
            this.cantidadProducto.Size = new System.Drawing.Size(60, 20);
            this.cantidadProducto.TabIndex = 13;
            // 
            // labelTotalPagar
            // 
            this.labelTotalPagar.BackColor = System.Drawing.Color.Transparent;
            this.labelTotalPagar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.labelTotalPagar.Location = new System.Drawing.Point(33, 122);
            this.labelTotalPagar.Name = "labelTotalPagar";
            this.labelTotalPagar.Size = new System.Drawing.Size(100, 20);
            this.labelTotalPagar.TabIndex = 14;
            this.labelTotalPagar.Text = "Total a Pagar:";
            // 
            // totalPagar
            // 
            this.totalPagar.Location = new System.Drawing.Point(143, 122);
            this.totalPagar.Name = "totalPagar";
            this.totalPagar.Size = new System.Drawing.Size(100, 20);
            this.totalPagar.TabIndex = 15;
            // 
            // lbCategoria
            // 
            this.lbCategoria.BackColor = System.Drawing.Color.Transparent;
            this.lbCategoria.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.lbCategoria.Location = new System.Drawing.Point(33, 162);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(100, 20);
            this.lbCategoria.TabIndex = 16;
            this.lbCategoria.Text = "Categoria:";
            // 
            // CmbCategoria
            // 
            this.CmbCategoria.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta de Crédito",
            "Otro"});
            this.CmbCategoria.Location = new System.Drawing.Point(143, 162);
            this.CmbCategoria.Name = "CmbCategoria";
            this.CmbCategoria.Size = new System.Drawing.Size(120, 21);
            this.CmbCategoria.TabIndex = 17;
            // 
            // confirmarVenta
            // 
            this.confirmarVenta.BackColor = System.Drawing.Color.Transparent;
            this.confirmarVenta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("confirmarVenta.BackgroundImage")));
            this.confirmarVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.confirmarVenta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.confirmarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmarVenta.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.confirmarVenta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.confirmarVenta.Location = new System.Drawing.Point(36, 231);
            this.confirmarVenta.Name = "confirmarVenta";
            this.confirmarVenta.Size = new System.Drawing.Size(120, 30);
            this.confirmarVenta.TabIndex = 18;
            this.confirmarVenta.Text = "Confirmar Venta";
            this.confirmarVenta.UseVisualStyleBackColor = false;
            // 
            // cancelarVenta
            // 
            this.cancelarVenta.BackColor = System.Drawing.Color.Transparent;
            this.cancelarVenta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancelarVenta.BackgroundImage")));
            this.cancelarVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancelarVenta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cancelarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelarVenta.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.cancelarVenta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancelarVenta.Location = new System.Drawing.Point(36, 291);
            this.cancelarVenta.Name = "cancelarVenta";
            this.cancelarVenta.Size = new System.Drawing.Size(120, 30);
            this.cancelarVenta.TabIndex = 19;
            this.cancelarVenta.Text = "Cancelar Venta";
            this.cancelarVenta.UseVisualStyleBackColor = false;
            // 
            // InterfazDeGestionDeVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(568, 395);
            this.Controls.Add(this.lbWelcome);
            this.Controls.Add(this.listaProductos);
            this.Controls.Add(this.labelCantidad);
            this.Controls.Add(this.cantidadProducto);
            this.Controls.Add(this.labelTotalPagar);
            this.Controls.Add(this.totalPagar);
            this.Controls.Add(this.lbCategoria);
            this.Controls.Add(this.CmbCategoria);
            this.Controls.Add(this.confirmarVenta);
            this.Controls.Add(this.cancelarVenta);
            this.Name = "InterfazDeGestionDeVenta";
            this.Text = "InterfazDeGestionDeVenta";
            this.Load += new System.EventHandler(this.InterfazDeGestionDeVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cantidadProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbWelcome;
        private System.Windows.Forms.ListBox listaProductos;
        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.NumericUpDown cantidadProducto;
        private System.Windows.Forms.Label labelTotalPagar;
        private System.Windows.Forms.TextBox totalPagar;
        private System.Windows.Forms.Label lbCategoria;
        private System.Windows.Forms.ComboBox CmbCategoria;
        private System.Windows.Forms.Button confirmarVenta;
        private System.Windows.Forms.Button cancelarVenta;
    }
}