using System;
using System.Windows.Forms;

namespace DSPProyecto
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
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
