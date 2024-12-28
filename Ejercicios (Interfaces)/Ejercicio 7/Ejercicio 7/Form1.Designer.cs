namespace Ejercicio_7
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.cmbCargo = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtSueldoNeto = new System.Windows.Forms.TextBox();
            this.txtTotalDescuento = new System.Windows.Forms.TextBox();
            this.txtOtros = new System.Windows.Forms.TextBox();
            this.txtISR = new System.Windows.Forms.TextBox();
            this.txtSFS = new System.Windows.Forms.TextBox();
            this.txtAFP = new System.Windows.Forms.TextBox();
            this.txtTotalsueldoMásIngresos = new System.Windows.Forms.TextBox();
            this.txtNhijos = new System.Windows.Forms.TextBox();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.lblSueldoNeto = new System.Windows.Forms.Label();
            this.lblTotalDescuento = new System.Windows.Forms.Label();
            this.lblOtro = new System.Windows.Forms.Label();
            this.lblISR = new System.Windows.Forms.Label();
            this.lblSFS = new System.Windows.Forms.Label();
            this.lblAFP = new System.Windows.Forms.Label();
            this.lblTotalsueldoMásIngresos = new System.Windows.Forms.Label();
            this.lblNhijo = new System.Windows.Forms.Label();
            this.lblSueldo = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(39, 44);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1042, 521);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnCalcular);
            this.tabPage1.Controls.Add(this.cmbCargo);
            this.tabPage1.Controls.Add(this.txtNombre);
            this.tabPage1.Controls.Add(this.txtSueldoNeto);
            this.tabPage1.Controls.Add(this.txtTotalDescuento);
            this.tabPage1.Controls.Add(this.txtOtros);
            this.tabPage1.Controls.Add(this.txtISR);
            this.tabPage1.Controls.Add(this.txtSFS);
            this.tabPage1.Controls.Add(this.txtAFP);
            this.tabPage1.Controls.Add(this.txtTotalsueldoMásIngresos);
            this.tabPage1.Controls.Add(this.txtNhijos);
            this.tabPage1.Controls.Add(this.txtSueldo);
            this.tabPage1.Controls.Add(this.lblSueldoNeto);
            this.tabPage1.Controls.Add(this.lblTotalDescuento);
            this.tabPage1.Controls.Add(this.lblOtro);
            this.tabPage1.Controls.Add(this.lblISR);
            this.tabPage1.Controls.Add(this.lblSFS);
            this.tabPage1.Controls.Add(this.lblAFP);
            this.tabPage1.Controls.Add(this.lblTotalsueldoMásIngresos);
            this.tabPage1.Controls.Add(this.lblNhijo);
            this.tabPage1.Controls.Add(this.lblSueldo);
            this.tabPage1.Controls.Add(this.lblCargo);
            this.tabPage1.Controls.Add(this.lblNombre);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1034, 488);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Datos_Personales";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.Green;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCalcular.Location = new System.Drawing.Point(484, 421);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(98, 42);
            this.btnCalcular.TabIndex = 23;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // cmbCargo
            // 
            this.cmbCargo.FormattingEnabled = true;
            this.cmbCargo.Items.AddRange(new object[] {
            "Director General (CEO)",
            "Gerente General",
            "Subdirector",
            "Asistente de Dirección",
            "",
            "Gerente de Administración y Finanzas",
            "Contador",
            "Auxiliar Contable",
            "Auditor Interno",
            "Tesorero",
            "Analista Financiero",
            "Recepcionista",
            "",
            "Gerente de Recursos Humanos",
            "Reclutador",
            "Especialista en Capacitación",
            "Analista de Nómina",
            "Coordinador de Relaciones Laborales",
            "",
            "Gerente de Operaciones",
            "Supervisor de Producción",
            "Operador de Maquinaria",
            "Técnico en Mantenimiento",
            "Inspector de Calidad",
            "Logístico de Inventario",
            "",
            "Gerente de Ventas",
            "Representante de Ventas",
            "Ejecutivo de Cuentas",
            "Gerente de Marketing",
            "Especialista en Publicidad",
            "Diseñador Gráfico",
            "Analista de Mercado",
            "",
            "Gerente de Tecnología (CTO)",
            "Desarrollador de Software",
            "Analista de Sistemas",
            "Técnico en Soporte",
            "Ingeniero de Redes",
            "Especialista en Ciberseguridad",
            "",
            "Gerente de Servicio al Cliente",
            "Representante de Atención al Cliente",
            "Coordinador de Satisfacción del Cliente",
            "",
            "Gerente de Logística",
            "Coordinador de Transporte",
            "Conductor de Vehículos",
            "Almacenista"});
            this.cmbCargo.Location = new System.Drawing.Point(251, 94);
            this.cmbCargo.Name = "cmbCargo";
            this.cmbCargo.Size = new System.Drawing.Size(142, 28);
            this.cmbCargo.TabIndex = 22;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(251, 61);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(142, 26);
            this.txtNombre.TabIndex = 21;
            // 
            // txtSueldoNeto
            // 
            this.txtSueldoNeto.Location = new System.Drawing.Point(251, 421);
            this.txtSueldoNeto.Name = "txtSueldoNeto";
            this.txtSueldoNeto.ReadOnly = true;
            this.txtSueldoNeto.Size = new System.Drawing.Size(142, 26);
            this.txtSueldoNeto.TabIndex = 20;
            // 
            // txtTotalDescuento
            // 
            this.txtTotalDescuento.Location = new System.Drawing.Point(251, 388);
            this.txtTotalDescuento.Name = "txtTotalDescuento";
            this.txtTotalDescuento.ReadOnly = true;
            this.txtTotalDescuento.Size = new System.Drawing.Size(142, 26);
            this.txtTotalDescuento.TabIndex = 19;
            // 
            // txtOtros
            // 
            this.txtOtros.Location = new System.Drawing.Point(251, 355);
            this.txtOtros.Name = "txtOtros";
            this.txtOtros.ReadOnly = true;
            this.txtOtros.Size = new System.Drawing.Size(142, 26);
            this.txtOtros.TabIndex = 18;
            this.txtOtros.TextChanged += new System.EventHandler(this.txtOtros_TextChanged);
            // 
            // txtISR
            // 
            this.txtISR.Location = new System.Drawing.Point(251, 323);
            this.txtISR.Name = "txtISR";
            this.txtISR.ReadOnly = true;
            this.txtISR.Size = new System.Drawing.Size(142, 26);
            this.txtISR.TabIndex = 17;
            // 
            // txtSFS
            // 
            this.txtSFS.Location = new System.Drawing.Point(251, 290);
            this.txtSFS.Name = "txtSFS";
            this.txtSFS.ReadOnly = true;
            this.txtSFS.Size = new System.Drawing.Size(142, 26);
            this.txtSFS.TabIndex = 16;
            // 
            // txtAFP
            // 
            this.txtAFP.Location = new System.Drawing.Point(251, 258);
            this.txtAFP.Name = "txtAFP";
            this.txtAFP.ReadOnly = true;
            this.txtAFP.Size = new System.Drawing.Size(142, 26);
            this.txtAFP.TabIndex = 15;
            // 
            // txtTotalsueldoMásIngresos
            // 
            this.txtTotalsueldoMásIngresos.Location = new System.Drawing.Point(251, 193);
            this.txtTotalsueldoMásIngresos.Name = "txtTotalsueldoMásIngresos";
            this.txtTotalsueldoMásIngresos.ReadOnly = true;
            this.txtTotalsueldoMásIngresos.Size = new System.Drawing.Size(142, 26);
            this.txtTotalsueldoMásIngresos.TabIndex = 14;
            this.txtTotalsueldoMásIngresos.TextChanged += new System.EventHandler(this.txtTotalsueldoMásIngresos_TextChanged);
            // 
            // txtNhijos
            // 
            this.txtNhijos.Location = new System.Drawing.Point(251, 160);
            this.txtNhijos.Name = "txtNhijos";
            this.txtNhijos.Size = new System.Drawing.Size(142, 26);
            this.txtNhijos.TabIndex = 13;
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(251, 128);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(142, 26);
            this.txtSueldo.TabIndex = 12;
            // 
            // lblSueldoNeto
            // 
            this.lblSueldoNeto.AutoSize = true;
            this.lblSueldoNeto.Location = new System.Drawing.Point(73, 421);
            this.lblSueldoNeto.Name = "lblSueldoNeto";
            this.lblSueldoNeto.Size = new System.Drawing.Size(97, 20);
            this.lblSueldoNeto.TabIndex = 10;
            this.lblSueldoNeto.Text = "Sueldo Neto";
            // 
            // lblTotalDescuento
            // 
            this.lblTotalDescuento.AutoSize = true;
            this.lblTotalDescuento.Location = new System.Drawing.Point(73, 390);
            this.lblTotalDescuento.Name = "lblTotalDescuento";
            this.lblTotalDescuento.Size = new System.Drawing.Size(131, 20);
            this.lblTotalDescuento.TabIndex = 9;
            this.lblTotalDescuento.Text = "Total_Descuento";
            // 
            // lblOtro
            // 
            this.lblOtro.AutoSize = true;
            this.lblOtro.Location = new System.Drawing.Point(73, 361);
            this.lblOtro.Name = "lblOtro";
            this.lblOtro.Size = new System.Drawing.Size(48, 20);
            this.lblOtro.TabIndex = 8;
            this.lblOtro.Text = "Otros";
            // 
            // lblISR
            // 
            this.lblISR.AutoSize = true;
            this.lblISR.Location = new System.Drawing.Point(73, 331);
            this.lblISR.Name = "lblISR";
            this.lblISR.Size = new System.Drawing.Size(37, 20);
            this.lblISR.TabIndex = 7;
            this.lblISR.Text = "ISR";
            // 
            // lblSFS
            // 
            this.lblSFS.AutoSize = true;
            this.lblSFS.Location = new System.Drawing.Point(73, 298);
            this.lblSFS.Name = "lblSFS";
            this.lblSFS.Size = new System.Drawing.Size(41, 20);
            this.lblSFS.TabIndex = 6;
            this.lblSFS.Text = "SFS";
            // 
            // lblAFP
            // 
            this.lblAFP.AutoSize = true;
            this.lblAFP.Location = new System.Drawing.Point(73, 267);
            this.lblAFP.Name = "lblAFP";
            this.lblAFP.Size = new System.Drawing.Size(40, 20);
            this.lblAFP.TabIndex = 5;
            this.lblAFP.Text = "AFP";
            this.lblAFP.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTotalsueldoMásIngresos
            // 
            this.lblTotalsueldoMásIngresos.AutoSize = true;
            this.lblTotalsueldoMásIngresos.Location = new System.Drawing.Point(73, 201);
            this.lblTotalsueldoMásIngresos.Name = "lblTotalsueldoMásIngresos";
            this.lblTotalsueldoMásIngresos.Size = new System.Drawing.Size(136, 20);
            this.lblTotalsueldoMásIngresos.TabIndex = 4;
            this.lblTotalsueldoMásIngresos.Text = "Tsueldo + Ingreso";
            // 
            // lblNhijo
            // 
            this.lblNhijo.AutoSize = true;
            this.lblNhijo.Location = new System.Drawing.Point(73, 166);
            this.lblNhijo.Name = "lblNhijo";
            this.lblNhijo.Size = new System.Drawing.Size(56, 20);
            this.lblNhijo.TabIndex = 3;
            this.lblNhijo.Text = "N hijos";
            // 
            // lblSueldo
            // 
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.Location = new System.Drawing.Point(73, 136);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(59, 20);
            this.lblSueldo.TabIndex = 2;
            this.lblSueldo.Text = "Sueldo";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(73, 103);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(52, 20);
            this.lblCargo.TabIndex = 1;
            this.lblCargo.Text = "Cargo";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(73, 68);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(65, 20);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DGV);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1034, 488);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tabla";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DGV
            // 
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Location = new System.Drawing.Point(48, 66);
            this.DGV.Name = "DGV";
            this.DGV.RowHeadersWidth = 62;
            this.DGV.RowTemplate.Height = 28;
            this.DGV.Size = new System.Drawing.Size(953, 389);
            this.DGV.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(35, 619);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 42);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Location = new System.Drawing.Point(132, 619);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(90, 42);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(231, 619);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 42);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClear.Location = new System.Drawing.Point(330, 619);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 42);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExit.Location = new System.Drawing.Point(429, 619);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 42);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 737);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblTotalDescuento;
        private System.Windows.Forms.Label lblOtro;
        private System.Windows.Forms.Label lblISR;
        private System.Windows.Forms.Label lblSFS;
        private System.Windows.Forms.Label lblAFP;
        private System.Windows.Forms.Label lblTotalsueldoMásIngresos;
        private System.Windows.Forms.Label lblNhijo;
        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblSueldoNeto;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtSueldoNeto;
        private System.Windows.Forms.TextBox txtTotalDescuento;
        private System.Windows.Forms.TextBox txtOtros;
        private System.Windows.Forms.TextBox txtISR;
        private System.Windows.Forms.TextBox txtSFS;
        private System.Windows.Forms.TextBox txtAFP;
        private System.Windows.Forms.TextBox txtTotalsueldoMásIngresos;
        private System.Windows.Forms.TextBox txtNhijos;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.ComboBox cmbCargo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCalcular;
    }
}

