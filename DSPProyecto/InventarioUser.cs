﻿using System;
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

     
    }
}
