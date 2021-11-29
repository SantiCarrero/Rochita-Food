using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using Proyecto.Clases;

namespace Proyecto.Interfaces
{
    public partial class Auditoria : Form
    {
        public Auditoria()
        {
            InitializeComponent();
            llenarTabla();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
  
        private void Factura_Load(object sender, EventArgs e)
        {

        }

        public void llenarTabla()
        {
            //Un DataTable nos sirve como origne de datos de un DataGridView (una tabla que podrá llenarse con una consulta)
            DataTable dt = new DataTable();
            fachadaConexion con = new fachadaConexion();
            //Ver método llenarTablaConConsulta en Conexion.cs
            con.llenarTablaConConsulta("SELECT * FROM control ORDER BY ID ASC", dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
