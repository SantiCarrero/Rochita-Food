using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto.Clases;

namespace Proyecto.Interfaces
{
    public partial class GestionDeInventario : Form
    {
        public GestionDeInventario()
        {
         
            InitializeComponent();
            llenarTabla();
        
        }

        public GestionDeInventario(string text,string text2)
        {
            InitializeComponent();
            llenarTabla();
            lab_usuario.Text = text;
            TipouserLab.Text = text2;

        }


        // Listado de los metodos que se hacen uso en este formulario
        //
        // Metodo Ingresar producto
        private void IngresarProducto()
        {
            string nombreProd = textBox_Nombre.Text;
            string Stock = textBox_telefono.Text;
            string Precio = textBox_domicilio.Text;

            string sentencia = "INSERT INTO producto (Nombre,Stock,Precio) VALUES ('" + nombreProd + "', '" + Stock + "', '" + Precio + "') ;";
            fachadaConexion con = new fachadaConexion();

            
            
               if (textBox_Nombre.Text == "" || textBox_domicilio.Text == "" || textBox_telefono.Text == "")
                {
                    MessageBox.Show("Tiene algun campo faltante por rellenar");

                } else if (con.ejecutarInsert(sentencia) == true)
            {

                    MessageBox.Show("Producto ingresado");
                    llenarTabla();
                }
            
            else
            {
                MessageBox.Show("Error en la comunicación con la base de datos");
            };

        }
        // Metodo Modificar Producto
        private void ModificarProducto()
        {


            string nombreProd = textBox_Nombre.Text;
            string Stock = textBox_telefono.Text;
            string Precio = textBox_domicilio.Text;
            string idSeleccionada = textBox_codigo.Text.Substring(0);
            string sentencia = "UPDATE producto set Nombre='" + nombreProd + "', Stock='" + Stock + "', Precio='" + Precio + "' WHERE ID='" + idSeleccionada + "' ;";


            fachadaConexion con = new fachadaConexion();

            if (textBox_Nombre.Text == "" || textBox_domicilio.Text == "" || textBox_telefono.Text == "")
            {
                MessageBox.Show("Le falta algun campo por rellenar");

            }
            else if (con.ejecutarInsert(sentencia))
            {
                MessageBox.Show("Producto modificado");
                llenarTabla();

            }
            else
            {
                MessageBox.Show("Error en la comunicación con la base de datos");
            };

        }
        // Metoodo eliminar Producto
        
        private void eliminarProducto()
        {

            string ClienteEliminado = textBox_codigo.Text.Substring(0);

            DialogResult dialogResult = MessageBox.Show("Seguro que desea eliminar el producto con esta ID: " + ClienteEliminado + "?", "CONFIRMAR", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                fachadaConexion con = new fachadaConexion();

                con.ejecutarInsert("DELETE FROM producto WHERE ID='" + ClienteEliminado + "';");
                llenarTabla();
                textBox_codigo.Text = "Eliminado";

            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Procedimiento cancelado con exito");
            }
        }
        private void btn_clientes_Click(object sender, EventArgs e)
        {
            string User = lab_usuario.Text;
            string Tuser = TipouserLab.Text;
            GestionDeClientes clientes = new GestionDeClientes(User,Tuser);
            this.Hide();
            clientes.Show();
        }

        private void btn_Inicio_Click(object sender, EventArgs e)
        {
            string User = lab_usuario.Text;
            string Tuser = TipouserLab.Text;
            AppGeneral Inicio = new AppGeneral(User,Tuser);
            this.Hide();
            Inicio.Show();
        }

        private void btn_ventas_Click(object sender, EventArgs e)
        {
            string User = lab_usuario.Text;
            string Tuser = TipouserLab.Text;
            GestiondeVentas GestiondeVentas = new GestiondeVentas(User,Tuser);
            this.Hide();
            GestiondeVentas.Show();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

       

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void label7_Click(object sender, EventArgs e)
        {

        }

       

        public void llenarTabla()
        {
            //Un DataTable nos sirve como origne de datos de un DataGridView (una tabla que podrá llenarse con una consulta)
            DataTable dt = new DataTable();
            fachadaConexion con = new fachadaConexion();
            //Ver método llenarTablaConConsulta en Conexion.cs
            con.llenarTablaConConsulta("SELECT * FROM producto ORDER BY ID ASC", dt);
            dataGridView1.DataSource = dt;
        }
        


        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            IngresarProducto();

        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarProducto();

        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eliminarProducto();

        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dataGridView1.CurrentCell.RowIndex;

            textBox_codigo.Text = dataGridView1[0, fila].Value.ToString();
            textBox_Nombre.Text = dataGridView1[1, fila].Value.ToString();
            textBox_telefono.Text = dataGridView1[2, fila].Value.ToString();
            textBox_domicilio.Text = dataGridView1[3, fila].Value.ToString();
        }


      
        private void GestionDeInventario_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }
    }
}
