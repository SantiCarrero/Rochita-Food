using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Clases
{
    class DetallesDelPedido
    {
        private int ordenId;
        private int productId;
        private string nombre;
        private int cantidad;
        private float total;

        public DetallesDelPedido(int ordenId, int productId, string nombre, int cantidad, float total)
        {

            this.ordenId = ordenId;
            this.productId = productId;
            this.nombre = nombre;
            this.cantidad = cantidad;
            this.total = total;
        }

        public int calcularPrecio()
        {

            return 0;
        }
    }

}
