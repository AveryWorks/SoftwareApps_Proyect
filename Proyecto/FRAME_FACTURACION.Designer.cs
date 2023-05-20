namespace Proyecto
{
    partial class FRAME_FACTURACION
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblCedulaCliente = new System.Windows.Forms.Label();
            this.lblCedulaEmpleado = new System.Windows.Forms.Label();
            this.lblCodigoProducto = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.cmbCedulaCliente = new System.Windows.Forms.ComboBox();
            this.cmbCedulaEmpleado = new System.Windows.Forms.ComboBox();
            this.cmbCodigoProducto = new System.Windows.Forms.ComboBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.GridFactTemp = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btn_cierre = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridFactTemp)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(146, 36);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(93, 25);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "CODIGO";
            this.lblCodigo.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblCedulaCliente
            // 
            this.lblCedulaCliente.AutoSize = true;
            this.lblCedulaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedulaCliente.Location = new System.Drawing.Point(57, 78);
            this.lblCedulaCliente.Name = "lblCedulaCliente";
            this.lblCedulaCliente.Size = new System.Drawing.Size(182, 25);
            this.lblCedulaCliente.TabIndex = 1;
            this.lblCedulaCliente.Text = "CEDULA CLIENTE";
            // 
            // lblCedulaEmpleado
            // 
            this.lblCedulaEmpleado.AutoSize = true;
            this.lblCedulaEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedulaEmpleado.Location = new System.Drawing.Point(30, 119);
            this.lblCedulaEmpleado.Name = "lblCedulaEmpleado";
            this.lblCedulaEmpleado.Size = new System.Drawing.Size(209, 25);
            this.lblCedulaEmpleado.TabIndex = 2;
            this.lblCedulaEmpleado.Text = "CEDULA EMPLEADO";
            // 
            // lblCodigoProducto
            // 
            this.lblCodigoProducto.AutoSize = true;
            this.lblCodigoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoProducto.Location = new System.Drawing.Point(27, 164);
            this.lblCodigoProducto.Name = "lblCodigoProducto";
            this.lblCodigoProducto.Size = new System.Drawing.Size(212, 25);
            this.lblCodigoProducto.TabIndex = 3;
            this.lblCodigoProducto.Text = "CODIGO PRODUCTO";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(121, 208);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(115, 25);
            this.lblCantidad.TabIndex = 4;
            this.lblCantidad.Text = "CANTIDAD";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(149, 250);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(87, 25);
            this.lblPrecio.TabIndex = 5;
            this.lblPrecio.Text = "PRECIO";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(156, 288);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(80, 25);
            this.lblFecha.TabIndex = 6;
            this.lblFecha.Text = "FECHA";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(256, 33);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(286, 30);
            this.txtCodigo.TabIndex = 7;
            // 
            // cmbCedulaCliente
            // 
            this.cmbCedulaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCedulaCliente.FormattingEnabled = true;
            this.cmbCedulaCliente.Location = new System.Drawing.Point(256, 75);
            this.cmbCedulaCliente.Name = "cmbCedulaCliente";
            this.cmbCedulaCliente.Size = new System.Drawing.Size(286, 33);
            this.cmbCedulaCliente.TabIndex = 8;
            // 
            // cmbCedulaEmpleado
            // 
            this.cmbCedulaEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCedulaEmpleado.FormattingEnabled = true;
            this.cmbCedulaEmpleado.Location = new System.Drawing.Point(256, 116);
            this.cmbCedulaEmpleado.Name = "cmbCedulaEmpleado";
            this.cmbCedulaEmpleado.Size = new System.Drawing.Size(286, 33);
            this.cmbCedulaEmpleado.TabIndex = 9;
            // 
            // cmbCodigoProducto
            // 
            this.cmbCodigoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCodigoProducto.FormattingEnabled = true;
            this.cmbCodigoProducto.Location = new System.Drawing.Point(256, 161);
            this.cmbCodigoProducto.Name = "cmbCodigoProducto";
            this.cmbCodigoProducto.Size = new System.Drawing.Size(286, 33);
            this.cmbCodigoProducto.TabIndex = 10;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(256, 205);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(286, 30);
            this.txtCantidad.TabIndex = 11;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(256, 247);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.ReadOnly = true;
            this.txtPrecio.Size = new System.Drawing.Size(286, 30);
            this.txtPrecio.TabIndex = 12;
            // 
            // txtFecha
            // 
            this.txtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(256, 285);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(286, 30);
            this.txtFecha.TabIndex = 13;
            // 
            // GridFactTemp
            // 
            this.GridFactTemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridFactTemp.Location = new System.Drawing.Point(35, 404);
            this.GridFactTemp.Name = "GridFactTemp";
            this.GridFactTemp.Size = new System.Drawing.Size(551, 189);
            this.GridFactTemp.TabIndex = 14;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(80, 333);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(136, 23);
            this.btnAgregar.TabIndex = 29;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(80, 362);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(136, 23);
            this.btnCargar.TabIndex = 2;
            this.btnCargar.Text = "CARGAR";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(242, 333);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(136, 23);
            this.btnEliminar.TabIndex = 29;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnFacturar
            // 
            this.btnFacturar.Location = new System.Drawing.Point(242, 362);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(136, 23);
            this.btnFacturar.TabIndex = 18;
            this.btnFacturar.Text = "FACTURAR";
            this.btnFacturar.UseVisualStyleBackColor = true;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(406, 333);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(136, 23);
            this.btnModificar.TabIndex = 19;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(406, 362);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(136, 23);
            this.btnSalir.TabIndex = 20;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btn_cierre
            // 
            this.btn_cierre.Location = new System.Drawing.Point(242, 623);
            this.btn_cierre.Name = "btn_cierre";
            this.btn_cierre.Size = new System.Drawing.Size(136, 23);
            this.btn_cierre.TabIndex = 30;
            this.btn_cierre.Text = "CIERRE DE CAJA";
            this.btn_cierre.UseVisualStyleBackColor = true;
            this.btn_cierre.Click += new System.EventHandler(this.btn_cierre_Click);
            // 
            // FRAME_FACTURACION
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 674);
            this.Controls.Add(this.btn_cierre);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.GridFactTemp);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.cmbCodigoProducto);
            this.Controls.Add(this.cmbCedulaEmpleado);
            this.Controls.Add(this.cmbCedulaCliente);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblCodigoProducto);
            this.Controls.Add(this.lblCedulaEmpleado);
            this.Controls.Add(this.lblCedulaCliente);
            this.Controls.Add(this.lblCodigo);
            this.Name = "FRAME_FACTURACION";
            this.Text = "FACTURACION";
            this.Load += new System.EventHandler(this.FRAME_FACTURACION_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridFactTemp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblCedulaCliente;
        private System.Windows.Forms.Label lblCedulaEmpleado;
        private System.Windows.Forms.Label lblCodigoProducto;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.ComboBox cmbCedulaCliente;
        private System.Windows.Forms.ComboBox cmbCedulaEmpleado;
        private System.Windows.Forms.ComboBox cmbCodigoProducto;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.DataGridView GridFactTemp;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btn_cierre;
    }
}