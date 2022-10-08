namespace Frontend
{
    partial class FrmInventario
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnVentas = new System.Windows.Forms.Button();
            this.lblCantLimpieza = new System.Windows.Forms.Label();
            this.lblCantBebidas = new System.Windows.Forms.Label();
            this.lblCantAlimentos = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            this.lblAlimentos = new System.Windows.Forms.Label();
            this.lblLimpieza = new System.Windows.Forms.Label();
            this.lblBebidas = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cmbCategorias = new System.Windows.Forms.ComboBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVentas
            // 
            this.btnVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.Location = new System.Drawing.Point(20, 289);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(85, 30);
            this.btnVentas.TabIndex = 37;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.UseVisualStyleBackColor = true;
            // 
            // lblCantLimpieza
            // 
            this.lblCantLimpieza.AutoSize = true;
            this.lblCantLimpieza.Location = new System.Drawing.Point(179, 263);
            this.lblCantLimpieza.Name = "lblCantLimpieza";
            this.lblCantLimpieza.Size = new System.Drawing.Size(0, 13);
            this.lblCantLimpieza.TabIndex = 36;
            // 
            // lblCantBebidas
            // 
            this.lblCantBebidas.AutoSize = true;
            this.lblCantBebidas.Location = new System.Drawing.Point(88, 240);
            this.lblCantBebidas.Name = "lblCantBebidas";
            this.lblCantBebidas.Size = new System.Drawing.Size(0, 13);
            this.lblCantBebidas.TabIndex = 35;
            // 
            // lblCantAlimentos
            // 
            this.lblCantAlimentos.AutoSize = true;
            this.lblCantAlimentos.Location = new System.Drawing.Point(179, 218);
            this.lblCantAlimentos.Name = "lblCantAlimentos";
            this.lblCantAlimentos.Size = new System.Drawing.Size(0, 13);
            this.lblCantAlimentos.TabIndex = 34;
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.Location = new System.Drawing.Point(13, 183);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(152, 20);
            this.LblTotal.TabIndex = 33;
            this.LblTotal.Text = "Totales cargados:";
            // 
            // lblAlimentos
            // 
            this.lblAlimentos.AutoSize = true;
            this.lblAlimentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlimentos.Location = new System.Drawing.Point(19, 214);
            this.lblAlimentos.Name = "lblAlimentos";
            this.lblAlimentos.Size = new System.Drawing.Size(154, 17);
            this.lblAlimentos.TabIndex = 32;
            this.lblAlimentos.Text = "Productos Alimenticios:";
            // 
            // lblLimpieza
            // 
            this.lblLimpieza.AutoSize = true;
            this.lblLimpieza.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLimpieza.Location = new System.Drawing.Point(17, 259);
            this.lblLimpieza.Name = "lblLimpieza";
            this.lblLimpieza.Size = new System.Drawing.Size(156, 17);
            this.lblLimpieza.TabIndex = 31;
            this.lblLimpieza.Text = "Productos de Limpieza:";
            // 
            // lblBebidas
            // 
            this.lblBebidas.AutoSize = true;
            this.lblBebidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBebidas.Location = new System.Drawing.Point(19, 236);
            this.lblBebidas.Name = "lblBebidas";
            this.lblBebidas.Size = new System.Drawing.Size(63, 17);
            this.lblBebidas.TabIndex = 30;
            this.lblBebidas.Text = "Bebidas:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(13, 88);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(69, 17);
            this.lblCategoria.TabIndex = 29;
            this.lblCategoria.Text = "Categoria";
            // 
            // cmbCategorias
            // 
            this.cmbCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategorias.FormattingEnabled = true;
            this.cmbCategorias.Items.AddRange(new object[] {
            "Alimentos",
            "Bebidas",
            "Limpieza"});
            this.cmbCategorias.Location = new System.Drawing.Point(84, 87);
            this.cmbCategorias.Name = "cmbCategorias";
            this.cmbCategorias.Size = new System.Drawing.Size(100, 21);
            this.cmbCategorias.TabIndex = 28;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(99, 123);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(85, 30);
            this.btnBorrar.TabIndex = 27;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(13, 123);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(85, 30);
            this.btnAceptar.TabIndex = 26;
            this.btnAceptar.Text = "Cargar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(84, 61);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 25;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(12, 61);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(48, 17);
            this.lblPrecio.TabIndex = 24;
            this.lblPrecio.Text = "Precio";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(84, 35);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 23;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(12, 35);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 17);
            this.lblNombre.TabIndex = 22;
            this.lblNombre.Text = "Nombre";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(84, 9);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 21;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(12, 9);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(52, 17);
            this.lblCodigo.TabIndex = 20;
            this.lblCodigo.Text = "Codigo";
            // 
            // dgvInventario
            // 
            this.dgvInventario.AllowUserToAddRows = false;
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventario.Location = new System.Drawing.Point(212, 9);
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.Size = new System.Drawing.Size(576, 310);
            this.dgvInventario.TabIndex = 38;
            // 
            // FrmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 335);
            this.Controls.Add(this.dgvInventario);
            this.Controls.Add(this.btnVentas);
            this.Controls.Add(this.lblCantLimpieza);
            this.Controls.Add(this.lblCantBebidas);
            this.Controls.Add(this.lblCantAlimentos);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.lblAlimentos);
            this.Controls.Add(this.lblLimpieza);
            this.Controls.Add(this.lblBebidas);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.cmbCategorias);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Name = "FrmInventario";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Label lblCantLimpieza;
        private System.Windows.Forms.Label lblCantBebidas;
        private System.Windows.Forms.Label lblCantAlimentos;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Label lblAlimentos;
        private System.Windows.Forms.Label lblLimpieza;
        private System.Windows.Forms.Label lblBebidas;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cmbCategorias;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.DataGridView dgvInventario;
    }
}

