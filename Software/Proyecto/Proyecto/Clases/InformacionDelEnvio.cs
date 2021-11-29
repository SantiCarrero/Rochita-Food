using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Clases
{
    class InformacionDelEnvio
    {
        private int envioId;
        private string tipoDeEnvio;
        private int costoDeEnvio;

        public InformacionDelEnvio(int envioId, string tipoDeEnvio, int costoDeEnvio)
        {
            this.envioId = envioId;
            this.tipoDeEnvio = tipoDeEnvio;
            this.costoDeEnvio = costoDeEnvio;
        }
        
        public bool actualizarInfoEnvio()
        {

            return true;
        }
    }
}
