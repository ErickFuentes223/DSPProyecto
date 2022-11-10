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

namespace DSPProyecto
{
    public partial class Facturizacion : Form
    {
        public Facturizacion()
        {
            InitializeComponent();

            mostrarInfoGrid();

        }

        private void label2_Click_1(object sender, EventArgs e)
        {
           Login CambioF = new Login();
            CambioF.Show();
            this.Close();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            InicioAdmin CambioF = new InicioAdmin();
            CambioF.Show();
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            txtNameCustomer.Clear();
            txtProduct.Clear();
        }

        private void Facturizacion_Load(object sender, EventArgs e)
        {

        }



        #region funciones

        public void mostrarInfoGrid()
        {
            SqlConnection cnx;
            cnx = new SqlConnection("Data Source=.;Initial Catalog=FarmaciaDonBoscoDSP;Integrated Security=True");
            cnx.Open();

            SqlDataAdapter adaptador = new SqlDataAdapter("Select * from facturas", cnx);
            DataTable td = new DataTable();
            adaptador.Fill(td);
            dataGridView1.DataSource = td;
        }

        public void AgregarFactura()
        {
            SqlConnection cnx;
            cnx = new SqlConnection("Data Source=.;Initial Catalog=FarmaciaDonBoscoDSP;Integrated Security=True");
            cnx.Open();

            SqlCommand precio = new SqlCommand("Select precioUnitario from productos where producto='" + txtProduct.Text + "' ", cnx);
            SqlDataReader dr = precio.ExecuteReader();
            if (dr.Read())
            {
                
                string precioBDTexto = dr.GetValue(0).ToString();
                double precioBD = Convert.ToDouble(precioBDTexto);
                double descuento = (Convert.ToDouble(txtDescuento.Value)) / 100;
                double cantidadProduct = Convert.ToDouble(txtCantidad.Value);

                var precioTotal = (precioBD * cantidadProduct) - ((precioBD * cantidadProduct) * descuento);

                SqlCommand cm = new SqlCommand("INSERT INTO facturas(producto,fecha,cliente,cantidad,tipoPago,descuento,precioTotal) values ('" + txtProduct.Text + "', '" + dateTimePicker2.Text + "', '" + txtNameCustomer.Text + "'," + cantidadProduct + ", '" + comboBox1.Text + "'," + descuento + ", " + precioTotal + ");", cnx);

                dr.Close();
                cm.ExecuteNonQuery();

                MessageBox.Show("Se ha registrado correctamente", "Farmacia Don Bosco", MessageBoxButtons.OK);


            }
            else
            {
                MessageBox.Show("malo");
            }

            
        }


        #endregion

        private void button1_Click_1(object sender, EventArgs e)
        {

            AgregarFactura();
        }
    }
}
