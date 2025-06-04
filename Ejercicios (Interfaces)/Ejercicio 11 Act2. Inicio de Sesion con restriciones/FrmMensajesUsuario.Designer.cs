namespace Act.Inicio_de_Sesion
{
    partial class FrmMensajesUsuario
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
            this.TC_Mensaje_de_Usuario = new System.Windows.Forms.TabControl();
            this.TP_1 = new System.Windows.Forms.TabPage();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblMensajes_del_Usuario = new System.Windows.Forms.Label();
            this.LblNUsuario = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtContenido = new System.Windows.Forms.RichTextBox();
            this.lblContenido = new System.Windows.Forms.Label();
            this.txtAsunto = new System.Windows.Forms.TextBox();
            this.lblAsunto = new System.Windows.Forms.Label();
            this.TP_2 = new System.Windows.Forms.TabPage();
            this.Btn_Otro_M = new System.Windows.Forms.Button();
            this.RTB_Respuestas = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRespuesta = new System.Windows.Forms.Label();
            this.Dgv_Respuestas = new System.Windows.Forms.DataGridView();
            this.txtBuscador = new System.Windows.Forms.TextBox();
            this.lblFecha_R = new System.Windows.Forms.Label();
            this.lblFR = new System.Windows.Forms.Label();
            this.TC_Mensaje_de_Usuario.SuspendLayout();
            this.TP_1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.TP_2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Respuestas)).BeginInit();
            this.SuspendLayout();
            // 
            // TC_Mensaje_de_Usuario
            // 
            this.TC_Mensaje_de_Usuario.Controls.Add(this.TP_1);
            this.TC_Mensaje_de_Usuario.Controls.Add(this.TP_2);
            this.TC_Mensaje_de_Usuario.Location = new System.Drawing.Point(0, 0);
            this.TC_Mensaje_de_Usuario.Name = "TC_Mensaje_de_Usuario";
            this.TC_Mensaje_de_Usuario.SelectedIndex = 0;
            this.TC_Mensaje_de_Usuario.Size = new System.Drawing.Size(1062, 667);
            this.TC_Mensaje_de_Usuario.TabIndex = 11;
            // 
            // TP_1
            // 
            this.TP_1.BackColor = System.Drawing.Color.White;
            this.TP_1.Controls.Add(this.btnEnviar);
            this.TP_1.Controls.Add(this.btnCancelar);
            this.TP_1.Controls.Add(this.panel2);
            this.TP_1.Controls.Add(this.LblNUsuario);
            this.TP_1.Controls.Add(this.lblUsuario);
            this.TP_1.Controls.Add(this.txtContenido);
            this.TP_1.Controls.Add(this.lblContenido);
            this.TP_1.Controls.Add(this.txtAsunto);
            this.TP_1.Controls.Add(this.lblAsunto);
            this.TP_1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TP_1.Location = new System.Drawing.Point(4, 25);
            this.TP_1.Name = "TP_1";
            this.TP_1.Padding = new System.Windows.Forms.Padding(3);
            this.TP_1.Size = new System.Drawing.Size(1054, 638);
            this.TP_1.TabIndex = 0;
            this.TP_1.Text = "Mensajes";
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnEnviar.FlatAppearance.BorderSize = 0;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.ForeColor = System.Drawing.Color.White;
            this.btnEnviar.Location = new System.Drawing.Point(728, 551);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(140, 40);
            this.btnEnviar.TabIndex = 5;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(563, 551);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(140, 40);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel2.Controls.Add(this.lblMensajes_del_Usuario);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1058, 72);
            this.panel2.TabIndex = 20;
            // 
            // lblMensajes_del_Usuario
            // 
            this.lblMensajes_del_Usuario.AutoSize = true;
            this.lblMensajes_del_Usuario.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajes_del_Usuario.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblMensajes_del_Usuario.Location = new System.Drawing.Point(385, 23);
            this.lblMensajes_del_Usuario.Name = "lblMensajes_del_Usuario";
            this.lblMensajes_del_Usuario.Size = new System.Drawing.Size(277, 31);
            this.lblMensajes_del_Usuario.TabIndex = 15;
            this.lblMensajes_del_Usuario.Text = "Mensajes del Usuario";
            // 
            // LblNUsuario
            // 
            this.LblNUsuario.AutoSize = true;
            this.LblNUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNUsuario.Location = new System.Drawing.Point(734, 115);
            this.LblNUsuario.Name = "LblNUsuario";
            this.LblNUsuario.Size = new System.Drawing.Size(134, 20);
            this.LblNUsuario.TabIndex = 19;
            this.LblNUsuario.Text = "[nombre_usuario]";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lblUsuario.Location = new System.Drawing.Point(656, 113);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(72, 23);
            this.lblUsuario.TabIndex = 16;
            this.lblUsuario.Text = "Usuario:";
            // 
            // txtContenido
            // 
            this.txtContenido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContenido.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContenido.Location = new System.Drawing.Point(168, 248);
            this.txtContenido.Name = "txtContenido";
            this.txtContenido.Size = new System.Drawing.Size(700, 263);
            this.txtContenido.TabIndex = 14;
            this.txtContenido.Text = "";
            // 
            // lblContenido
            // 
            this.lblContenido.AutoSize = true;
            this.lblContenido.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContenido.Location = new System.Drawing.Point(168, 222);
            this.lblContenido.Name = "lblContenido";
            this.lblContenido.Size = new System.Drawing.Size(94, 23);
            this.lblContenido.TabIndex = 13;
            this.lblContenido.Text = "Contenido:";
            // 
            // txtAsunto
            // 
            this.txtAsunto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAsunto.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAsunto.Location = new System.Drawing.Point(168, 179);
            this.txtAsunto.Name = "txtAsunto";
            this.txtAsunto.Size = new System.Drawing.Size(700, 30);
            this.txtAsunto.TabIndex = 12;
            // 
            // lblAsunto
            // 
            this.lblAsunto.AutoSize = true;
            this.lblAsunto.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsunto.Location = new System.Drawing.Point(168, 153);
            this.lblAsunto.Name = "lblAsunto";
            this.lblAsunto.Size = new System.Drawing.Size(68, 23);
            this.lblAsunto.TabIndex = 11;
            this.lblAsunto.Text = "Asunto:";
            // 
            // TP_2
            // 
            this.TP_2.Controls.Add(this.lblFecha_R);
            this.TP_2.Controls.Add(this.lblFR);
            this.TP_2.Controls.Add(this.txtBuscador);
            this.TP_2.Controls.Add(this.Dgv_Respuestas);
            this.TP_2.Controls.Add(this.Btn_Otro_M);
            this.TP_2.Controls.Add(this.RTB_Respuestas);
            this.TP_2.Controls.Add(this.panel1);
            this.TP_2.Location = new System.Drawing.Point(4, 25);
            this.TP_2.Name = "TP_2";
            this.TP_2.Padding = new System.Windows.Forms.Padding(3);
            this.TP_2.Size = new System.Drawing.Size(1054, 638);
            this.TP_2.TabIndex = 1;
            this.TP_2.Text = "Respuestas";
            this.TP_2.UseVisualStyleBackColor = true;
            // 
            // Btn_Otro_M
            // 
            this.Btn_Otro_M.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Btn_Otro_M.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Otro_M.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.Btn_Otro_M.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Otro_M.Location = new System.Drawing.Point(833, 574);
            this.Btn_Otro_M.Name = "Btn_Otro_M";
            this.Btn_Otro_M.Size = new System.Drawing.Size(182, 40);
            this.Btn_Otro_M.TabIndex = 18;
            this.Btn_Otro_M.Text = "Enviar otro Mensaje";
            this.Btn_Otro_M.UseVisualStyleBackColor = false;
            this.Btn_Otro_M.Click += new System.EventHandler(this.Btn_Otro_M_Click);
            // 
            // RTB_Respuestas
            // 
            this.RTB_Respuestas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RTB_Respuestas.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTB_Respuestas.Location = new System.Drawing.Point(503, 171);
            this.RTB_Respuestas.Name = "RTB_Respuestas";
            this.RTB_Respuestas.Size = new System.Drawing.Size(512, 355);
            this.RTB_Respuestas.TabIndex = 16;
            this.RTB_Respuestas.Text = "";
            this.RTB_Respuestas.TextChanged += new System.EventHandler(this.RTB_Respuestas_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.lblRespuesta);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1054, 72);
            this.panel1.TabIndex = 17;
            // 
            // lblRespuesta
            // 
            this.lblRespuesta.AutoSize = true;
            this.lblRespuesta.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespuesta.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblRespuesta.Location = new System.Drawing.Point(369, 22);
            this.lblRespuesta.Name = "lblRespuesta";
            this.lblRespuesta.Size = new System.Drawing.Size(294, 31);
            this.lblRespuesta.TabIndex = 15;
            this.lblRespuesta.Text = "Respuestas de Soporte";
            // 
            // Dgv_Respuestas
            // 
            this.Dgv_Respuestas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Dgv_Respuestas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Respuestas.Location = new System.Drawing.Point(36, 210);
            this.Dgv_Respuestas.Name = "Dgv_Respuestas";
            this.Dgv_Respuestas.RowHeadersWidth = 51;
            this.Dgv_Respuestas.RowTemplate.Height = 24;
            this.Dgv_Respuestas.Size = new System.Drawing.Size(422, 316);
            this.Dgv_Respuestas.TabIndex = 19;
            this.Dgv_Respuestas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Respuestas_CellContentClick);
            // 
            // txtBuscador
            // 
            this.txtBuscador.Location = new System.Drawing.Point(36, 171);
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.Size = new System.Drawing.Size(422, 22);
            this.txtBuscador.TabIndex = 20;
            this.txtBuscador.Text = "Buscar";
            this.txtBuscador.TextChanged += new System.EventHandler(this.txtBuscador_TextChanged);
            // 
            // lblFecha_R
            // 
            this.lblFecha_R.AutoSize = true;
            this.lblFecha_R.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha_R.Location = new System.Drawing.Point(876, 118);
            this.lblFecha_R.Name = "lblFecha_R";
            this.lblFecha_R.Size = new System.Drawing.Size(139, 20);
            this.lblFecha_R.TabIndex = 23;
            this.lblFecha_R.Text = "[Fecha_Respuesta]";
            this.lblFecha_R.Click += new System.EventHandler(this.lblFecha_R_Click);
            // 
            // lblFR
            // 
            this.lblFR.AutoSize = true;
            this.lblFR.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lblFR.Location = new System.Drawing.Point(812, 116);
            this.lblFR.Name = "lblFR";
            this.lblFR.Size = new System.Drawing.Size(58, 23);
            this.lblFR.TabIndex = 22;
            this.lblFR.Text = "Fecha:";
            // 
            // FrmMensajesUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1057, 662);
            this.Controls.Add(this.TC_Mensaje_de_Usuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMensajesUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mensaje de Usuario";
            this.TC_Mensaje_de_Usuario.ResumeLayout(false);
            this.TP_1.ResumeLayout(false);
            this.TP_1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.TP_2.ResumeLayout(false);
            this.TP_2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Respuestas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl TC_Mensaje_de_Usuario;
        private System.Windows.Forms.TabPage TP_1;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.RichTextBox txtContenido;
        private System.Windows.Forms.Label lblContenido;
        private System.Windows.Forms.TextBox txtAsunto;
        private System.Windows.Forms.Label lblAsunto;
        private System.Windows.Forms.TabPage TP_2;
        private System.Windows.Forms.RichTextBox RTB_Respuestas;
        private System.Windows.Forms.Label lblRespuesta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblNUsuario;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblMensajes_del_Usuario;
        private System.Windows.Forms.Button Btn_Otro_M;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtBuscador;
        private System.Windows.Forms.DataGridView Dgv_Respuestas;
        private System.Windows.Forms.Label lblFecha_R;
        private System.Windows.Forms.Label lblFR;
    }
}