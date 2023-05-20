using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class FRAME_MENU : Form
    {
        public FRAME_MENU()
        {
            InitializeComponent();
        }

        private void cLIENTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRAME_CLIENTE FrmClt= new FRAME_CLIENTE();
            FrmClt.Show();
        }

        private void eMPLEADOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRAME_EMPLEADO FrmEmp= new FRAME_EMPLEADO();
            FrmEmp.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pRODUCTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRAME_PRODUCTO FrmPro= new FRAME_PRODUCTO();
            FrmPro.Show();
        }

        private void fACTURACIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRAME_FACTURACION FrmFact= new FRAME_FACTURACION();
            FrmFact.Show();
        }

        private void FRAME_MENU_Load(object sender, EventArgs e)
        {

        }
    }
}
