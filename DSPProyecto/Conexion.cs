using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DSPProyecto
{
    internal class Conexion : Login
    {
        SqlConnection cnx;

        public Conexion()
        {
            try
            {
                cnx = new SqlConnection("Data Source=.;Initial Catalog=FarmaciaDonBoscoDSP;Integrated Security=True"); 
                cnx.Open();

                MessageBox.Show("El Sistema se Ejecuto Correctamente", "Farmacia Don Bosco", MessageBoxButtons.OK);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error!! "+ ex, "Farmacia Don Bosco", MessageBoxButtons.OK);
                Application.Exit();
            }
        }
    }
}
