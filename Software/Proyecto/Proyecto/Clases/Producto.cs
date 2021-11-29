using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Clases
{
    class Producto
    {

        private string nombre;
        private int stock;
        private int codigo;
        private int precio;

        public Producto(string nombre, int stock, int codigo, int precio)
        {
            this.nombre = nombre;
            this.stock = stock;
            this.codigo = codigo;
            this.precio = precio;

        }


    }
}
