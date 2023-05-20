namespace Proyecto
{
    partial class FRAME_CLIENTE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRAME_CLIENTE));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txboxCedClt = new System.Windows.Forms.TextBox();
            this.txboxNomClt = new System.Windows.Forms.TextBox();
            this.txboxTelClt = new System.Windows.Forms.TextBox();
            this.txboxCorClt = new System.Windows.Forms.TextBox();
            this.txboxEmpClt = new System.Windows.Forms.TextBox();
            this.txboxDirClt = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.GridCliente = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOMBRE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(183, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "CEDULA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(178, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "CORREO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(156, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "TELEFONO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(154, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "DIRECCION";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(167, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "EMPRESA";
            // 
            // txboxCedClt
            // 
            this.txboxCedClt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txboxCedClt.Location = new System.Drawing.Point(296, 12);
            this.txboxCedClt.Name = "txboxCedClt";
            this.txboxCedClt.Size = new System.Drawing.Size(286, 30);
            this.txboxCedClt.TabIndex = 6;
            this.txboxCedClt.TextChanged += new System.EventHandler(this.txboxCedClt_TextChanged);
            // 
            // txboxNomClt
            // 
            this.txboxNomClt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txboxNomClt.Location = new System.Drawing.Point(296, 57);
            this.txboxNomClt.Name = "txboxNomClt";
            this.txboxNomClt.Size = new System.Drawing.Size(286, 30);
            this.txboxNomClt.TabIndex = 7;
            // 
            // txboxTelClt
            // 
            this.txboxTelClt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txboxTelClt.Location = new System.Drawing.Point(296, 99);
            this.txboxTelClt.Name = "txboxTelClt";
            this.txboxTelClt.Size = new System.Drawing.Size(286, 30);
            this.txboxTelClt.TabIndex = 8;
            // 
            // txboxCorClt
            // 
            this.txboxCorClt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txboxCorClt.Location = new System.Drawing.Point(296, 140);
            this.txboxCorClt.Name = "txboxCorClt";
            this.txboxCorClt.Size = new System.Drawing.Size(286, 30);
            this.txboxCorClt.TabIndex = 9;
            // 
            // txboxEmpClt
            // 
            this.txboxEmpClt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txboxEmpClt.Location = new System.Drawing.Point(296, 184);
            this.txboxEmpClt.Name = "txboxEmpClt";
            this.txboxEmpClt.Size = new System.Drawing.Size(286, 30);
            this.txboxEmpClt.TabIndex = 10;
            // 
            // txboxDirClt
            // 
            this.txboxDirClt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txboxDirClt.Location = new System.Drawing.Point(296, 227);
            this.txboxDirClt.Name = "txboxDirClt";
            this.txboxDirClt.Size = new System.Drawing.Size(286, 30);
            this.txboxDirClt.TabIndex = 11;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(114, 286);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(136, 23);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(296, 286);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(136, 23);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(479, 286);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(136, 23);
            this.btnModificar.TabIndex = 14;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // GridCliente
            // 
            this.GridCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridCliente.Location = new System.Drawing.Point(25, 357);
            this.GridCliente.Name = "GridCliente";
            this.GridCliente.ShowRowErrors = false;
            this.GridCliente.Size = new System.Drawing.Size(666, 233);
            this.GridCliente.TabIndex = 15;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(296, 315);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(136, 23);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(479, 319);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(136, 23);
            this.btnSalir.TabIndex = 17;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(114, 319);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(136, 23);
            this.btnCargar.TabIndex = 18;
            this.btnCargar.Text = "CARGAR";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // FRAME_CLIENTE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 611);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.GridCliente);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txboxDirClt);
            this.Controls.Add(this.txboxEmpClt);
            this.Controls.Add(this.txboxCorClt);
            this.Controls.Add(this.txboxTelClt);
            this.Controls.Add(this.txboxNomClt);
            this.Controls.Add(this.txboxCedClt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRAME_CLIENTE";
            this.Text = "CLIENTE";
            this.Load += new System.EventHandler(this.FRAME_CLIENTE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txboxCedClt;
        private System.Windows.Forms.TextBox txboxNomClt;
        private System.Windows.Forms.TextBox txboxTelClt;
        private System.Windows.Forms.TextBox txboxCorClt;
        private System.Windows.Forms.TextBox txboxEmpClt;
        private System.Windows.Forms.TextBox txboxDirClt;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridView GridCliente;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCargar;
    }
}