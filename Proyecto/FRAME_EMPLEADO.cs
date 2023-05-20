using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class FRAME_EMPLEADO : Form
    {
        SqlConnection conexion = new SqlConnection("server= MSI; database=DB_Emily; integrated security = true");
        //SqlConnection conexion = new SqlConnection("server= 403-02\\ULACIT; database=DB_Emily; integrated security = true");

        public FRAME_EMPLEADO()
        {
            InitializeComponent();
            conexion.Open();
        }

        private void FRAME_EMPLEADO_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            conexion.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (txboxCedEmp.Text != "" || cmbDepartamento.Text != "" || txboxNomEmp.Text != "" ||
                txboxTelEmp.Text != "")
            {

                string cadena = "insert into Empleado (Cedula, Nombre, Telefono, Departamento)"
                + " values (' " + txboxCedEmp.Text + "','"
                + txboxNomEmp.Text + "','" + txboxTelEmp.Text + "','" + cmbDepartamento.Text + "')";

                SqlCommand comando = new SqlCommand(cadena, conexion);

                comando.ExecuteNonQuery();

                MessageBox.Show("Los datos se guardaron exitosamente");

            }

            txboxCedEmp.Text = "";
            txboxNomEmp.Text = "";
            txboxTelEmp.Text = "";
            cmbDepartamento.Text = "";
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string cadena = "update Empleado set " 
                + "Nombre='" + txboxNomEmp.Text + "'" 
                + ", Telefono='" + txboxTelEmp.Text + "'" 
                + ", Departamento='" + cmbDepartamento.Text + "'"
                +" where Cedula="+txboxCedEmp.Text;

            SqlCommand comando = new SqlCommand(cadena, conexion);

            comando.ExecuteNonQuery();

            txboxCedEmp.Text = "";
            txboxNomEmp.Text = "";
            txboxTelEmp.Text = "";
            cmbDepartamento.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string cadena = "delete from Empleado where Cedula=" + txboxCedEmp.Text;
            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.ExecuteNonQuery();

            txboxCedEmp.Text = "";
            txboxNomEmp.Text = "";
            txboxTelEmp.Text = "";
            cmbDepartamento.Text = "";
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adaptador = new SqlDataAdapter("select * from Empleado", conexion);
            adaptador.Fill(dt);
            GridEmpleado.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txboxCedEmp.Text != "")
            {
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter("select * from Empleado where Cedula='" + txboxCedEmp.Text + "'", conexion);
                adapter.Fill(dt);
                GridEmpleado.DataSource = dt;
            }
        }
    }
}
