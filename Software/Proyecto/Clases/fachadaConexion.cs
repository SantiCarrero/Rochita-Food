using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Proyecto.Clases
{
    class fachadaConexion
    {

        private string servidor = "127.0.0.1"; //Nombre o ip del servidor de MySQL
        private string bd = "proyecto"; //Nombre de la base de datos
        private string usuario = "root"; //Usuario de acceso a MySQL
        private string password = ""; //Contraseña de usuario de acceso a MySQL
        private string[] datos = null; //Variable para almacenar el resultado
        private string cadenaConexion;
        private MySqlConnection conexionBD;
        public fachadaConexion()
        {
            //Crearemos la cadena de conexión concatenando las variables

            cadenaConexion = "Database=" + Bd + "; Data Source=" + Servidor + "; User Id=" + Usuario + "; Password=" + Password + "";
            //Instancia para conexión a MySQL, recibe la cadena de conexión
            conexionBD = new MySqlConnection(cadenaConexion);
        }

            





        public bool ejecutarInsert(string consulta)
        {
            bool ok = false;


            //Agregamos try-catch para capturar posibles errores de conexión o sintaxis.
            try
            {
                MySqlCommand comando = new MySqlCommand(consulta); //Declaración SQL para ejecutar contra una base de datos MySQL
                comando.Connection = conexionBD; //Establece la MySqlConnection utilizada por esta instancia de MySqlCommand
                conexionBD.Open(); //Abre la conexión
                comando.ExecuteNonQuery();

                ok = true;

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message); //Si existe un error aquí muestra el mensaje
                ok = false;
            }
            finally
            {
                conexionBD.Close(); //Cierra la conexión a MySQL
            }
            return ok;
        }

        public string[] ejecutarConsulta(string consulta)
        {

            MySqlDataReader reader = null; //Variable para leer el resultado de la consulta

            //Agregamos try-catch para capturar posibles errores de conexión o sintaxis.
            try
            {

                MySqlCommand comando = new MySqlCommand(consulta); //Declaración SQL para ejecutar contra una base de datos MySQL
                comando.Connection = conexionBD; //Establece la MySqlConnection utilizada por esta instancia de MySqlCommand
                conexionBD.Open(); //Abre la conexión
                reader = comando.ExecuteReader(); //Ejecuta la consulta y crea un MySqlDataReader
                int i = 0;
                while (reader.Read()) //Avanza MySqlDataReader al siguiente registro
                {
                    datos[i] = reader.GetString(0) + "\n"; //Almacena cada registro con un salto de linea
                    i++;
                }



            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message); //Si existe un error aquí muestra el mensaje

            }
            finally
            {
                conexionBD.Close(); //Cierra la conexión a MySQL
            }
            return datos;
        }

        //ejecuta unprocedimiento almacenado
        //Precondicion: conexion creada
        public void llenarTablaConProcedimiento(String nombreProcedimiento, DataTable tabla)
        {
            MySqlCommand comando = new MySqlCommand(nombreProcedimiento, conexionBD);
            //asignar nombre del procedure al commandText
            comando.CommandText = nombreProcedimiento;
            //el commandtipe debe ser procedimiento almacenado
            comando.CommandType = CommandType.StoredProcedure;
            //adaptador para ejecutar el comando y traer los datos a una tabla
            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
            //llenamos el dataTable
            adaptador.Fill(tabla);

        }

        //ejecuta UNA CONSULTA COMÚN
        //Precondicion: conexion creada
        public void llenarTablaConConsulta(String consulta, DataTable tabla)
        {
            //Crear el SqlCommand con la consulta
            MySqlCommand comando = new MySqlCommand(consulta, conexionBD);
            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
            //llenamos el dataTable
            adaptador.Fill(tabla);

        }


        //ejecuta unprocedimiento almacenado CON UN PARÁMETRO 
        //Precondicion: conexion creada
        public void llenarTablaConProcedimientoParametro(String parametro, String valor, String nombreProcedimiento, DataTable tabla)
        {
            SqlCommand comando = new SqlCommand(nombreProcedimiento);
            //asignar nombre del procedure al commandText
            comando.CommandText = nombreProcedimiento;
            //el commandtipe debe ser procedimiento almacenado
            comando.CommandType = CommandType.StoredProcedure;
            //definimos el parámetro para agregarlo al procedimiento
            SqlParameter argumento = new SqlParameter();
            // SqlParameter argumento = new SqlParameter("@"+parametro, SqlDbType.VarChar);
            //Nombre y tipo del parámetro
            argumento.ParameterName = "@" + parametro;
            argumento.SqlDbType = SqlDbType.VarChar;
            //Valor del parámetro
            argumento.SqlValue = valor;
            //Agregar argumento al comando
            comando.Parameters.Add(argumento);
            //adaptador para ejecutar el comando y traer los datos a una tabla
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            //llenamos el dataTable
            adaptador.Fill(tabla);

        }


        // Validacion de usuario login
         
        







        public string Servidor { get => servidor; set => servidor = value; }
        public string Bd { get => bd; set => bd = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Password { get => password; set => password = value; }
        public string[] Datos { get => datos; set => datos = value; }


    }

}


   


   

          


