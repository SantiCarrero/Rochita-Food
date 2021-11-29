using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.Interfaces
{
    public partial class Recuperacion : Form
    {
        public Recuperacion()
        {
            InitializeComponent();
        }

        private void Recuperacion_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
       
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form cerrarSesion = new Login();
            this.Hide();
            cerrarSesion.Show();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Form Volver = new AppGeneral();
            this.Hide();
            Volver.Show();
        }
    }
}
