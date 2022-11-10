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
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection cnx;
            cnx = new SqlConnection("Data Source=.;Initial Catalog=FarmaciaDonBoscoDSP;Integrated Security=True");
            cnx.Open();

            string producto = txtproducto.Text;
            string marca = txtNameCustomer.Text;
            string precio = txtPrecio.Text;
            string caducidad = dateTimePicker1.Text;
            string sku = txtStock.Value.ToString();
            string tipo = comboBoxTipo.Text;

            SqlCommand cm = new SqlCommand("INSERT INTO productos(producto, marca, precioUnitario, caducidad, sku, tipo) values ('"+producto+"','"+marca+"',"+precio+",'"+caducidad+"',"+sku+",'"+tipo+"')", cnx);

            cm.ExecuteNonQuery();

            MessageBox.Show("Se ha registrado correctamente", "Farmacia Don Bosco", MessageBoxButtons.OK);

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
