namespace ProductosDB
{
    partial class Form1
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
            this.CboCategoria = new System.Windows.Forms.ComboBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.btnReporte = new System.Windows.Forms.Button();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblStockActual = new System.Windows.Forms.Label();
            this.lblMedida = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtStockActual = new System.Windows.Forms.TextBox();
            this.txtBuscador = new System.Windows.Forms.TextBox();
            this.txtMedida = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // CboCategoria
            // 
            this.CboCategoria.FormattingEnabled = true;
            this.CboCategoria.Location = new System.Drawing.Point(477, 184);
            this.CboCategoria.Name = "CboCategoria";
            this.CboCategoria.Size = new System.Drawing.Size(158, 28);
            this.CboCategoria.TabIndex = 115;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(477, 239);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(158, 26);
            this.txtDescripcion.TabIndex = 114;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(366, 245);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(92, 20);
            this.lblDescripcion.TabIndex = 113;
            this.lblDescripcion.Text = "Descripción";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(477, 134);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(158, 26);
            this.txtPrecio.TabIndex = 112;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(405, 134);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(53, 20);
            this.lblPrecio.TabIndex = 111;
            this.lblPrecio.Text = "Precio";
            // 
            // btnReporte
            // 
            this.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporte.Location = new System.Drawing.Point(379, 622);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(112, 38);
            this.btnReporte.TabIndex = 110;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(380, 186);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(78, 20);
            this.lblCategoria.TabIndex = 109;
            this.lblCategoria.Text = "Categoria";
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(704, 579);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 36);
            this.btnCancelar.TabIndex = 108;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Location = new System.Drawing.Point(704, 522);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(112, 38);
            this.BtnGuardar.TabIndex = 107;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(68, 186);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(53, 20);
            this.lblMarca.TabIndex = 106;
            this.lblMarca.Text = "Marca";
            // 
            // lblStockActual
            // 
            this.lblStockActual.AutoSize = true;
            this.lblStockActual.Location = new System.Drawing.Point(26, 277);
            this.lblStockActual.Name = "lblStockActual";
            this.lblStockActual.Size = new System.Drawing.Size(95, 20);
            this.lblStockActual.TabIndex = 105;
            this.lblStockActual.Text = "StockActual";
            // 
            // lblMedida
            // 
            this.lblMedida.AutoSize = true;
            this.lblMedida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMedida.Location = new System.Drawing.Point(60, 239);
            this.lblMedida.Name = "lblMedida";
            this.lblMedida.Size = new System.Drawing.Size(61, 20);
            this.lblMedida.TabIndex = 104;
            this.lblMedida.Text = "Medida";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(147, 277);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(158, 26);
            this.txtMarca.TabIndex = 103;
            // 
            // txtStockActual
            // 
            this.txtStockActual.Location = new System.Drawing.Point(147, 233);
            this.txtStockActual.Name = "txtStockActual";
            this.txtStockActual.Size = new System.Drawing.Size(158, 26);
            this.txtStockActual.TabIndex = 102;
            // 
            // txtBuscador
            // 
            this.txtBuscador.Location = new System.Drawing.Point(110, 340);
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.Size = new System.Drawing.Size(499, 26);
            this.txtBuscador.TabIndex = 101;
            // 
            // txtMedida
            // 
            this.txtMedida.Location = new System.Drawing.Point(147, 184);
            this.txtMedida.Name = "txtMedida";
            this.txtMedida.Size = new System.Drawing.Size(158, 26);
            this.txtMedida.TabIndex = 100;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(147, 135);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(158, 26);
            this.txtNombre.TabIndex = 99;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(48, 135);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(73, 20);
            this.lblProducto.TabIndex = 98;
            this.lblProducto.Text = "Producto";
            // 
            // DGV
            // 
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Location = new System.Drawing.Point(24, 372);
            this.DGV.Name = "DGV";
            this.DGV.RowHeadersWidth = 62;
            this.DGV.RowTemplate.Height = 28;
            this.DGV.Size = new System.Drawing.Size(673, 243);
            this.DGV.TabIndex = 97;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExit.Location = new System.Drawing.Point(497, 621);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 39);
            this.btnExit.TabIndex = 96;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(23, 340);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 26);
            this.btnBuscar.TabIndex = 95;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(259, 622);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 36);
            this.btnDelete.TabIndex = 94;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnactualizar
            // 
            this.btnactualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnactualizar.Location = new System.Drawing.Point(141, 622);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(112, 36);
            this.btnactualizar.TabIndex = 93;
            this.btnactualizar.Text = "Actualizar";
            this.btnactualizar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Location = new System.Drawing.Point(23, 621);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(112, 36);
            this.btnNuevo.TabIndex = 92;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 683);
            this.Controls.Add(this.CboCategoria);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblStockActual);
            this.Controls.Add(this.lblMedida);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtStockActual);
            this.Controls.Add(this.txtBuscador);
            this.Controls.Add(this.txtMedida);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.btnNuevo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CboCategoria;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblStockActual;
        private System.Windows.Forms.Label lblMedida;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtStockActual;
        private System.Windows.Forms.TextBox txtBuscador;
        private System.Windows.Forms.TextBox txtMedida;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.Button btnNuevo;
    }
}

