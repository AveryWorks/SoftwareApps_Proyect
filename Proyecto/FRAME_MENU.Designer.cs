namespace Proyecto
{
    partial class FRAME_MENU
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRAME_MENU));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mANTENIMINETOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLIENTEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eMPLEADOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pRODUCTOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fACTURACIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnSalir = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mANTENIMINETOToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(525, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mANTENIMINETOToolStripMenuItem
            // 
            this.mANTENIMINETOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cLIENTEToolStripMenuItem,
            this.eMPLEADOToolStripMenuItem,
            this.pRODUCTOSToolStripMenuItem,
            this.fACTURACIONToolStripMenuItem});
            this.mANTENIMINETOToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.mANTENIMINETOToolStripMenuItem.Name = "mANTENIMINETOToolStripMenuItem";
            this.mANTENIMINETOToolStripMenuItem.Size = new System.Drawing.Size(178, 32);
            this.mANTENIMINETOToolStripMenuItem.Text = "MENU PRINCIPAL";
            // 
            // cLIENTEToolStripMenuItem
            // 
            this.cLIENTEToolStripMenuItem.Name = "cLIENTEToolStripMenuItem";
            this.cLIENTEToolStripMenuItem.Size = new System.Drawing.Size(214, 32);
            this.cLIENTEToolStripMenuItem.Text = "CLIENTE";
            this.cLIENTEToolStripMenuItem.Click += new System.EventHandler(this.cLIENTEToolStripMenuItem_Click);
            // 
            // eMPLEADOToolStripMenuItem
            // 
            this.eMPLEADOToolStripMenuItem.Name = "eMPLEADOToolStripMenuItem";
            this.eMPLEADOToolStripMenuItem.Size = new System.Drawing.Size(214, 32);
            this.eMPLEADOToolStripMenuItem.Text = "EMPLEADO";
            this.eMPLEADOToolStripMenuItem.Click += new System.EventHandler(this.eMPLEADOToolStripMenuItem_Click);
            // 
            // pRODUCTOSToolStripMenuItem
            // 
            this.pRODUCTOSToolStripMenuItem.Name = "pRODUCTOSToolStripMenuItem";
            this.pRODUCTOSToolStripMenuItem.Size = new System.Drawing.Size(214, 32);
            this.pRODUCTOSToolStripMenuItem.Text = "PRODUCTOS";
            this.pRODUCTOSToolStripMenuItem.Click += new System.EventHandler(this.pRODUCTOSToolStripMenuItem_Click);
            // 
            // fACTURACIONToolStripMenuItem
            // 
            this.fACTURACIONToolStripMenuItem.Name = "fACTURACIONToolStripMenuItem";
            this.fACTURACIONToolStripMenuItem.Size = new System.Drawing.Size(214, 32);
            this.fACTURACIONToolStripMenuItem.Text = "FACTURACION";
            this.fACTURACIONToolStripMenuItem.Click += new System.EventHandler(this.fACTURACIONToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(427, 305);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.button1_Click);
            // 
            // FRAME_MENU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto.Properties.Resources.FONDO_FLORES_FRAME_MENU;
            this.ClientSize = new System.Drawing.Size(525, 354);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FRAME_MENU";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MENU";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.FRAME_MENU_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mANTENIMINETOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cLIENTEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eMPLEADOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pRODUCTOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fACTURACIONToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnSalir;
    }
}

