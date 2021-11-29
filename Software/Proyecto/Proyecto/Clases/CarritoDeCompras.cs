using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Clases
{
    class CarritoDeCompras
    {
        private int clienteId;
        private int cartId;
        private int productId;
        private int cantidad;


        public CarritoDeCompras(int clienteId, int cartId, int productId, int cantidad)
        {
            this.clienteId = clienteId;
            this.cartId = cartId;
            this.productId = productId;
            this.cantidad = cantidad;

        }

        public string añadirProducto()
        {

            return "El producto fue añadido";
        }

        public bool actualizarCantidad()
        {

            return true; 
        }

        public string verDetallesCarrito()
        {

            return "Detalles..";

        }

        public bool verificar()
        {

            return true;
        }

        public bool descartarProducto()
        {
            return true;

        }
    }
}
