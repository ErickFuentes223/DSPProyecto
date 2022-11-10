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
    public partial class InventarioAdmin : Form
    {
        public InventarioAdmin()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            AddProduct CambioF = new AddProduct();
            CambioF.Show();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            SqlConnection cnx;
            cnx = new SqlConnection("Data Source=.;Initial Catalog=FarmaciaDonBoscoDSP;Integrated Security=True");
            cnx.Open();

            string producto = txtproducto.Text;
            string marca = txtNameCustomer.Text;
            string precio = txtPrecio.Text;
            string caducidad = dateTimePicker1.Text;
            string sku = txtStock.Value.ToString();

            SqlCommand cm = new SqlCommand("DELETE productos where id_producto ="+numericUpDown1.Value , cnx);

            cm.ExecuteNonQuery();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            SqlConnection cnx;
            cnx = new SqlConnection("Data Source=.;Initial Catalog=FarmaciaDonBoscoDSP;Integrated Security=True");
            cnx.Open();

            string producto = txtproducto.Text;
            string marca = txtNameCustomer.Text;
            string precio = txtPrecio.Text;
            string caducidad = dateTimePicker1.Text;
            string sku = txtStock.Value.ToString();

            SqlCommand cm = new SqlCommand("Update productos set producto = '"+ producto + "',marca='"+ marca + "',precioUnitario='"+ precio + "',caducidad='"+ caducidad + "',sku='"+ sku + "' where id_producto =" +numericUpDown1.Value, cnx);

            cm.ExecuteNonQuery();

            cnx.Close();
        }

        private void InventarioAdmin_Load(object sender, EventArgs e)
        {
            mostrarInfoGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mostrarInfoGrid();
        }


        #region funciones

        public void mostrarInfoGrid()
        {
            SqlConnection cnx;
            cnx = new SqlConnection("Data Source=.;Initial Catalog=FarmaciaDonBoscoDSP;Integrated Security=True");
            cnx.Open();

            SqlDataAdapter adaptador = new SqlDataAdapter("Select * from productos", cnx);
            DataTable td = new DataTable();
            adaptador.Fill(td);
            dataGridView1.DataSource = td;
        }


        #endregion


    }
}
