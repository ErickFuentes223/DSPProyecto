using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DSPProyecto
{
    internal class Conexion
    {
        SqlConnection cnx;

        public Conexion()
        {
            try
            {
                cnx = new SqlConnection("Data Source=.;Initial Catalog=FARMACIADONBOSCO;Integrated Security=True");
                cnx.Open();

                MessageBox.Show("El sistema se ha Iniciado Correctamente","Farmacia Don Bosco", MessageBoxButtons.OK); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!!! "+ex.Message, "Error Inesperado", MessageBoxButtons.OK);
            }
        }
    }
}
