namespace Act.Inicio_de_Sesion
{
    partial class FrmMensajesSoporte
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
            this.dgvMensajes = new System.Windows.Forms.DataGridView();
            this.pnlDetalle = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFechaRespuesta = new System.Windows.Forms.DateTimePicker();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblEstadoValor = new System.Windows.Forms.Label();
            this.lblFechaEnvio = new System.Windows.Forms.Label();
            this.lblFechaEnvioValor = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblUsuarioValor = new System.Windows.Forms.Label();
            this.lblAsunto = new System.Windows.Forms.Label();
            this.txtAsunto = new System.Windows.Forms.TextBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnResponder = new System.Windows.Forms.Button();
            this.txtRespuesta = new System.Windows.Forms.TextBox();
            this.lblRespuesta = new System.Windows.Forms.Label();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMensajes)).BeginInit();
            this.pnlDetalle.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMensajes
            // 
            this.dgvMensajes.AllowUserToAddRows = false;
            this.dgvMensajes.AllowUserToDeleteRows = false;
            this.dgvMensajes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMensajes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMensajes.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvMensajes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMensajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMensajes.Location = new System.Drawing.Point(20, 70);
            this.dgvMensajes.MultiSelect = false;
            this.dgvMensajes.Name = "dgvMensajes";
            this.dgvMensajes.ReadOnly = true;
            this.dgvMensajes.RowHeadersWidth = 51;
            this.dgvMensajes.RowTemplate.Height = 24;
            this.dgvMensajes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMensajes.Size = new System.Drawing.Size(934, 200);
            this.dgvMensajes.TabIndex = 0;
            this.dgvMensajes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMensajes_CellContentClick);
            // 
            // pnlDetalle
            // 
            this.pnlDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDetalle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlDetalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDetalle.Controls.Add(this.lblFecha);
            this.pnlDetalle.Controls.Add(this.dtpFechaRespuesta);
            this.pnlDetalle.Controls.Add(this.lblEstado);
            this.pnlDetalle.Controls.Add(this.lblEstadoValor);
            this.pnlDetalle.Controls.Add(this.lblFechaEnvio);
            this.pnlDetalle.Controls.Add(this.lblFechaEnvioValor);
            this.pnlDetalle.Controls.Add(this.lblUsuario);
            this.pnlDetalle.Controls.Add(this.lblUsuarioValor);
            this.pnlDetalle.Controls.Add(this.lblAsunto);
            this.pnlDetalle.Controls.Add(this.txtAsunto);
            this.pnlDetalle.Controls.Add(this.lblMensaje);
            this.pnlDetalle.Controls.Add(this.txtMensaje);
            this.pnlDetalle.Location = new System.Drawing.Point(20, 343);
            this.pnlDetalle.Name = "pnlDetalle";
            this.pnlDetalle.Size = new System.Drawing.Size(456, 400);
            this.pnlDetalle.TabIndex = 1;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(16, 367);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(121, 20);
            this.lblFecha.TabIndex = 11;
            this.lblFecha.Text = "Fecha Respuesta:";
            // 
            // dtpFechaRespuesta
            // 
            this.dtpFechaRespuesta.Enabled = false;
            this.dtpFechaRespuesta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaRespuesta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaRespuesta.Location = new System.Drawing.Point(146, 362);
            this.dtpFechaRespuesta.Name = "dtpFechaRespuesta";
            this.dtpFechaRespuesta.Size = new System.Drawing.Size(124, 27);
            this.dtpFechaRespuesta.TabIndex = 10;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(17, 81);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(57, 20);
            this.lblEstado.TabIndex = 9;
            this.lblEstado.Text = "Estado:";
            // 
            // lblEstadoValor
            // 
            this.lblEstadoValor.AutoSize = true;
            this.lblEstadoValor.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEstadoValor.Location = new System.Drawing.Point(142, 81);
            this.lblEstadoValor.Name = "lblEstadoValor";
            this.lblEstadoValor.Size = new System.Drawing.Size(107, 20);
            this.lblEstadoValor.TabIndex = 8;
            this.lblEstadoValor.Text = "Sin Responder";
            // 
            // lblFechaEnvio
            // 
            this.lblFechaEnvio.AutoSize = true;
            this.lblFechaEnvio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaEnvio.Location = new System.Drawing.Point(17, 52);
            this.lblFechaEnvio.Name = "lblFechaEnvio";
            this.lblFechaEnvio.Size = new System.Drawing.Size(90, 20);
            this.lblFechaEnvio.TabIndex = 7;
            this.lblFechaEnvio.Text = "Fecha Envío:";
            // 
            // lblFechaEnvioValor
            // 
            this.lblFechaEnvioValor.AutoSize = true;
            this.lblFechaEnvioValor.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaEnvioValor.Location = new System.Drawing.Point(142, 52);
            this.lblFechaEnvioValor.Name = "lblFechaEnvioValor";
            this.lblFechaEnvioValor.Size = new System.Drawing.Size(111, 20);
            this.lblFechaEnvioValor.TabIndex = 6;
            this.lblFechaEnvioValor.Text = "DD/MM/AAAA";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(17, 23);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(62, 20);
            this.lblUsuario.TabIndex = 5;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblUsuarioValor
            // 
            this.lblUsuarioValor.AutoSize = true;
            this.lblUsuarioValor.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioValor.Location = new System.Drawing.Point(142, 23);
            this.lblUsuarioValor.Name = "lblUsuarioValor";
            this.lblUsuarioValor.Size = new System.Drawing.Size(120, 20);
            this.lblUsuarioValor.TabIndex = 4;
            this.lblUsuarioValor.Text = "nombre_usuario";
            // 
            // lblAsunto
            // 
            this.lblAsunto.AutoSize = true;
            this.lblAsunto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsunto.Location = new System.Drawing.Point(17, 116);
            this.lblAsunto.Name = "lblAsunto";
            this.lblAsunto.Size = new System.Drawing.Size(58, 20);
            this.lblAsunto.TabIndex = 3;
            this.lblAsunto.Text = "Asunto:";
            // 
            // txtAsunto
            // 
            this.txtAsunto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAsunto.BackColor = System.Drawing.Color.White;
            this.txtAsunto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAsunto.Location = new System.Drawing.Point(93, 113);
            this.txtAsunto.Name = "txtAsunto";
            this.txtAsunto.ReadOnly = true;
            this.txtAsunto.Size = new System.Drawing.Size(344, 27);
            this.txtAsunto.TabIndex = 2;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(17, 151);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(67, 20);
            this.lblMensaje.TabIndex = 1;
            this.lblMensaje.Text = "Mensaje:";
            // 
            // txtMensaje
            // 
            this.txtMensaje.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMensaje.BackColor = System.Drawing.Color.White;
            this.txtMensaje.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMensaje.Location = new System.Drawing.Point(18, 174);
            this.txtMensaje.Multiline = true;
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.ReadOnly = true;
            this.txtMensaje.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMensaje.Size = new System.Drawing.Size(419, 182);
            this.txtMensaje.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnResponder);
            this.panel1.Controls.Add(this.txtRespuesta);
            this.panel1.Controls.Add(this.lblRespuesta);
            this.panel1.Location = new System.Drawing.Point(497, 343);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 400);
            this.panel1.TabIndex = 2;
            // 
            // btnResponder
            // 
            this.btnResponder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResponder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnResponder.FlatAppearance.BorderSize = 0;
            this.btnResponder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResponder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResponder.ForeColor = System.Drawing.Color.White;
            this.btnResponder.Location = new System.Drawing.Point(317, 356);
            this.btnResponder.Name = "btnResponder";
            this.btnResponder.Size = new System.Drawing.Size(120, 33);
            this.btnResponder.TabIndex = 2;
            this.btnResponder.Text = "Responder";
            this.btnResponder.UseVisualStyleBackColor = false;
            // 
            // txtRespuesta
            // 
            this.txtRespuesta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRespuesta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRespuesta.Location = new System.Drawing.Point(18, 89);
            this.txtRespuesta.Multiline = true;
            this.txtRespuesta.Name = "txtRespuesta";
            this.txtRespuesta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRespuesta.Size = new System.Drawing.Size(419, 261);
            this.txtRespuesta.TabIndex = 1;
            // 
            // lblRespuesta
            // 
            this.lblRespuesta.AutoSize = true;
            this.lblRespuesta.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespuesta.Location = new System.Drawing.Point(14, 10);
            this.lblRespuesta.Name = "lblRespuesta";
            this.lblRespuesta.Size = new System.Drawing.Size(97, 25);
            this.lblRespuesta.TabIndex = 0;
            this.lblRespuesta.Text = "Respuesta";
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(974, 50);
            this.pnlTitulo.TabIndex = 3;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(22, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(316, 31);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Panel de Soporte - Mensajes";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(752, 288);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(98, 33);
            this.btnActualizar.TabIndex = 4;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(856, 288);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(98, 33);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FrmMensajesSoporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(974, 766);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlDetalle);
            this.Controls.Add(this.dgvMensajes);
            this.MinimumSize = new System.Drawing.Size(950, 670);
            this.Name = "FrmMensajesSoporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mensajes de Soporte";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMensajes)).EndInit();
            this.pnlDetalle.ResumeLayout(false);
            this.pnlDetalle.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMensajes;
        private System.Windows.Forms.Panel pnlDetalle;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnResponder;
        private System.Windows.Forms.TextBox txtRespuesta;
        private System.Windows.Forms.Label lblRespuesta;
        private System.Windows.Forms.Label lblAsunto;
        private System.Windows.Forms.TextBox txtAsunto;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblUsuarioValor;
        private System.Windows.Forms.Label lblFechaEnvio;
        private System.Windows.Forms.Label lblFechaEnvioValor;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblEstadoValor;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFechaRespuesta;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCerrar;
    }
}