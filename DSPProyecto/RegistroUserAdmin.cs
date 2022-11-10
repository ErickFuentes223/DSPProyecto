using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DSPProyecto
{
    public partial class RegistroUserAdmin : Form
    {
        public RegistroUserAdmin()
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

        }

        private void label7_Click(object sender, EventArgs e)
        {
            txtUserReg.Clear();
            txtPassReg.Clear();
            txtNombreReg.Clear();
        }


        private void RegistroUserAdmin_Load(object sender, EventArgs e)
        {
            MostrarGridView();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AgregarUsuario();

            MostrarGridView();
        }


        #region funciones

        public void MostrarGridView()
        {
            SqlConnection cnx;
            cnx = new SqlConnection("Data Source=.;Initial Catalog=FarmaciaDonBoscoDSP;Integrated Security=True");
            cnx.Open();

            SqlCommand cm = new SqlCommand("Select * from usuarios", cnx);
            SqlDataAdapter adaptador = new SqlDataAdapter(cm);
            DataTable td = new DataTable();
            adaptador.Fill(td);
            dataGridView1.DataSource = td;
        }

        public void AgregarUsuario()
        {
            SqlConnection cnx;
            cnx = new SqlConnection("Data Source=.;Initial Catalog=FarmaciaDonBoscoDSP;Integrated Security=True");
            cnx.Open();

            SqlCommand cm = new SqlCommand("INSERT INTO usuarios(nombre,nickname,contrasena,rolUsuario) values ('" + txtNombreReg.Text + "','" + txtUserReg.Text + "','" + txtPassReg.Text + "','" + comboBoxRoles.Text + "')", cnx);

            cm.ExecuteNonQuery();

            MessageBox.Show("Se ha registrado correctamente", "Farmacia Don Bosco", MessageBoxButtons.OK);
        }

        #endregion
    }
}
