namespace Act.Inicio_de_Sesion
{
    partial class FrmMenuPrincipal
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label lblTitulo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.BtnRespuestasU = new System.Windows.Forms.Button();
            this.BtnMensajesU = new System.Windows.Forms.Button();
            this.txtRol = new System.Windows.Forms.Label();
            this.BtnUsuarios = new System.Windows.Forms.Button();
            this.Pic_FDP = new System.Windows.Forms.PictureBox();
            this.TxtNombreUsuario = new System.Windows.Forms.Label();
            this.BtnCerrarSesion = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_FDP)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panelMenu.Controls.Add(this.BtnRespuestasU);
            this.panelMenu.Controls.Add(this.BtnMensajesU);
            this.panelMenu.Controls.Add(this.txtRol);
            this.panelMenu.Controls.Add(this.BtnUsuarios);
            this.panelMenu.Controls.Add(this.Pic_FDP);
            this.panelMenu.Controls.Add(this.TxtNombreUsuario);
            this.panelMenu.Controls.Add(this.BtnCerrarSesion);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(207, 494);
            this.panelMenu.TabIndex = 1;
            // 
            // BtnRespuestasU
            // 
            this.BtnRespuestasU.BackColor = System.Drawing.Color.White;
            this.BtnRespuestasU.FlatAppearance.BorderSize = 0;
            this.BtnRespuestasU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRespuestasU.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BtnRespuestasU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.BtnRespuestasU.Location = new System.Drawing.Point(12, 368);
            this.BtnRespuestasU.Name = "BtnRespuestasU";
            this.BtnRespuestasU.Size = new System.Drawing.Size(183, 45);
            this.BtnRespuestasU.TabIndex = 8;
            this.BtnRespuestasU.Text = "Comunicados";
            this.BtnRespuestasU.UseVisualStyleBackColor = false;
            this.BtnRespuestasU.Click += new System.EventHandler(this.BtnRespuestasU_Click);
            // 
            // BtnMensajesU
            // 
            this.BtnMensajesU.BackColor = System.Drawing.Color.White;
            this.BtnMensajesU.FlatAppearance.BorderSize = 0;
            this.BtnMensajesU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMensajesU.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BtnMensajesU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.BtnMensajesU.Location = new System.Drawing.Point(12, 300);
            this.BtnMensajesU.Name = "BtnMensajesU";
            this.BtnMensajesU.Size = new System.Drawing.Size(183, 45);
            this.BtnMensajesU.TabIndex = 7;
            this.BtnMensajesU.Text = "Soporte";
            this.BtnMensajesU.UseVisualStyleBackColor = false;
            this.BtnMensajesU.Click += new System.EventHandler(this.BtnMensajesU_Click);
            // 
            // txtRol
            // 
            this.txtRol.AutoSize = true;
            this.txtRol.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtRol.ForeColor = System.Drawing.Color.White;
            this.txtRol.Location = new System.Drawing.Point(40, 178);
            this.txtRol.Name = "txtRol";
            this.txtRol.Size = new System.Drawing.Size(32, 20);
            this.txtRol.TabIndex = 6;
            this.txtRol.Text = "Rol";
            this.txtRol.Click += new System.EventHandler(this.txtRol_Click);
            // 
            // BtnUsuarios
            // 
            this.BtnUsuarios.BackColor = System.Drawing.Color.White;
            this.BtnUsuarios.FlatAppearance.BorderSize = 0;
            this.BtnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUsuarios.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BtnUsuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.BtnUsuarios.Location = new System.Drawing.Point(12, 233);
            this.BtnUsuarios.Name = "BtnUsuarios";
            this.BtnUsuarios.Size = new System.Drawing.Size(183, 45);
            this.BtnUsuarios.TabIndex = 5;
            this.BtnUsuarios.Text = "Usuarios";
            this.BtnUsuarios.UseVisualStyleBackColor = false;
            this.BtnUsuarios.Click += new System.EventHandler(this.BtnUsuarios_Click);
            // 
            // Pic_FDP
            // 
            this.Pic_FDP.Location = new System.Drawing.Point(44, 44);
            this.Pic_FDP.Name = "Pic_FDP";
            this.Pic_FDP.Size = new System.Drawing.Size(125, 101);
            this.Pic_FDP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_FDP.TabIndex = 4;
            this.Pic_FDP.TabStop = false;
            this.Pic_FDP.Click += new System.EventHandler(this.Pic_FDP_Click);
            // 
            // TxtNombreUsuario
            // 
            this.TxtNombreUsuario.AutoSize = true;
            this.TxtNombreUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.TxtNombreUsuario.ForeColor = System.Drawing.Color.White;
            this.TxtNombreUsuario.Location = new System.Drawing.Point(40, 148);
            this.TxtNombreUsuario.Name = "TxtNombreUsuario";
            this.TxtNombreUsuario.Size = new System.Drawing.Size(63, 20);
            this.TxtNombreUsuario.TabIndex = 2;
            this.TxtNombreUsuario.Text = "Usuario";
            this.TxtNombreUsuario.Click += new System.EventHandler(this.TxtNombreUsuario_Click);
            // 
            // BtnCerrarSesion
            // 
            this.BtnCerrarSesion.BackColor = System.Drawing.Color.White;
            this.BtnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.BtnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrarSesion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BtnCerrarSesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.BtnCerrarSesion.Location = new System.Drawing.Point(12, 437);
            this.BtnCerrarSesion.Name = "BtnCerrarSesion";
            this.BtnCerrarSesion.Size = new System.Drawing.Size(183, 45);
            this.BtnCerrarSesion.TabIndex = 3;
            this.BtnCerrarSesion.Text = "Cerrar sesión";
            this.BtnCerrarSesion.UseVisualStyleBackColor = false;
            this.BtnCerrarSesion.Click += new System.EventHandler(this.BtnCerrarSesion_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(113, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(262, 37);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Sistema de Gestión";
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblBienvenida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblBienvenida.Location = new System.Drawing.Point(272, 241);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(263, 37);
            this.lblBienvenida.TabIndex = 1;
            this.lblBienvenida.Text = "Bienvenido usuario";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panelHeader.Controls.Add(this.lblTitulo);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(207, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(521, 75);
            this.panelHeader.TabIndex = 0;
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(728, 494);
            this.Controls.Add(this.lblBienvenida);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Principal";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_FDP)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Button BtnCerrarSesion;
        private System.Windows.Forms.PictureBox Pic_FDP;
        private System.Windows.Forms.Label TxtNombreUsuario;
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Label txtRol;
        private System.Windows.Forms.Button BtnUsuarios;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button BtnMensajesU;
        private System.Windows.Forms.Button BtnRespuestasU;
    }
}
