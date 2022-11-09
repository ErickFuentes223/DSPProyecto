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
            Conexion c = new Conexion();

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


                    SqlCommand cmNickname = new SqlCommand("Select nickname from usuarios where nickname='"+txtUsername+"'", cnx);
            SqlDataReader drNickname = cmNickname.ExecuteReader();

            SqlCommand cmPasswd = new SqlCommand("Select contraseña from usuarios where nickname='" + txtUsername + "' AND contraseña='" + txtPassword + "'", cnx);
            SqlDataReader drPasswd = cmPasswd.ExecuteReader();

            SqlCommand cmRol = new SqlCommand("Select rolUsuario from usuarios where nickname='" + txtUsername + "' AND contraseña='" + txtPassword + "' AND rolUsuario='Administrador'", cnx);
            SqlDataReader drRol = cmRol.ExecuteReader();

            if (drNickname.Read())
            {
                if (drPasswd.Read())
                {
                    if(drRol.Read()){
                        MessageBox.Show("Bienvenido, Inicio de Seccion SDatisfactorio", "Farmacia Don Bosco", MessageBoxButtons.OK);
                        InicioAdmin CambioA = new InicioAdmin();
                        CambioA.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Bienvenido, Inicio de Seccion SDatisfactorio", "Farmacia Don Bosco", MessageBoxButtons.OK);
                        InicioUser CambioA = new InicioUser();
                        CambioA.Show();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Error!!! Credenciales Invalidas", "Farmacia Don Bosco", MessageBoxButtons.OK);
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
