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
    public partial class FRAME_PRODUCTO : Form
    {
        SqlConnection conexion = new SqlConnection("server= MSI; database=DB_Emily; integrated security = true");
        //SqlConnection conexion = new SqlConnection("server= 403-02\\ULACIT; database=DB_Emily; integrated security = true");

        public FRAME_PRODUCTO()
        {
            InitializeComponent();
            conexion.Open();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "" || txtNombre.Text != "" || txtPrecio.Text != "")
            {
                string cadena = "insert into Producto (Codigo, Nombre, Precio)"
                + " values (' " + txtCodigo.Text + "','" + txtNombre.Text + "','" + txtPrecio.Text + "')";

                SqlCommand comando = new SqlCommand(cadena, conexion);

                comando.ExecuteNonQuery();
            }

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            conexion.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string cadena = "delete from Producto where Codigo=" + txtCodigo.Text;
            SqlCommand comando = new SqlCommand(cadena, conexion);

            comando.ExecuteNonQuery();

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string cadena = "update Producto set " +
                "Nombre='" + txtNombre.Text + "'"
                + ", Precio='" + txtPrecio.Text + "'"
                + " where Codigo=" + txtCodigo.Text;

            SqlCommand comando = new SqlCommand(cadena, conexion);

            comando.ExecuteNonQuery();

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adaptador = new SqlDataAdapter("select * from Producto", conexion);
            adaptador.Fill(dt);
            gridProducto.DataSource = dt;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "")
            {
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter("select * from Producto where Codigo='" + txtCodigo.Text + "'", conexion);
                adapter.Fill(dt);
                gridProducto.DataSource = dt;
            }
        }

        private void FRAME_PRODUCTO_Load(object sender, EventArgs e)
        {

        }
    }
}
