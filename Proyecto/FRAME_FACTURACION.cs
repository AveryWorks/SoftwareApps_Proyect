using Aspose.Pdf;
using Aspose.Pdf.Text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.SymbolStore;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Page = Aspose.Pdf.Page;

namespace Proyecto
{
    public partial class FRAME_FACTURACION : Form
    {
        SqlConnection conexion = new SqlConnection("server= MSI; database=DB_Emily; integrated security = true");
        //SqlConnection conexion = new SqlConnection("server= 403-02\\ULACIT; database=DB_Emily; integrated security = true");

        public FRAME_FACTURACION()
        {
            InitializeComponent();
            conexion.Open();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public int precios(int Codigo_producto,int cantidad)
        {
            int precioTotal=0;
            int precio=0;

            if (cmbCodigoProducto.Text != "")
            {
                string cadena = "select Precio from Producto where Codigo=" + cmbCodigoProducto.Text;
                SqlCommand comando = new SqlCommand(cadena, conexion);
                SqlDataReader Sdr = comando.ExecuteReader();

                while (Sdr.Read())
                {
                    for (int i = 0; i < Sdr.FieldCount; i++)
                    {
                        precio = Sdr.GetInt32(i);
                    }
                }
                Sdr.Close();
            }

            precioTotal = precio * cantidad;
            
            return precioTotal;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "" || txtCantidad.Text != "" ||
                txtFecha.Text != "" || cmbCedulaCliente.Text !="" || cmbCedulaEmpleado.Text !="" || cmbCodigoProducto.Text!="")
            {
                txtPrecio.Text=precios(int.Parse(cmbCodigoProducto.Text), int.Parse(txtCantidad.Text)).ToString();

                string cadena = "insert into Factura_temp (Codigo, Cedula_cliente, Cedula_empleado, Codigo_producto, Cant_producto, Precio, Fecha)"
                + " values (' " + txtCodigo.Text + "','" + cmbCedulaCliente.Text + "','" + cmbCedulaEmpleado.Text + "','" + cmbCodigoProducto.Text + "','"
                + txtCantidad.Text + "','" + txtPrecio.Text + "','" + txtFecha.Text + "')";

                SqlCommand comando = new SqlCommand(cadena, conexion);

                comando.ExecuteNonQuery();

                MessageBox.Show("Los datos se guardaron exitosamente");

            }

            txtCodigo.Text = "";
            txtCantidad.Text = "";
            txtPrecio.Text = "";
            txtFecha.Text = "";
            cmbCedulaCliente.Text = "";
            cmbCedulaEmpleado.Text = "";
            cmbCodigoProducto.Text = "";

        }

        private void FRAME_FACTURACION_Load(object sender, EventArgs e)
        {

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            fillCombos();

            DataTable dt = new DataTable();
            SqlDataAdapter adaptador = new SqlDataAdapter("select * from Factura_temp", conexion);
            adaptador.Fill(dt);
            GridFactTemp.DataSource = dt;
        }

        public void fillCombos()
        {
            if (cmbCedulaCliente.Items.Count == 0)
            {
                string cadena = "select Cedula from Cliente";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                SqlDataReader Sdr=comando.ExecuteReader();
                int cedTemp = 0;

                while(Sdr.Read())
                {
                    for(int i=0;i<Sdr.FieldCount;i++)
                    {
                        cedTemp = Sdr.GetInt32(i);
                        cmbCedulaCliente.Items.Add(cedTemp);
                    }
                }
                Sdr.Close();

                string cadena2 = "select Cedula from Empleado";
                SqlCommand comando2 = new SqlCommand(cadena2, conexion);
                SqlDataReader Sdr2 = comando2.ExecuteReader();
                int cedTemp2 = 0;

                while (Sdr2.Read())
                {
                    for (int i = 0; i < Sdr2.FieldCount; i++)
                    {
                        cedTemp2 = Sdr2.GetInt32(i);
                        cmbCedulaEmpleado.Items.Add(cedTemp2);
                    }
                }
                Sdr2.Close();

                string cadena3 = "select Codigo from Producto";
                SqlCommand comando3 = new SqlCommand(cadena3, conexion);
                SqlDataReader Sdr3 = comando3.ExecuteReader();
                int cedTemp3 = 0;

                while (Sdr3.Read())
                {
                    for (int i = 0; i < Sdr3.FieldCount; i++)
                    {
                        cedTemp3 = Sdr3.GetInt32(i);
                        cmbCodigoProducto.Items.Add(cedTemp3);
                    }
                }

                Sdr3.Close();

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string cadena = "delete from Factura_temp where Codigo=" + txtCodigo.Text;
            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.ExecuteNonQuery();

            txtCodigo.Text = "";
            txtCantidad.Text = "";
            txtPrecio.Text = "";
            txtFecha.Text = "";
            cmbCedulaCliente.Text = "";
            cmbCedulaEmpleado.Text = "";
            cmbCodigoProducto.Text = "";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string cadena = "update Factura_temp set "
                + "Cedula_cliente='" + cmbCedulaCliente.Text + "'"
                + ", Cedula_empleado='" + cmbCedulaEmpleado.Text + "'"
                + ", Codigo_producto='" + cmbCodigoProducto.Text + "'"
                + ", Precio='" + txtPrecio.Text + "'"
                + ", Cant_producto='" + txtCantidad.Text + "'"
                + ", Fecha='" + txtFecha.Text + "'"
                + " where Codigo=" + txtCodigo.Text;

            SqlCommand comando = new SqlCommand(cadena, conexion);

            comando.ExecuteNonQuery();

            txtCodigo.Text = "";
            txtCantidad.Text = "";
            txtPrecio.Text = "";
            txtFecha.Text = "";
            cmbCedulaCliente.Text = "";
            cmbCedulaEmpleado.Text = "";
            cmbCodigoProducto.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            conexion.Close();
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            Document Factura =new Document();
            Page pagina = Factura.Pages.Add();
            string cadena = "insert into Facturacion select * from Factura_temp";
            
            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.ExecuteNonQuery();


            
            
             SqlCommand solicitar = new SqlCommand("select * from Factura_temp",conexion);
             SqlDataReader Lector = solicitar.ExecuteReader();
             pagina.PageInfo.Margin.Top = 50;
             pagina.PageInfo.Margin.Bottom = 50;
             pagina.PageInfo.Margin.Left = 50;
             pagina.PageInfo.Margin.Right = 50;
                TextFragment titulo = new TextFragment("FLORISTERIA");
            TextFragment txf8 = new TextFragment("---------------------------------------------------------");

            pagina.Paragraphs.Add(titulo);
            pagina.Paragraphs.Add(txf8);

            titulo.TextState.FontSize= 35;


                

                while (Lector.Read())
                    {
                    
                            int Codigo = Lector.GetInt32(0);
                            TextFragment txf = new TextFragment("Codigo de la compra :" + Codigo + "");
                            pagina.Paragraphs.Add(txf);
                            int Ced_Cli = Lector.GetInt32(1);
                            TextFragment txf1 = new TextFragment("Cedula del cliente :" + Ced_Cli + "");
                            pagina.Paragraphs.Add(txf1);
                            int Ced_Emp = Lector.GetInt32(2);
                            TextFragment txf2 = new TextFragment("Cedula del empleado :" + Ced_Emp + "");
                            pagina.Paragraphs.Add(txf2);
                            int Cod_Pro = Lector.GetInt32(3);
                            TextFragment txf3 = new TextFragment("Codigo de produccion :" + Cod_Pro + "");
                            pagina.Paragraphs.Add(txf3);
                            int Cant_Pro= Lector.GetInt32(4);
                            TextFragment txf4 = new TextFragment("Cantidad de productos :" + Cant_Pro + "");
                            pagina.Paragraphs.Add(txf4);
                            int Precio= Lector.GetInt32(5);
                            TextFragment txf5 = new TextFragment("Precio :" + Precio + "");
                            pagina.Paragraphs.Add(txf5);
                            DateTime dateTime= Lector.GetDateTime(6);
                            TextFragment txf6 = new TextFragment("Fecha :" + dateTime + "");
                            pagina.Paragraphs.Add(txf6); 
                            txf.TextState.FontSize = 20;
                            txf1.TextState.FontSize = 20;
                            txf2.TextState.FontSize = 20;
                            txf3.TextState.FontSize = 20;
                            txf4.TextState.FontSize = 20;
                            txf5.TextState.FontSize = 20;
                            txf6.TextState.FontSize = 20;
                            pagina.Paragraphs.Add(txf8);
                    }
                
                int count =1;
                string direccionArchivo = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Factura"+count+".pdf";
                Factura.Save(direccionArchivo);
                Lector.Close();
            count++;
            

            string cadena2 = "truncate table Factura_temp";

            SqlCommand comando2 = new SqlCommand(cadena2, conexion);
            comando2.ExecuteNonQuery();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_cierre_Click(object sender, EventArgs e)
        {
            Document Cierre = new Document();
            Page pagina = Cierre.Pages.Add();
            SqlCommand solicitar = new SqlCommand("select * from Facturacion", conexion);

            SqlDataReader Lector = solicitar.ExecuteReader();

            pagina.PageInfo.Margin.Top = 50;
            pagina.PageInfo.Margin.Bottom = 50;
            pagina.PageInfo.Margin.Left = 50;
            pagina.PageInfo.Margin.Right = 50;
            TextFragment titulo = new TextFragment("FLORISTERIA");
            TextFragment txf8 = new TextFragment("----------------------------------------------------------------");

            pagina.Paragraphs.Add(titulo);
            titulo.TextState.FontSize = 35;
            txf8.TextState.FontSize = 35;

            pagina.Paragraphs.Add(txf8);
            TextFragment Subtitulo = new TextFragment("Cierre de caja");
            pagina.Paragraphs.Add(Subtitulo);
            Subtitulo.TextState.FontSize = 35;
            pagina.Paragraphs.Add(txf8);


            while (Lector.Read())
            {

                int Codigo = Lector.GetInt32(0);
                TextFragment txf = new TextFragment("Codigo de la compra :" + Codigo + "");
                pagina.Paragraphs.Add(txf);
                int Ced_Cli = Lector.GetInt32(1);
                TextFragment txf1 = new TextFragment("Cedula del cliente :" + Ced_Cli + "");
                pagina.Paragraphs.Add(txf1);
                int Ced_Emp = Lector.GetInt32(2);
                TextFragment txf2 = new TextFragment("Cedula del empleado :" + Ced_Emp + "");
                pagina.Paragraphs.Add(txf2);
                int Cod_Pro = Lector.GetInt32(3);
                TextFragment txf3 = new TextFragment("Codigo de produccion :" + Cod_Pro + "");
                pagina.Paragraphs.Add(txf3);
                int Cant_Pro = Lector.GetInt32(4);
                TextFragment txf4 = new TextFragment("Cantidad de productos :" + Cant_Pro + "");
                pagina.Paragraphs.Add(txf4);
                int Precio = Lector.GetInt32(5);
                TextFragment txf5 = new TextFragment("Precio :" + Precio + "");
                pagina.Paragraphs.Add(txf5);
                DateTime dateTime = Lector.GetDateTime(6);
                TextFragment txf6 = new TextFragment("Fecha :" + dateTime + "");
                pagina.Paragraphs.Add(txf6);
                txf.TextState.FontSize = 20;
                txf1.TextState.FontSize = 20;
                txf2.TextState.FontSize = 20;
                txf3.TextState.FontSize = 20;
                txf4.TextState.FontSize = 20;
                txf5.TextState.FontSize = 20;
                txf6.TextState.FontSize = 20;
                pagina.Paragraphs.Add(txf8);

            }
            int count = 1;
            string direccionArchivo = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\CierreDeCaja"+count+".pdf";
            Cierre.Save(direccionArchivo);
            Lector.Close();
            count++;

        }
    }
}
