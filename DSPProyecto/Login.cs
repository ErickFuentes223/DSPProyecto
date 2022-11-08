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
            if (txtUsername.Text=="admin" && txtPassword.Text=="password")
            {
                new InicioSoya().Show();
                this.Hide();

            }
 
            else
            {
                MessageBox.Show("El usuario y/o contraseña son incorrectos, intente de nuevo");
                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();
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
    }
}
