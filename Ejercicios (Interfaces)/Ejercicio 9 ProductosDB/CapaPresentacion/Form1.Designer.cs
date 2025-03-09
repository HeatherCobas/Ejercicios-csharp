namespace CapaPresentacion
{
    partial class Form_P
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_P));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMedida = new System.Windows.Forms.ComboBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
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
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtBuscador = new System.Windows.Forms.TextBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.Id_Prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Me = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_cat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(877, 100);
            this.panel1.TabIndex = 166;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OliveDrab;
            this.label1.Location = new System.Drawing.Point(39, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(771, 50);
            this.label1.TabIndex = 143;
            this.label1.Text = "MANTENIMIENTO DE PRODUCTO";
            // 
            // cmbMedida
            // 
            this.cmbMedida.FormattingEnabled = true;
            this.cmbMedida.Location = new System.Drawing.Point(220, 221);
            this.cmbMedida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbMedida.Name = "cmbMedida";
            this.cmbMedida.Size = new System.Drawing.Size(158, 28);
            this.cmbMedida.TabIndex = 165;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(550, 178);
            this.cmbCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(158, 28);
            this.cmbCategoria.TabIndex = 164;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(550, 232);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(158, 26);
            this.txtDescripcion.TabIndex = 163;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.lblDescripcion.Font = new System.Drawing.Font("Baskerville Old Face", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblDescripcion.Location = new System.Drawing.Point(438, 235);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(93, 21);
            this.lblDescripcion.TabIndex = 162;
            this.lblDescripcion.Text = "Descripción";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(550, 128);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(158, 26);
            this.txtPrecio.TabIndex = 161;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecio.Font = new System.Drawing.Font("Baskerville Old Face", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblPrecio.Location = new System.Drawing.Point(477, 128);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(54, 21);
            this.lblPrecio.TabIndex = 160;
            this.lblPrecio.Text = "Precio";
            // 
            // btnReporte
            // 
            this.btnReporte.BackColor = System.Drawing.Color.OliveDrab;
            this.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporte.Font = new System.Drawing.Font("Baskerville Old Face", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnReporte.Location = new System.Drawing.Point(390, 622);
            this.btnReporte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(112, 35);
            this.btnReporte.TabIndex = 159;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.UseVisualStyleBackColor = false;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.BackColor = System.Drawing.Color.Transparent;
            this.lblCategoria.Font = new System.Drawing.Font("Baskerville Old Face", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblCategoria.Location = new System.Drawing.Point(454, 181);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(77, 21);
            this.lblCategoria.TabIndex = 158;
            this.lblCategoria.Text = "Categoria";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.OliveDrab;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Baskerville Old Face", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCancelar.Location = new System.Drawing.Point(626, 622);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 35);
            this.btnCancelar.TabIndex = 157;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.OliveDrab;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("Baskerville Old Face", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BtnGuardar.Location = new System.Drawing.Point(508, 622);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(112, 35);
            this.BtnGuardar.TabIndex = 156;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.BackColor = System.Drawing.Color.Transparent;
            this.lblMarca.Font = new System.Drawing.Font("Baskerville Old Face", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblMarca.Location = new System.Drawing.Point(141, 179);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(61, 23);
            this.lblMarca.TabIndex = 155;
            this.lblMarca.Text = "Marca";
            // 
            // lblStockActual
            // 
            this.lblStockActual.AutoSize = true;
            this.lblStockActual.BackColor = System.Drawing.Color.Transparent;
            this.lblStockActual.Font = new System.Drawing.Font("Baskerville Old Face", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockActual.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblStockActual.Location = new System.Drawing.Point(144, 280);
            this.lblStockActual.Name = "lblStockActual";
            this.lblStockActual.Size = new System.Drawing.Size(53, 23);
            this.lblStockActual.TabIndex = 154;
            this.lblStockActual.Text = "Stock";
            // 
            // lblMedida
            // 
            this.lblMedida.AutoSize = true;
            this.lblMedida.BackColor = System.Drawing.Color.Transparent;
            this.lblMedida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMedida.Font = new System.Drawing.Font("Baskerville Old Face", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedida.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblMedida.Location = new System.Drawing.Point(133, 232);
            this.lblMedida.Name = "lblMedida";
            this.lblMedida.Size = new System.Drawing.Size(71, 23);
            this.lblMedida.TabIndex = 153;
            this.lblMedida.Text = "Medida";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(220, 172);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(158, 26);
            this.txtMarca.TabIndex = 152;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(220, 274);
            this.txtStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(158, 26);
            this.txtStock.TabIndex = 151;
            // 
            // txtBuscador
            // 
            this.txtBuscador.Location = new System.Drawing.Point(152, 332);
            this.txtBuscador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.Size = new System.Drawing.Size(575, 26);
            this.txtBuscador.TabIndex = 150;
            this.txtBuscador.TextChanged += new System.EventHandler(this.txtBuscador_TextChanged);
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(220, 128);
            this.txtProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(158, 26);
            this.txtProducto.TabIndex = 149;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.BackColor = System.Drawing.Color.Transparent;
            this.lblProducto.Font = new System.Drawing.Font("Baskerville Old Face", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblProducto.Location = new System.Drawing.Point(121, 128);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(82, 23);
            this.lblProducto.TabIndex = 148;
            this.lblProducto.Text = "Producto";
            // 
            // DGV
            // 
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Prod,
            this.Nombre_Prod,
            this.Marca,
            this.Nombre_Me,
            this.Stock,
            this.Precio,
            this.Nombre_cat,
            this.Descripcion});
            this.DGV.Location = new System.Drawing.Point(95, 362);
            this.DGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGV.Name = "DGV";
            this.DGV.RowHeadersWidth = 62;
            this.DGV.RowTemplate.Height = 28;
            this.DGV.Size = new System.Drawing.Size(682, 249);
            this.DGV.TabIndex = 147;
            this.DGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellClick);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Baskerville Old Face", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExit.Location = new System.Drawing.Point(744, 621);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 36);
            this.btnExit.TabIndex = 146;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.OliveDrab;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Baskerville Old Face", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnDelete.Location = new System.Drawing.Point(270, 622);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 36);
            this.btnDelete.TabIndex = 145;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnactualizar
            // 
            this.btnactualizar.BackColor = System.Drawing.Color.OliveDrab;
            this.btnactualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnactualizar.Font = new System.Drawing.Font("Baskerville Old Face", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactualizar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnactualizar.Location = new System.Drawing.Point(152, 622);
            this.btnactualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(112, 36);
            this.btnactualizar.TabIndex = 144;
            this.btnactualizar.Text = "Actualizar";
            this.btnactualizar.UseVisualStyleBackColor = false;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.OliveDrab;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Baskerville Old Face", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnNuevo.Location = new System.Drawing.Point(34, 621);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(112, 36);
            this.btnNuevo.TabIndex = 143;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // Id_Prod
            // 
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.Id_Prod.DefaultCellStyle = dataGridViewCellStyle1;
            this.Id_Prod.HeaderText = "Id_Prod";
            this.Id_Prod.MinimumWidth = 8;
            this.Id_Prod.Name = "Id_Prod";
            this.Id_Prod.Width = 150;
            // 
            // Nombre_Prod
            // 
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.Nombre_Prod.DefaultCellStyle = dataGridViewCellStyle2;
            this.Nombre_Prod.HeaderText = "Producto";
            this.Nombre_Prod.MinimumWidth = 8;
            this.Nombre_Prod.Name = "Nombre_Prod";
            this.Nombre_Prod.Width = 150;
            // 
            // Marca
            // 
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.Marca.DefaultCellStyle = dataGridViewCellStyle3;
            this.Marca.HeaderText = "Marca";
            this.Marca.MinimumWidth = 8;
            this.Marca.Name = "Marca";
            this.Marca.Width = 150;
            // 
            // Nombre_Me
            // 
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.Nombre_Me.DefaultCellStyle = dataGridViewCellStyle4;
            this.Nombre_Me.HeaderText = "Medida";
            this.Nombre_Me.MinimumWidth = 8;
            this.Nombre_Me.Name = "Nombre_Me";
            this.Nombre_Me.Width = 150;
            // 
            // Stock
            // 
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.Stock.DefaultCellStyle = dataGridViewCellStyle5;
            this.Stock.HeaderText = "Stock";
            this.Stock.MinimumWidth = 8;
            this.Stock.Name = "Stock";
            this.Stock.Width = 150;
            // 
            // Precio
            // 
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.Precio.DefaultCellStyle = dataGridViewCellStyle6;
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 8;
            this.Precio.Name = "Precio";
            this.Precio.Width = 150;
            // 
            // Nombre_cat
            // 
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.Nombre_cat.DefaultCellStyle = dataGridViewCellStyle7;
            this.Nombre_cat.HeaderText = "Categoria";
            this.Nombre_cat.MinimumWidth = 8;
            this.Nombre_cat.Name = "Nombre_cat";
            this.Nombre_cat.Width = 150;
            // 
            // Descripcion
            // 
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            this.Descripcion.DefaultCellStyle = dataGridViewCellStyle8;
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.MinimumWidth = 8;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 150;
            // 
            // Form_P
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapaPresentacion.Properties.Resources.Color_tipo_oliva;
            this.ClientSize = new System.Drawing.Size(877, 678);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmbMedida);
            this.Controls.Add(this.cmbCategoria);
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
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtBuscador);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.btnNuevo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_P";
            this.Text = "Productos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMedida;
        private System.Windows.Forms.ComboBox cmbCategoria;
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
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtBuscador;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Me;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_cat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
    }
}

