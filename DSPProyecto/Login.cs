using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DSPProyecto
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            conexion c = new conexion();

        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login();
        }

        public void login()
        {
            SqlConnection cnx;
            cnx = new SqlConnection("Data Source=.;Initial Catalog=FarmaciaDonBoscoDSP;Integrated Security=True");
            cnx.Open();


            SqlCommand cm = new SqlCommand("Select * from usuarios where nickname='"+txtUsername.Text+"' AND contraseña='"+ txtPassword.Text +"'", cnx);
            SqlDataReader dr = cm.ExecuteReader();

            if (dr.Read())
            {
                string rol = (string)dr.GetValue(4);

                if (rol == "Administrador")
                {
                    InicioAdmin AdminMenu = new InicioAdmin();
                    AdminMenu.Show();
                    MessageBox.Show("Bienvenido "+rol, "Farmacia Don Bosco", MessageBoxButtons.OK);
                    dr.Close();
                }
                else
                {
                    InicioUser Usermenu = new InicioUser();
                    Usermenu.Show();
                    MessageBox.Show("Bienvenido!!!"+rol, "Farmacia Don Bosco", MessageBoxButtons.OK);
                }

            }
            else
            {
                MessageBox.Show("Error!!! Credenciales Invalidas", "Farmacia Don Bosco", MessageBoxButtons.OK);
            }

        }
        

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OMostrar_Click(object sender, EventArgs e)
        {
            Ocultar.BringToFront();
            txtPassword.PasswordChar = '\0';
        }

        private void Ocultar_Click(object sender, EventArgs e)
        {
            OMostrar.BringToFront();
            txtPassword.PasswordChar = '*';
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';

        }
    }
}
