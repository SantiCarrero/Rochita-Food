using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Proyecto.Clases;
using MySql.Data.MySqlClient;
using Proyecto.Interfaces;


namespace Proyecto.Interfaces
{
    
    public partial class Login : Form
    {

        
        public Login()
        {

        InitializeComponent();
        }


    
      
        
       

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registro registro = new Registro();
            this.Hide();
            registro.Show();



        }

        private void label_password_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Recuperacion restablecimiento = new Recuperacion();
            this.Hide();
            restablecimiento.Show();
        }

        private void btn_verContraSup_Click(object sender, EventArgs e)
        {

            textBox_Password.PasswordChar = '*';


            btn_verContra.Visible = true;
            btn_verContraSup.Visible = false;
        }

        private void btn_verContra_Click(object sender, EventArgs e)
        {
            textBox_Password.PasswordChar = '\0';



            btn_verContra.Visible = false;
            btn_verContraSup.Visible = true;

        }


        
        // Metodo para iniciar sesion
        private void Iniciar()
        {
            string usuario = textBox_Usuario.Text;
            string pass = textBox_Password.Text;
            string tipo = comboBoxUsuario.Text;

            pass = Encrypt.GetSHA256(pass);



            //string consulta = "SELECT usuario,password,ti FROM usuario WHERE usuario='" + usuario +  "' AND LIMIT 1;";
            string consulta = "SELECT usuario,password,TipodeUsuario FROM usuario WHERE usuario='"+usuario+"' AND TipodeUsuario='"+tipo+"' LIMIT 1;";
            fachadaConexion fc = new fachadaConexion();

            DataTable datos = new DataTable();
            fc.llenarTablaConConsulta(consulta, datos);
            if (datos.Rows.Count == 0) //Si no obtenemos resultados en nuestra consulta, es porque no existe ese usuario
            {
                MessageBox.Show("No existe el usuario seleccionado");
            }
            else
            {
                foreach (DataRow registro in datos.Rows)
                {

                    String correctPassword = (string)registro["password"];
                    string administrador = (string)registro["TipodeUsuario"];

                    if (pass != correctPassword)
                    {
                        MessageBox.Show("La contraseña es incorrecta");
                    }
                    else if (pass == correctPassword && tipo == administrador) //la contraseña es correcta
                    {

                        string User = textBox_Usuario.Text;
                        string TipoUser = comboBoxUsuario.Text;
                        AppGeneral general = new AppGeneral(User,TipoUser);

                        this.Hide();
                        general.Show();


                    }
                }

            }

        }


        private void btn_iniciarSesion_Click(object sender, EventArgs e)
        {
            Iniciar();
        }

        private void textBox_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {

                Iniciar();


            }


            
        }
    }
}
