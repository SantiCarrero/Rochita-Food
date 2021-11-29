using Proyecto.Clases;
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
    public partial class AppGeneral : Form
    {
        public AppGeneral()
        {
            InitializeComponent();
        }

        public  AppGeneral(string text, string text2)
        {
            InitializeComponent();
            lbl_nombreUsuario.Text = text;
            TipoUserLab.Text = text2;
            
            
        }

        private void btn_MiCuenta_Click(object sender, EventArgs e)
        {

            string User = lbl_nombreUsuario.Text;
            string Tuser = TipoUserLab.Text;

            GestionDeClientes cliente = new GestionDeClientes(User,Tuser);
            this.Hide();
            cliente.Show();
        }

      

       

        private void btn_Inicio_Click(object sender, EventArgs e)
        {

            string User = lbl_nombreUsuario.Text;
            string Tuser = TipoUserLab.Text;

            AppGeneral appgeneral = new AppGeneral(User,Tuser);
            this.Hide();
            appgeneral.Show();
        }

       

        private void btn_inventario_Click(object sender, EventArgs e)
        {
            string User = lbl_nombreUsuario.Text;
            string Tuser = TipoUserLab.Text;

            GestionDeInventario inventario = new GestionDeInventario(User,Tuser);
            this.Hide();
            inventario.Show();
        }

        private void btn_ventas_Click(object sender, EventArgs e)
        {
            string User = lbl_nombreUsuario.Text;
            string Tuser = TipoUserLab.Text;

            GestiondeVentas ventas = new GestiondeVentas(User,Tuser);
            this.Hide();
            ventas.Show();

        }

       

        private void btn_usuarios_Click(object sender, EventArgs e)
        {
            string TipoUser = TipoUserLab.Text;

            if (TipoUser == "Moderador" || TipoUser == "Usuario General")
            {

                MessageBox.Show("No tienes los suficientes permisos para acceder a esta función.");
            } else
            {

                Usuarios usuarios = new Usuarios();
                usuarios.Show();
            }
            
        }

        private void btn_auditoria_Click(object sender, EventArgs e)
        {
            string TipoUser = TipoUserLab.Text;

            if (TipoUser == "Moderador" || TipoUser == "Usuario General")
            {

                MessageBox.Show("No tienes los suficientes permisos para acceder a esta función.");
            }
            else
            {

                Auditoria auditoria = new Auditoria();
                auditoria.Show();

            }

            }

        private void btn_cerrarSesion_Click_1(object sender, EventArgs e)
        {

	        Login cerrarApp = new Login();
	        this.Hide();
	        cerrarApp.Show();

        }
    }
}
