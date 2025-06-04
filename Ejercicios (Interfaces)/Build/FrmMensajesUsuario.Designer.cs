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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblAsunto = new System.Windows.Forms.Label();
            this.txtAsunto = new System.Windows.Forms.TextBox();
            this.lblContenido = new System.Windows.Forms.Label();
            this.txtContenido = new System.Windows.Forms.RichTextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(244, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(321, 37);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "MENSAJE DEL USUARIO";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAsunto
            // 
            this.lblAsunto.AutoSize = true;
            this.lblAsunto.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsunto.Location = new System.Drawing.Point(50, 120);
            this.lblAsunto.Name = "lblAsunto";
            this.lblAsunto.Size = new System.Drawing.Size(68, 23);
            this.lblAsunto.TabIndex = 1;
            this.lblAsunto.Text = "Asunto:";
            // 
            // txtAsunto
            // 
            this.txtAsunto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAsunto.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAsunto.Location = new System.Drawing.Point(50, 146);
            this.txtAsunto.Name = "txtAsunto";
            this.txtAsunto.Size = new System.Drawing.Size(700, 30);
            this.txtAsunto.TabIndex = 2;
            // 
            // lblContenido
            // 
            this.lblContenido.AutoSize = true;
            this.lblContenido.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContenido.Location = new System.Drawing.Point(50, 190);
            this.lblContenido.Name = "lblContenido";
            this.lblContenido.Size = new System.Drawing.Size(94, 23);
            this.lblContenido.TabIndex = 3;
            this.lblContenido.Text = "Contenido:";
            // 
            // txtContenido
            // 
            this.txtContenido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContenido.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContenido.Location = new System.Drawing.Point(50, 216);
            this.txtContenido.Name = "txtContenido";
            this.txtContenido.Size = new System.Drawing.Size(700, 200);
            this.txtContenido.TabIndex = 4;
            this.txtContenido.Text = "";
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnEnviar.FlatAppearance.BorderSize = 0;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.ForeColor = System.Drawing.Color.White;
            this.btnEnviar.Location = new System.Drawing.Point(621, 15);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(140, 40);
            this.btnEnviar.TabIndex = 5;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panelHeader.Controls.Add(this.lblTitulo);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(800, 80);
            this.panelHeader.TabIndex = 6;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(456, 15);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(140, 40);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelFooter.Controls.Add(this.btnEnviar);
            this.panelFooter.Controls.Add(this.btnCancelar);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 450);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(800, 70);
            this.panelFooter.TabIndex = 8;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(546, 90);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(62, 20);
            this.lblUsuario.TabIndex = 9;
            this.lblUsuario.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.AutoSize = true;
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(614, 90);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(134, 20);
            this.txtUsuario.TabIndex = 10;
            this.txtUsuario.Text = "[nombre_usuario]";
            this.txtUsuario.Click += new System.EventHandler(this.txtUsuario_Click);
            // 
            // FrmMensajesUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 520);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.txtContenido);
            this.Controls.Add(this.lblContenido);
            this.Controls.Add(this.txtAsunto);
            this.Controls.Add(this.lblAsunto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMensajesUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mensaje de Usuario";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelFooter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblAsunto;
        private System.Windows.Forms.TextBox txtAsunto;
        private System.Windows.Forms.Label lblContenido;
        private System.Windows.Forms.RichTextBox txtContenido;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label txtUsuario;
    }
}