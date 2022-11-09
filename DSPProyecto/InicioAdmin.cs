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
    public partial class InicioAdmin : Form
    {
        public InicioAdmin()
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

        private void btnBodega_Click(object sender, EventArgs e)
        {
            InventarioAdmin CambioF = new InventarioAdmin();
            CambioF.Show();
            this.Close();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            RegistroUserAdmin CambioF = new RegistroUserAdmin();
            CambioF.Show();
            this.Close();
        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
          Facturizacion CambioF = new Facturizacion();
            CambioF.Show();
            this.Close();
        }
    }
}
