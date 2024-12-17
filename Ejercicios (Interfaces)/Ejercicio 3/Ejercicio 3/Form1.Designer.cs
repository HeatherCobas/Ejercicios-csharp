namespace Ejercicio_3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbl1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txbRojo = new System.Windows.Forms.TextBox();
            this.btnRojo = new System.Windows.Forms.Button();
            this.lbl2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnAmarillo = new System.Windows.Forms.Button();
            this.txbAmarillo = new System.Windows.Forms.TextBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnRosado = new System.Windows.Forms.Button();
            this.txbRosado = new System.Windows.Forms.TextBox();
            this.lbl4 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btnBlanco = new System.Windows.Forms.Button();
            this.txbBlanco = new System.Windows.Forms.TextBox();
            this.lbl5 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.btnVerde = new System.Windows.Forms.Button();
            this.txbVerde = new System.Windows.Forms.TextBox();
            this.lbl6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(98, 87);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(552, 317);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.Controls.Add(this.lbl1);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(544, 284);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Inicio";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Calisto MT", 20F);
            this.lbl1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl1.Location = new System.Drawing.Point(149, 121);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(227, 46);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Bienvenidos";
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.Controls.Add(this.txbRojo);
            this.tabPage2.Controls.Add(this.btnRojo);
            this.tabPage2.Controls.Add(this.lbl2);
            this.tabPage2.Font = new System.Drawing.Font("Calisto MT", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(544, 284);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Rojo";
            // 
            // txbRojo
            // 
            this.txbRojo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txbRojo.Font = new System.Drawing.Font("Calisto MT", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbRojo.ForeColor = System.Drawing.Color.Black;
            this.txbRojo.Location = new System.Drawing.Point(194, 197);
            this.txbRojo.Name = "txbRojo";
            this.txbRojo.Size = new System.Drawing.Size(166, 26);
            this.txbRojo.TabIndex = 2;
            this.txbRojo.TextChanged += new System.EventHandler(this.txbRojo_TextChanged);
            // 
            // btnRojo
            // 
            this.btnRojo.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRojo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRojo.Location = new System.Drawing.Point(235, 229);
            this.btnRojo.Name = "btnRojo";
            this.btnRojo.Size = new System.Drawing.Size(75, 40);
            this.btnRojo.TabIndex = 1;
            this.btnRojo.Text = "Enviar";
            this.btnRojo.UseVisualStyleBackColor = false;
            this.btnRojo.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbl2.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl2.Location = new System.Drawing.Point(32, 30);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(481, 28);
            this.lbl2.TabIndex = 0;
            this.lbl2.Text = "¿Qué valor crees que representa el color Rojo?";
            this.lbl2.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = global::Ejercicio_3.Properties.Resources.b5c6e92b_246b_4e35_89f6_c6064d53e65d;
            this.tabPage3.Controls.Add(this.btnAmarillo);
            this.tabPage3.Controls.Add(this.txbAmarillo);
            this.tabPage3.Controls.Add(this.lbl3);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(544, 284);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Amarillo";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnAmarillo
            // 
            this.btnAmarillo.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAmarillo.Font = new System.Drawing.Font("Calisto MT", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAmarillo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAmarillo.Location = new System.Drawing.Point(224, 236);
            this.btnAmarillo.Name = "btnAmarillo";
            this.btnAmarillo.Size = new System.Drawing.Size(75, 34);
            this.btnAmarillo.TabIndex = 2;
            this.btnAmarillo.Text = "Enviar";
            this.btnAmarillo.UseVisualStyleBackColor = false;
            this.btnAmarillo.Click += new System.EventHandler(this.btnAmarillo_Click);
            // 
            // txbAmarillo
            // 
            this.txbAmarillo.Font = new System.Drawing.Font("Calisto MT", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAmarillo.ForeColor = System.Drawing.Color.Black;
            this.txbAmarillo.Location = new System.Drawing.Point(182, 204);
            this.txbAmarillo.Name = "txbAmarillo";
            this.txbAmarillo.Size = new System.Drawing.Size(164, 26);
            this.txbAmarillo.TabIndex = 1;
            this.txbAmarillo.TextChanged += new System.EventHandler(this.txbAmarillo_TextChanged);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.BackColor = System.Drawing.Color.White;
            this.lbl3.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(9, 30);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(526, 28);
            this.lbl3.TabIndex = 0;
            this.lbl3.Text = "¿Qué valor crees que representa el color Amarillo?";
            // 
            // tabPage4
            // 
            this.tabPage4.BackgroundImage = global::Ejercicio_3.Properties.Resources.b5c6e92b_246b_4e35_89f6_c6064d53e65d;
            this.tabPage4.Controls.Add(this.btnRosado);
            this.tabPage4.Controls.Add(this.txbRosado);
            this.tabPage4.Controls.Add(this.lbl4);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(544, 284);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Rosado";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnRosado
            // 
            this.btnRosado.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRosado.Font = new System.Drawing.Font("Calisto MT", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRosado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRosado.Location = new System.Drawing.Point(215, 229);
            this.btnRosado.Name = "btnRosado";
            this.btnRosado.Size = new System.Drawing.Size(75, 37);
            this.btnRosado.TabIndex = 2;
            this.btnRosado.Text = "Enviar";
            this.btnRosado.UseVisualStyleBackColor = false;
            this.btnRosado.Click += new System.EventHandler(this.button3_Click);
            // 
            // txbRosado
            // 
            this.txbRosado.Font = new System.Drawing.Font("Calisto MT", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbRosado.ForeColor = System.Drawing.Color.Black;
            this.txbRosado.Location = new System.Drawing.Point(172, 197);
            this.txbRosado.Name = "txbRosado";
            this.txbRosado.Size = new System.Drawing.Size(164, 26);
            this.txbRosado.TabIndex = 1;
            this.txbRosado.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.BackColor = System.Drawing.Color.White;
            this.lbl4.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.Location = new System.Drawing.Point(17, 27);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(509, 28);
            this.lbl4.TabIndex = 0;
            this.lbl4.Text = "¿Qué valor crees que representa el color Rosado?";
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.Transparent;
            this.tabPage5.BackgroundImage = global::Ejercicio_3.Properties.Resources.b5c6e92b_246b_4e35_89f6_c6064d53e65d;
            this.tabPage5.Controls.Add(this.btnBlanco);
            this.tabPage5.Controls.Add(this.txbBlanco);
            this.tabPage5.Controls.Add(this.lbl5);
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(544, 284);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Blanco";
            // 
            // btnBlanco
            // 
            this.btnBlanco.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBlanco.Font = new System.Drawing.Font("Calisto MT", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlanco.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBlanco.Location = new System.Drawing.Point(220, 240);
            this.btnBlanco.Name = "btnBlanco";
            this.btnBlanco.Size = new System.Drawing.Size(75, 31);
            this.btnBlanco.TabIndex = 2;
            this.btnBlanco.Text = "Enviar";
            this.btnBlanco.UseVisualStyleBackColor = false;
            this.btnBlanco.Click += new System.EventHandler(this.btnBlanco_Click);
            // 
            // txbBlanco
            // 
            this.txbBlanco.Font = new System.Drawing.Font("Calisto MT", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBlanco.ForeColor = System.Drawing.Color.Black;
            this.txbBlanco.Location = new System.Drawing.Point(151, 208);
            this.txbBlanco.Name = "txbBlanco";
            this.txbBlanco.Size = new System.Drawing.Size(220, 26);
            this.txbBlanco.TabIndex = 1;
            this.txbBlanco.TextChanged += new System.EventHandler(this.txbBlanco_TextChanged);
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.BackColor = System.Drawing.Color.White;
            this.lbl5.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.Location = new System.Drawing.Point(17, 27);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(504, 28);
            this.lbl5.TabIndex = 0;
            this.lbl5.Text = "¿Qué valor crees que representa el color Blanco?";
            // 
            // tabPage6
            // 
            this.tabPage6.BackgroundImage = global::Ejercicio_3.Properties.Resources.b5c6e92b_246b_4e35_89f6_c6064d53e65d;
            this.tabPage6.Controls.Add(this.btnVerde);
            this.tabPage6.Controls.Add(this.txbVerde);
            this.tabPage6.Controls.Add(this.lbl6);
            this.tabPage6.Location = new System.Drawing.Point(4, 29);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(544, 284);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Verde";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // btnVerde
            // 
            this.btnVerde.BackColor = System.Drawing.Color.SteelBlue;
            this.btnVerde.Font = new System.Drawing.Font("Calisto MT", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerde.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVerde.Location = new System.Drawing.Point(226, 237);
            this.btnVerde.Name = "btnVerde";
            this.btnVerde.Size = new System.Drawing.Size(75, 35);
            this.btnVerde.TabIndex = 2;
            this.btnVerde.Text = "Enviar";
            this.btnVerde.UseVisualStyleBackColor = false;
            this.btnVerde.Click += new System.EventHandler(this.btnVerde_Click);
            // 
            // txbVerde
            // 
            this.txbVerde.Font = new System.Drawing.Font("Calisto MT", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbVerde.ForeColor = System.Drawing.Color.Black;
            this.txbVerde.Location = new System.Drawing.Point(171, 205);
            this.txbVerde.Name = "txbVerde";
            this.txbVerde.Size = new System.Drawing.Size(192, 26);
            this.txbVerde.TabIndex = 1;
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.BackColor = System.Drawing.Color.White;
            this.lbl6.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl6.Location = new System.Drawing.Point(22, 31);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(493, 28);
            this.lbl6.TabIndex = 0;
            this.lbl6.Text = "¿Qué valor crees que representa el color Verde?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.TextBox txbRojo;
        private System.Windows.Forms.Button btnRojo;
        private System.Windows.Forms.Button btnAmarillo;
        private System.Windows.Forms.TextBox txbAmarillo;
        private System.Windows.Forms.Button btnRosado;
        private System.Windows.Forms.TextBox txbRosado;
        private System.Windows.Forms.Button btnBlanco;
        private System.Windows.Forms.TextBox txbBlanco;
        private System.Windows.Forms.Button btnVerde;
        private System.Windows.Forms.TextBox txbVerde;
    }
}

