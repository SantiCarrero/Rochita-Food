using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Clases
{
    class Cliente
    {
        // Creamos los atributos de la clase Cliente
        private string direccion;
        private int contacto;

        // Creamos el constructor y dejamos los atributos privados visibles
        public Cliente(string direccion, int contacto)
        {
            this.direccion = direccion;
            this.contacto = contacto;
        }

        public string register()
        {
            return "Registro exitoso";

        }

        public string login()
        {
            return "Inicio de sesion correctamente";

        }

        public bool actualizarPerfil()
        {

            return true;
        }
    }
}
