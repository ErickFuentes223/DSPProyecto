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
            ConfirmDel CambioF = new ConfirmDel();
            CambioF.Show();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            ModProduct CambioF = new ModProduct();
            CambioF.Show();
        }
    }
}
