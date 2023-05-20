namespace Proyecto
{
    partial class FRAME_EMPLEADO
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
            this.button4 = new System.Windows.Forms.Button();
            this.GridEmpleado = new System.Windows.Forms.DataGridView();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txboxTelEmp = new System.Windows.Forms.TextBox();
            this.txboxNomEmp = new System.Windows.Forms.TextBox();
            this.txboxCedEmp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.cmbDepartamento = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(235, 234);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(136, 23);
            this.button4.TabIndex = 33;
            this.button4.Text = "BUSCAR";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // GridEmpleado
            // 
            this.GridEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridEmpleado.Location = new System.Drawing.Point(55, 279);
            this.GridEmpleado.Name = "GridEmpleado";
            this.GridEmpleado.Size = new System.Drawing.Size(501, 310);
            this.GridEmpleado.TabIndex = 32;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(418, 205);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(136, 23);
            this.btnModificar.TabIndex = 31;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(235, 205);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(136, 23);
            this.btnEliminar.TabIndex = 30;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(53, 205);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(136, 23);
            this.btnAgregar.TabIndex = 29;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txboxTelEmp
            // 
            this.txboxTelEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txboxTelEmp.Location = new System.Drawing.Point(237, 107);
            this.txboxTelEmp.Name = "txboxTelEmp";
            this.txboxTelEmp.Size = new System.Drawing.Size(286, 30);
            this.txboxTelEmp.TabIndex = 25;
            // 
            // txboxNomEmp
            // 
            this.txboxNomEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txboxNomEmp.Location = new System.Drawing.Point(237, 65);
            this.txboxNomEmp.Name = "txboxNomEmp";
            this.txboxNomEmp.Size = new System.Drawing.Size(286, 30);
            this.txboxNomEmp.TabIndex = 24;
            // 
            // txboxCedEmp
            // 
            this.txboxCedEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txboxCedEmp.Location = new System.Drawing.Point(237, 20);
            this.txboxCedEmp.Name = "txboxCedEmp";
            this.txboxCedEmp.Size = new System.Drawing.Size(286, 30);
            this.txboxCedEmp.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "DEPARTAMENTO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(97, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "TELEFONO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(124, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "CEDULA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "NOMBRE";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(418, 234);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(136, 23);
            this.btnSalir.TabIndex = 34;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(55, 234);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(136, 23);
            this.btnCargar.TabIndex = 35;
            this.btnCargar.Text = "CARGAR";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDepartamento.FormattingEnabled = true;
            this.cmbDepartamento.Items.AddRange(new object[] {
            "Cajas",
            "Transporte",
            "Producción",
            "Paquetería",
            "Administración"});
            this.cmbDepartamento.Location = new System.Drawing.Point(235, 151);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Size = new System.Drawing.Size(288, 33);
            this.cmbDepartamento.TabIndex = 36;
            // 
            // FRAME_EMPLEADO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 611);
            this.Controls.Add(this.cmbDepartamento);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.GridEmpleado);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txboxTelEmp);
            this.Controls.Add(this.txboxNomEmp);
            this.Controls.Add(this.txboxCedEmp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FRAME_EMPLEADO";
            this.Text = "EMPLEADO";
            this.Load += new System.EventHandler(this.FRAME_EMPLEADO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridEmpleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView GridEmpleado;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txboxTelEmp;
        private System.Windows.Forms.TextBox txboxNomEmp;
        private System.Windows.Forms.TextBox txboxCedEmp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.ComboBox cmbDepartamento;
    }
}