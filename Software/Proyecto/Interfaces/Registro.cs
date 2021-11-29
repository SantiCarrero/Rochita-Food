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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        
        // Metodo de Registro
        private void Registrar()
        {

            string usuario = textBox_Usuario.Text;
            string correo = textBox_Correo.Text;
            string password = textBox_Password.Text;
            password = Encrypt.GetSHA256(password);



            string sentencia = "INSERT INTO usuario (usuario, correo, password) VALUES ('" + usuario + "', '" + correo + "', '" + password + "') ;";
            fachadaConexion con = new fachadaConexion();
            


            
            
                if (textBox_Usuario.Text == "" || textBox_Correo.Text == "" || textBox_Password.Text == "" || textBox_Password2.Text == "")
                {
                    MessageBox.Show("Le falta algun campo por rellenar");

                }
                else if (con.ejecutarInsert(sentencia) == true)
            {
                    MessageBox.Show("Registro exitoso");

                    

                    Login login = new Login();
                    this.Hide();
                    login.Show();
                }
            
            else
            {
                MessageBox.Show("Error en la comunicación con la base de datos");
            };

        } 

        
        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkIniciarSesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login logeo = new Login();
            this.Hide();
            logeo.Show();
        }

        // Oculta la contraseña
        private void btn_verContraSup_Click(object sender, EventArgs e)
        {

            textBox_Password.PasswordChar = '*';


            btn_verContra.Visible = true;
            btn_verContraSup.Visible = false;
        }

        private void btn_verRepeCon2_Click(object sender, EventArgs e)
        {
            textBox_Password2.PasswordChar = '*';


            btn_verRepeCon.Visible = true;
            btn_verRepeCon2.Visible = false;
        }

        // Hace visible la contraseña
        private void btn_verRepeCon_Click(object sender, EventArgs e)
        {

            textBox_Password2.PasswordChar = '\0';



            btn_verRepeCon.Visible = false;
            btn_verRepeCon2.Visible = true;
        }

        private void btn_verContra_Click(object sender, EventArgs e)
        {
            textBox_Password.PasswordChar = '\0';



            btn_verContra.Visible = false;
            btn_verContraSup.Visible = true;
        }



        private void btn_Registrarse_Click(object sender, EventArgs e)
        {

            Registrar();
        }

        private void Registro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {

                Registrar();
            }
        }
    }
}
