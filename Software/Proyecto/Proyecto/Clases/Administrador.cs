using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Clases
{
    class Administrador
    {
        // Creamos los atributos de la clase Administrador

        private string adminName;
        private string email;

        // Creamos el constructor y dejamos los atributos privados visibles
        public Administrador(string adminName, string email)
        {

            this.adminName = adminName;
            this.email = email;

        }

        // Creamos los metodos que vamos a utilizar

        public bool actualizarCatalogo()
        {

            return true;
        }

        public bool modificar()
        {

            return true;
        }

        public bool eliminar()
        {

            return true;
        }

        public bool agregar()
        {

            return true;
        }
    }
}
