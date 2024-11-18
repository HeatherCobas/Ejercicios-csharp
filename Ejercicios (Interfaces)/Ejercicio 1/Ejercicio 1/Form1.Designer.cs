namespace Ejercicio_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label3 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label4 = new Label();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            comboBox1 = new ComboBox();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(344, 141);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 0;
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.SaddleBrown;
            button1.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.PeachPuff;
            button1.Location = new Point(344, 373);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 1;
            button1.Text = "Enviar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.SaddleBrown;
            label2.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.PeachPuff;
            label2.Location = new Point(54, 17);
            label2.Name = "label2";
            label2.Size = new Size(197, 23);
            label2.TabIndex = 2;
            label2.Text = "¿Cúal es tu genero?";
            label2.Click += label2_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackColor = Color.SaddleBrown;
            radioButton1.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton1.ForeColor = Color.PeachPuff;
            radioButton1.Location = new Point(6, 66);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(111, 27);
            radioButton1.TabIndex = 5;
            radioButton1.TabStop = true;
            radioButton1.Text = "Hombre";
            radioButton1.UseVisualStyleBackColor = false;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.BackColor = Color.SaddleBrown;
            radioButton2.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton2.ForeColor = Color.PeachPuff;
            radioButton2.Location = new Point(6, 101);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(93, 27);
            radioButton2.TabIndex = 6;
            radioButton2.TabStop = true;
            radioButton2.Text = "Mujer";
            radioButton2.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.SaddleBrown;
            label3.Font = new Font("Showcard Gothic", 28F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.PeachPuff;
            label3.Location = new Point(344, 63);
            label3.Name = "label3";
            label3.Size = new Size(170, 68);
            label3.TabIndex = 7;
            label3.Text = "5TOD";
            label3.Click += label3_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Location = new Point(25, 147);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 150);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(radioButton3);
            groupBox2.Controls.Add(radioButton4);
            groupBox2.Location = new Point(527, 147);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(261, 150);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Enter += groupBox2_Enter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.SaddleBrown;
            label4.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.PeachPuff;
            label4.Location = new Point(117, 14);
            label4.Name = "label4";
            label4.Size = new Size(48, 23);
            label4.TabIndex = 2;
            label4.Text = "Pais";
            label4.Click += label4_Click;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.BackColor = Color.SaddleBrown;
            radioButton3.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton3.ForeColor = Color.PeachPuff;
            radioButton3.Location = new Point(6, 66);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(126, 27);
            radioButton3.TabIndex = 5;
            radioButton3.TabStop = true;
            radioButton3.Text = "Colombia";
            radioButton3.UseVisualStyleBackColor = false;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.BackColor = Color.SaddleBrown;
            radioButton4.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton4.ForeColor = Color.PeachPuff;
            radioButton4.Location = new Point(6, 101);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(97, 27);
            radioButton4.TabIndex = 6;
            radioButton4.TabStop = true;
            radioButton4.Text = "Bracil";
            radioButton4.UseVisualStyleBackColor = false;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.SaddleBrown;
            comboBox1.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.ForeColor = Color.PeachPuff;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "México", "Venezuela", "Guatemala", "Republica Dominicana", "Peru", "Cuba", "Francia" });
            comboBox1.Location = new Point(527, 318);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 31);
            comboBox1.TabIndex = 10;
            comboBox1.Text = "Seleccciona";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.SaddleBrown;
            label5.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.PeachPuff;
            label5.Location = new Point(395, 326);
            label5.Name = "label5";
            label5.Size = new Size(0, 23);
            label5.TabIndex = 11;
            label5.Click += label5_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Chibi_HR;
            pictureBox1.Location = new Point(713, 373);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(87, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Label label2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label3;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label4;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private ComboBox comboBox1;
        private Label label5;
        private PictureBox pictureBox1;
    }
}
