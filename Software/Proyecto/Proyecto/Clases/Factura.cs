using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Clases
{
    class Factura
    {

        private int cartId;
        private int ordenId;
        private DateTime fecha;
        private string metodoDePago;
        private string tipoDeEnvio;

        public Factura(int cartId, int ordenId, DateTime fecha, string metodoDePago, string tipoDeEnvio)
        {
            this.cartId = cartId;
            this.ordenId = ordenId;
            this.fecha = fecha;
            this.metodoDePago = metodoDePago;
            this.tipoDeEnvio = tipoDeEnvio;

        }

        public string lugarOrden()
        {
            return "Domicilio/direccion";

        }
    }
}
