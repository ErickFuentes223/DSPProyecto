using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

             if (txtUsername.Text == "admin" && txtPassword.Text == "password")
            {
                InicioAdmin CambioF = new InicioAdmin();
                CambioF.Show();
                this.Close();

            }
            else
             {
                if (txtUsername.Text == "user" && txtPassword.Text == "password")
                {
                    InicioUser CambioF = new InicioUser();
                    CambioF.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("El usuario y/o contraseña son incorrectos, intente de nuevo");
                    txtUsername.Clear();
                    txtPassword.Clear();
                    txtUsername.Focus();
                }

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
