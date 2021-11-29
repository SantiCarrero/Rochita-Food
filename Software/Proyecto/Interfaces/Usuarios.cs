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
    public partial class Usuarios : Form
    {
        public Usuarios()
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
            con.llenarTablaConConsulta("SELECT * FROM usuario ORDER BY ID ASC", dt);
            dataGridView1.DataSource = dt;
        }

      

        private void txt_nombreproducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string usuario = txt_usuario.Text;
            string tipo_de_usuario = comboBox2.Text;
            string correo = txt_correo.Text;
            string contraseña = txt_contraseña.Text;
            contraseña = Encrypt.GetSHA256(contraseña);


            string sentencia = "INSERT INTO usuario (usuario,TipodeUsuario,correo,password) VALUES ('" + usuario + "', '" + tipo_de_usuario + "', '" + correo + "','" + contraseña + "') ;";
            fachadaConexion con = new fachadaConexion();

            if (con.ejecutarInsert(sentencia) == true)
            {
                MessageBox.Show("Usuario ingresado");
                llenarTabla();
            }
            else
            {
                MessageBox.Show("Error en la comunicación con la base de datos");
            };
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string usuario = txt_usuario.Text;
            string TipodeUsuario = comboBox2.Text;
            string correo = txt_correo.Text;
            string contraseña = txt_contraseña.Text;
            string idSeleccionada = txt_codigo.Text.Substring(0);
            string sentencia = "UPDATE usuario set TipodeUsuario='" + TipodeUsuario + "', Usuario='" + usuario + "', Correo='" + correo + "', password='" + contraseña + "' WHERE id='" + idSeleccionada + "' ;";


            fachadaConexion con = new fachadaConexion();


            if (con.ejecutarInsert(sentencia))
            {
                MessageBox.Show("Usuario modificado");
                llenarTabla();


            }
            else
            {
                MessageBox.Show("Error en la comunicación con la base de datos");
            };
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string ClienteEliminado = txt_codigo.Text.Substring(0);

            DialogResult dialogResult = MessageBox.Show("Seguro que desea eliminar esta venta con esta ID: " + ClienteEliminado + "?", "CONFIRMAR", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                fachadaConexion con = new fachadaConexion();

                con.ejecutarInsert("DELETE FROM usuario WHERE ID='" + ClienteEliminado + "';");
                llenarTabla();
                txt_codigo.Text = "Eliminado";

            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Procedimiento cancelado con exito");
            }

        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            llenarTabla();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dataGridView1.CurrentCell.RowIndex;

            txt_codigo.Text = dataGridView1[0, fila].Value.ToString();
            txt_usuario.Text = dataGridView1[2, fila].Value.ToString();
            comboBox2.Text = dataGridView1[1, fila].Value.ToString();
            txt_correo.Text = dataGridView1[3, fila].Value.ToString();
            txt_contraseña.Text = dataGridView1[4, fila].Value.ToString();
        }

       
    }
}
