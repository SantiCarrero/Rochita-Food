  
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto.Clases;




namespace Proyecto.Interfaces
{
    public partial class GestionDeClientes : Form
    {
      

        public GestionDeClientes(string text,string text2)
        {

            InitializeComponent();
            llenarTabla();
            lab_usuario.Text = text;
            TipoUser.Text = text2;
            
        }

        // Listado de los metodos que se hacen uso en este formulario
        //

        // Metodo para Registrar un cliente
        //
        private void RegistrarCliente()
        {
            string nombre = textBox_Nombre.Text;
            string domicilio = textBox_domicilio.Text;
            string telefono = textBox_telefono.Text;

            string sentencia = "INSERT INTO cliente (Nombre, Direccion, Contacto) VALUES ('" + nombre + "', '" + domicilio + "', '" + telefono + "') ;";
            fachadaConexion con = new fachadaConexion();



            if (textBox_Nombre.Text == "" || textBox_domicilio.Text == "" || textBox_telefono.Text == "")
            {
                MessageBox.Show("Le falta algun campo por rellenar");


            } else if (con.ejecutarInsert(sentencia) == true )
            
            {
                MessageBox.Show("Cliente ingresado");
                llenarTabla();


            }
            else
            {
                MessageBox.Show("Error en la comunicación con la base de datos");
            };


        }
        // Metodo para modificar un cliente
        private void ModificarCliente()
        {
            string nombre = textBox_Nombre.Text;
            string domicilio = textBox_domicilio.Text;
            string telefono = textBox_telefono.Text;
            string idSeleccionada = txtBox_codigo.Text.Substring(0);
            string sentencia = "UPDATE cliente set Nombre='" + nombre + "', Direccion='" + domicilio + "', Contacto='" + telefono + "' WHERE id='" + idSeleccionada + "' ;";


            fachadaConexion con = new fachadaConexion();




            if (textBox_Nombre.Text == "" || textBox_domicilio.Text == "" || textBox_telefono.Text == "")
            {
                MessageBox.Show("Le falta algun campo por rellenar");

            }
            else if (con.ejecutarInsert(sentencia))
            {

                MessageBox.Show("Cliente modificado");
                llenarTabla();
            }


            else
            {
                MessageBox.Show("Error en la comunicación con la base de datos");
            };

        }


        // Metodo para eliminar a un cliente
        //

        private void EliminarCliente()
        {

            string ClienteEliminado = txtBox_codigo.Text.Substring(0);



            DialogResult dialogResult = MessageBox.Show("Seguro que desea eliminar el cliente con esta ID: " + ClienteEliminado + "?", "CONFIRMAR", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                fachadaConexion con = new fachadaConexion();

                con.ejecutarInsert("DELETE FROM cliente WHERE ID='" + ClienteEliminado + "';");
                llenarTabla();
                txtBox_codigo.Text = "Eliminado";

            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Procedimiento cancelado con exito");
            }



        }
       
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int fila = dataGridCliente.CurrentCell.RowIndex;

            txtBox_codigo.Text = dataGridCliente[0, fila].Value.ToString();
            textBox_Nombre.Text = dataGridCliente[1, fila].Value.ToString();
            textBox_domicilio.Text = dataGridCliente[2, fila].Value.ToString();
            textBox_telefono.Text = dataGridCliente[3, fila].Value.ToString();


        }

        

        private void btn_Inicio_Click(object sender, EventArgs e)
        {
            string User = lab_usuario.Text;
            string Tuser = TipoUser.Text;
            
            AppGeneral Inicio = new AppGeneral(User,Tuser);
            this.Hide();
            Inicio.Show();
        }

        private void btn_inventario_Click(object sender, EventArgs e)
        {
            string User = lab_usuario.Text;
            string Tuser = TipoUser.Text;
            GestionDeInventario inventario = new GestionDeInventario(User, Tuser);
            this.Hide();
            inventario.Show();
        }

        

       

        private void btn_ventas_Click(object sender, EventArgs e)
        {
            string User = lab_usuario.Text;
            string Tuser = TipoUser.Text;
            GestiondeVentas ventas = new GestiondeVentas(User,Tuser);
            this.Hide();
            ventas.Show();

        }

       


        

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            RegistrarCliente();
         

        }

        public void llenarTabla()
        {
            //Un DataTable nos sirve como origne de datos de un DataGridView (una tabla que podrá llenarse con una consulta)
            DataTable dt = new DataTable();
            fachadaConexion con = new fachadaConexion();
            //Ver método llenarTablaConConsulta en Conexion.cs
            con.llenarTablaConConsulta("SELECT * FROM cliente ORDER BY ID ASC", dt);
            dataGridCliente.DataSource = dt;
        }
        

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarCliente();


        }



        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {


            ModificarCliente();





        }

       
       

        private void textBox_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
     if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            llenarTabla();
        }

        

       
    }
}
