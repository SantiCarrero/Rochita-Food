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
    public partial class GestiondeVentas : Form
    {
        public GestiondeVentas()
        {
            InitializeComponent();
            llenarTabla();
        }

        public GestiondeVentas(string text,string text2)
        {
            InitializeComponent();
            llenarTabla();
            lab_usuario.Text = text;
            TipoUserlab.Text = text2;


        }

        // Listado de todos los metodos que se van a usar
        //
        // Metodo de para ingresar una venta

        private void IngresarVenta()
        {
            string nomProducto = txt_nombreproducto.Text;
            string precio = txt_precio.Text;
            string fecha = dateTimePicker1.Text;
            string TipoPago = txt_tipodepago.Text;
            string TipoEnvio = txt_tipodeenvio.Text;
            string Total = txt_total.Text;
            


            string sentencia = "INSERT INTO factura (nombre_producto,Fecha,precio,Tipo_de_pago,Tipo_de_Envio,Total) VALUES ('" + nomProducto + "', '" + fecha + "', '" + precio + "','" + TipoPago + "','"+TipoEnvio+ "','"+ Total+ "') ;";
            fachadaConexion con = new fachadaConexion();

            if (txt_nombreproducto.Text == "" || txt_precio.Text == "" ||txt_tipodepago.Text == "" || txt_tipodeenvio.Text == "" || txt_total.Text == "")
            {

                MessageBox.Show("Le falta rellenar algun campo vacio");
            }

            else if (con.ejecutarInsert(sentencia) == true)
            {
                MessageBox.Show("Venta ingresada");
                llenarTabla();
            }
            else
            {
                MessageBox.Show("Error en la comunicación con la base de datos");
            };

        }

        // Metodo para modificar una venta

        private void modificarVenta()
        {
            string nomProducto = txt_nombreproducto.Text;
            string precio = txt_precio.Text;
            string fecha = dateTimePicker1.Text;
            string TipoPago = txt_tipodepago.Text;
            string TipoEnvio = txt_tipodeenvio.Text;
            string Total = txt_total.Text;
            string idSeleccionada = txtBox_codigo.Text.Substring(0);
            string sentencia = "UPDATE factura set nombre_producto='" + nomProducto + "', Fecha='" + fecha + "', precio='" + precio + "', Tipo_de_Pago='" + TipoPago + "',Tipo_de_Envio='" + TipoEnvio + "',Total='" + Total + "' WHERE id='" + idSeleccionada + "' ;";


            fachadaConexion con = new fachadaConexion();

            if (txt_nombreproducto.Text == "" || txt_precio.Text == "" || txt_tipodepago.Text == "" || txt_tipodeenvio.Text == "" || txt_total.Text == "")
            {

                MessageBox.Show("Tiene algun campo sin rellenar");
            }

            else if (con.ejecutarInsert(sentencia))
            {
                MessageBox.Show("Venta modificada");

                llenarTabla();
            }
            else
            {
                MessageBox.Show("Error en la comunicación con la base de datos");
            };
        }

            // Metodo para eliminar una venta

            private void eliminarVenta()
        {
            string ClienteEliminado = txtBox_codigo.Text.Substring(0);

            DialogResult dialogResult = MessageBox.Show("Seguro que desea eliminar esta venta con esta ID: " + ClienteEliminado + "?", "CONFIRMAR", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                fachadaConexion con = new fachadaConexion();

                con.ejecutarInsert("DELETE FROM factura WHERE ID='" + ClienteEliminado + "';");
                llenarTabla();
                txtBox_codigo.Text = "Eliminado";

            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Procedimiento cancelado con exito");
            }


        }

        private void btn_MiCuenta_Click(object sender, EventArgs e)
        {
            string User = lab_usuario.Text;
            string Tuser = TipoUserlab.Text;
            GestionDeClientes clientes = new GestionDeClientes(User,Tuser);
            this.Hide();
            clientes.Show();
        }
       

        private void btn_Inicio_Click(object sender, EventArgs e)
        {
            string User = lab_usuario.Text;
            string Tuser = TipoUserlab.Text;
            AppGeneral Inicio = new AppGeneral(User,Tuser);
            this.Hide();
            Inicio.Show();

        }

        private void btn_inventario_Click(object sender, EventArgs e)
        {
            string User = lab_usuario.Text;
            string Tuser = TipoUserlab.Text;
            GestionDeInventario inventario = new GestionDeInventario(User,Tuser);
            this.Hide();
            inventario.Show();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

       

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        
        

        
        public void llenarTabla()
        {
            //Un DataTable nos sirve como origne de datos de un DataGridView (una tabla que podrá llenarse con una consulta)
            DataTable dt = new DataTable();
            fachadaConexion con = new fachadaConexion();
            //Ver método llenarTablaConConsulta en Conexion.cs
            con.llenarTablaConConsulta("SELECT * FROM factura ORDER BY ID ASC", dt);
            dataGrid.DataSource = dt;
        }

        
       


        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            eliminarVenta();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IngresarVenta();
            
        }

        

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            int fila = dataGrid.CurrentCell.RowIndex;

            txtBox_codigo.Text = dataGrid[0, fila].Value.ToString();
            txt_nombreproducto.Text = dataGrid[1, fila].Value.ToString();
            dateTimePicker1.Text = dataGrid[2, fila].Value.ToString();
            txt_precio.Text = dataGrid[3, fila].Value.ToString();
            txt_tipodepago.Text = dataGrid[4, fila].Value.ToString();
            txt_tipodeenvio.Text = dataGrid[5, fila].Value.ToString();
            txt_total.Text = dataGrid[6, fila].Value.ToString();


            
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            modificarVenta();

        }
    }
}
