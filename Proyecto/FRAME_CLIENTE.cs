using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto
{
    public partial class FRAME_CLIENTE : Form
    {
        SqlConnection conexion = new SqlConnection("server= MSI; database=DB_Emily; integrated security = true");
        //SqlConnection conexion = new SqlConnection("server= 403-02\\ULACIT; database=DB_Emily; integrated security = true");

        public FRAME_CLIENTE()
        {
            InitializeComponent();
            conexion.Open();
        }

        private void txboxCedClt_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txboxCedClt.Text != "" || txboxNomClt.Text != "" || txboxTelClt.Text != ""
                || txboxCorClt.Text != "" || txboxEmpClt.Text != "" || txboxDirClt.Text != "") 
            {
                string cadena = "insert into Cliente (Cedula, Nombre, Telefono, Correo_electronico, Empresa, Direccion)"
                + " values (' " + txboxCedClt.Text + "','" + txboxNomClt.Text + "','" + txboxTelClt.Text + "','" + txboxCorClt.Text + "','"
                + txboxEmpClt.Text + "','" + txboxDirClt.Text + "')";

                SqlCommand comando = new SqlCommand(cadena, conexion);

                comando.ExecuteNonQuery();
            }
            
            txboxCedClt.Text = "";
            txboxNomClt.Text = "";
            txboxTelClt.Text = "";
            txboxCorClt.Text = "";
            txboxEmpClt.Text = "";
            txboxDirClt.Text = "";   
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            conexion.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string cadena = "delete from Cliente where Cedula=" + txboxCedClt.Text;
            SqlCommand comando = new SqlCommand(cadena, conexion);

            comando.ExecuteNonQuery();

            txboxCedClt.Text = "";
            txboxNomClt.Text = "";
            txboxTelClt.Text = "";
            txboxCorClt.Text = "";
            txboxEmpClt.Text = "";
            txboxDirClt.Text = "";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string cadena = "update Cliente set " +
                "Nombre='" + txboxNomClt.Text + "'"
                + ", Telefono='" + txboxTelClt.Text + "'"
                + ", Correo_electronico='" + txboxCorClt.Text + "'"
                + ", Empresa='" + txboxEmpClt.Text + "'"
                + ", Direccion='" + txboxDirClt.Text + "'"
                + " where Cedula=" + txboxCedClt.Text;

            SqlCommand comando = new SqlCommand(cadena, conexion);

            comando.ExecuteNonQuery();

            txboxCedClt.Text = "";
            txboxNomClt.Text = "";
            txboxTelClt.Text = "";
            txboxCorClt.Text = "";
            txboxEmpClt.Text = "";
            txboxDirClt.Text = "";
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adaptador = new SqlDataAdapter("select * from Cliente", conexion);
            adaptador.Fill(dt);
            GridCliente.DataSource = dt;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
            if (txboxCedClt.Text!="")
            {
                DataTable dt=new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter("select * from Cliente where Cedula='"+txboxCedClt.Text+"'",conexion);
                adapter.Fill(dt);
                GridCliente.DataSource = dt;
            }
        }

        private void FRAME_CLIENTE_Load(object sender, EventArgs e)
        {

        }
    }
}
