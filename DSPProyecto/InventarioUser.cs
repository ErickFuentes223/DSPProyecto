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
    public partial class InventarioUser : Form
    {
        public InventarioUser()
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
            InicioUser CambioF = new InicioUser();
            CambioF.Show();
            this.Close();
        }

        private void InventarioUser_Load(object sender, EventArgs e)
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
